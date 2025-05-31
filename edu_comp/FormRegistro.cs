using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace edu_comp
{
    public partial class FormRegistro : Form
    {
        private string tipoUsuario;
        private string connectionString = "Server=ALE_GARCIA\\SQLEXPRESS;Database=SistemaEducativo;Integrated Security=True;";

        public FormRegistro(string tipoUsuario)
        {
            InitializeComponent();
            this.tipoUsuario = tipoUsuario;
            this.Text = $"Registro - {tipoUsuario}";
            lblTitulo.Text = $"Registro - {tipoUsuario}";
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Por favor complete todos los campos");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Verificar si el email ya existe
                    string checkQuery = $"SELECT COUNT(*) FROM {(tipoUsuario == "Maestro" ? "Maestros" : "Estudiantes")} WHERE Email = @Email";

                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Email", email);
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Este email ya está registrado");
                            return;
                        }
                    }

                    // Insertar nuevo usuario
                    string insertQuery = $"INSERT INTO {(tipoUsuario == "Maestro" ? "Maestros" : "Estudiantes")} (Nombre, Email, Password) VALUES (@Nombre, @Email, @Password)";

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@Nombre", nombre);
                        insertCommand.Parameters.AddWithValue("@Email", email);
                        insertCommand.Parameters.AddWithValue("@Password", password);

                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro exitoso! Por favor inicie sesión");
                            VolverALogin();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar: {ex.Message}");
            }
        }

        private void btnVolverALogin_Click(object sender, EventArgs e)
        {
            VolverALogin();
        }
        private void VolverALogin()
        {
            FormLogin formLogin = new FormLogin(tipoUsuario);
            formLogin.Show();
            this.Hide();
        }
        private void FormRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                VolverALogin();
            }
        }
    }
}
