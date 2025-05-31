namespace edu_comp
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin("Estudiante");
            formLogin.Show();
            this.Hide();
        }

        private void btnMaestro_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin("Maestro");
            formLogin.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
