using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace edu_comp
{
    public partial class FormHistorial : Form
    {
        private readonly int userId;
        private readonly string tipoUsuario;
        private const string ConnectionString = "Server=ALE_GARCIA\\SQLEXPRESS;Database=SistemaEducativo;Integrated Security=True;";

        public FormHistorial(int userId, string tipoUsuario)
        {
            InitializeComponent();
            this.userId = userId;
            this.tipoUsuario = tipoUsuario;
            this.Text = $"Historial - {tipoUsuario}";
            CargarHistorial();
        }

        private void CargarHistorial()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = $@"SELECT 
                                        FechaBusqueda AS 'Fecha',
                                        Consulta AS 'Búsqueda',
                                        Respuesta AS 'Respuesta'
                                     FROM {(tipoUsuario == "Maestro" ? "BusquedasMaestros" : "BusquedasEstudiantes")} 
                                     WHERE {(tipoUsuario == "Maestro" ? "MaestroId" : "EstudianteId")} = @UserId 
                                     ORDER BY FechaBusqueda DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@UserId", userId);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvHistorial.DataSource = dt;
                    dgvHistorial.Columns["Fecha"].DefaultCellStyle.Format = "g";
                    dgvHistorial.Columns["Respuesta"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar historial: {ex.Message}");
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvHistorial.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvHistorial.SelectedRows[0];
                MessageBox.Show($"Fecha: {row.Cells["Fecha"].Value}\n\n" +
                               $"Búsqueda: {row.Cells["Búsqueda"].Value}\n\n" +
                               $"Respuesta: {row.Cells["Respuesta"].Value}",
                               "Detalle de búsqueda");
            }
        }

        

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}