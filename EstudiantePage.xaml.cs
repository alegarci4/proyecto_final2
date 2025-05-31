using Microsoft.Maui.Controls;
using System;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace edu_comp
{
    public partial class EstudiantePage : ContentPage
    {
        private readonly int userId;
        private readonly string nombre;
        private readonly HttpClient httpClient = new();
        private const string ConnectionString = "Server=ALE_GARCIA\\SQLEXPRESS;Database=SistemaEducativo;Integrated Security=True;";
        private const string ApiKey = "APIKEY";

        public EstudiantePage(int userId, string nombre)
        {
            InitializeComponent();

            this.userId = userId;
            this.nombre = nombre;

            lblBienvenida.Text = $"Bienvenido, Estudiante {nombre}";

            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {ApiKey}");
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConsulta.Text))
            {
                await DisplayAlert("Aviso", "Por favor ingrese una consulta", "OK");
                return;
            }

            try
            {
                ((Button)sender).IsEnabled = false;

                string respuesta = await ObtenerRespuestaGroq(txtConsulta.Text);
                txtResultado.Text = respuesta;

                await GuardarBusquedaAsync(txtConsulta.Text, respuesta);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Error: {ex.Message}", "OK");
            }
            finally
            {
                ((Button)sender).IsEnabled = true;
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
                        new { role = "system", content = "Eres un tutor de computación para estudiantes. Explica de forma clara y con ejemplos." },
                        new { role = "user", content = consulta }
                    },
                    temperature = 0.7
                });

            response.EnsureSuccessStatusCode();

            var data = await response.Content.ReadFromJsonAsync<GroqApiResponse>();
            return data?.choices?.FirstOrDefault()?.message?.content ?? "No se recibió respuesta";
        }

        private async Task GuardarBusquedaAsync(string consulta, string respuesta)
        {
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                await conn.OpenAsync();

                using var cmd = new SqlCommand(
                    "INSERT INTO BusquedasEstudiantes (EstudianteId, Consulta, Respuesta) VALUES (@id, @consulta, @respuesta)",
                    conn);

                cmd.Parameters.AddWithValue("@id", userId);
                cmd.Parameters.AddWithValue("@consulta", consulta);
                cmd.Parameters.AddWithValue("@respuesta", respuesta);

                await cmd.ExecuteNonQueryAsync();
            }
            catch (SqlException ex)
            {
                await DisplayAlert("Error SQL", $"Error de base de datos: {ex.Message}", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Error inesperado: {ex.Message}", "OK");
            }
        }

        private async void BtnHistorial_Click(object sender, EventArgs e)
        {
            try
            {
                // Asumo que FormHistorial está migrado a una Page MAUI similar
                await Navigation.PushAsync(new HistorialPage(userId, "Estudiante"));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Error al abrir el historial: {ex.Message}", "OK");
            }
        }

        private async void BtnCerrar_Click(object sender, EventArgs e)
        {
            // En MAUI normalmente cerrar una página es hacer pop en navegación
            await Navigation.PopAsync();
        }

        // Clases para deserializar la respuesta de Groq
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
    }
}
