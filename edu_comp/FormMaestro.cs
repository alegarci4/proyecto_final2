using System;
using System.Data.SqlClient;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edu_comp
{
    public partial class FormMaestro : Form
    {
        private readonly int userId;
        private readonly string nombre;
        private readonly HttpClient httpClient = new HttpClient();
        private const string ConnectionString = "Server=ALE_GARCIA\\SQLEXPRESS;Database=SistemaEducativo;Integrated Security=True;";
        private const string ApiKey = "APIKEY";

        public FormMaestro(int userId, string nombre)
        {
            InitializeComponent();
            this.userId = userId;
            this.nombre = nombre;
            lblBienvenida.Text = $"Bienvenido, Maestro {nombre}";
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {ApiKey}");
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConsulta.Text))
            {
                MessageBox.Show("Por favor ingrese una consulta");
                return;
            }

            try
            {
                btnBuscar.Enabled = false;
                Cursor = Cursors.WaitCursor;

                var respuesta = await ObtenerRespuestaGroq(txtConsulta.Text);
                txtResultado.Text = respuesta;
                GuardarBusqueda(txtConsulta.Text, respuesta);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnBuscar.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private async Task<string> ObtenerRespuestaGroq(string consulta)
        {
            var response = await httpClient.PostAsJsonAsync(
                "https://api.groq.com/openai/v1/chat/completions",
                new
                {
                    model = "llama3-70b-8192",
                    messages = new[]
                    {
                        new { role = "system", content = "Eres un experto en computación para docentes. Proporciona explicaciones técnicas detalladas." },
                        new { role = "user", content = consulta }
                    },
                    temperature = 0.7
                });

            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadFromJsonAsync<GroqApiResponse>();
            return data?.choices?.FirstOrDefault()?.message?.content ?? "No se recibió respuesta";
        }

        private void GuardarBusqueda(string consulta, string respuesta)
        {
            try
            {
                using (var conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand(
                        "INSERT INTO BusquedasMaestros (MaestroId, Consulta, Respuesta) VALUES (@id, @consulta, @respuesta)",
                        conn);

                    cmd.Parameters.AddWithValue("@id", userId);
                    cmd.Parameters.AddWithValue("@consulta", consulta);
                    cmd.Parameters.AddWithValue("@respuesta", respuesta);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de base de datos: {ex.Message}", "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            try
            {
                var formHistorial = new FormHistorial(userId, "Maestro");
                formHistorial.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el historial: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMaestro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // Clases para deserialización (las mismas que en FormEstudiante pero locales a esta clase)
        private class GroqApiResponse
        {
            public GroqChoice[] choices { get; set; }
        }

        private class GroqChoice
        {
            public GroqMessage message { get; set; }
        }

        private class GroqMessage
        {
            public string content { get; set; }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}