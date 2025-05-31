using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace edu_comp
{
    public partial class FormLogin : Form
    {
        private string tipoUsuario;
        private string connectionString = "Server=ALE_GARCIA\\SQLEXPRESS;Database=SistemaEducativo;Integrated Security=True;";

        public FormLogin(string tipoUsuario)
        {
            InitializeComponent();
            this.tipoUsuario = tipoUsuario;
            this.Text = $"Inicio de Sesión - {tipoUsuario}";
            lblTitulo.Text = $"Inicio de Sesión - {tipoUsuario}";
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor ingrese email y contraseña");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"SELECT Id, Nombre FROM {(tipoUsuario == "Maestro" ? "Maestros" : "Estudiantes")} WHERE Email = @Email AND Password = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int userId = reader.GetInt32(0);
                                string nombre = reader.GetString(1);

                                // Abrir formulario de búsqueda correspondiente
                                if (tipoUsuario == "Maestro")
                                {
                                    FormMaestro formMaestro = new FormMaestro(userId, nombre);
                                    formMaestro.Show();
                                }
                                else
                                {
                                    FormEstudiante formEstudiante = new FormEstudiante(userId, nombre);
                                    formEstudiante.Show();
                                }

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Credenciales incorrectas");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar sesión: {ex.Message}");
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            FormRegistro formRegistro = new FormRegistro(tipoUsuario);
            formRegistro.Show();
            this.Hide();
        }
        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                FormInicio formInicio = new FormInicio();
                formInicio.Show();
            }
        }
    }
}

