namespace edu_comp
{
    partial class FormRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistro));
            btnRegistrarse = new Button();
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnVolverALogin = new Button();
            lblTitulo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = Color.MediumSlateBlue;
            btnRegistrarse.FlatStyle = FlatStyle.Flat;
            btnRegistrarse.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarse.ForeColor = Color.MidnightBlue;
            btnRegistrarse.Location = new Point(234, 312);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(154, 41);
            btnRegistrarse.TabIndex = 0;
            btnRegistrarse.Text = "Registrarse ";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(333, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(237, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(333, 109);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(237, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(333, 175);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(237, 27);
            txtPassword.TabIndex = 3;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(333, 242);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(237, 27);
            txtConfirmPassword.TabIndex = 4;
            // 
            // btnVolverALogin
            // 
            btnVolverALogin.BackColor = Color.MediumSlateBlue;
            btnVolverALogin.FlatStyle = FlatStyle.Flat;
            btnVolverALogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolverALogin.ForeColor = Color.MidnightBlue;
            btnVolverALogin.Location = new Point(408, 312);
            btnVolverALogin.Name = "btnVolverALogin";
            btnVolverALogin.Size = new Size(172, 41);
            btnVolverALogin.TabIndex = 5;
            btnVolverALogin.Text = "Volver a Form Login";
            btnVolverALogin.UseVisualStyleBackColor = false;
            btnVolverALogin.Click += btnVolverALogin_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.WhiteSmoke;
            lblTitulo.Location = new Point(31, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(65, 28);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(234, 61);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(252, 116);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 8;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(215, 175);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 9;
            label3.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(135, 249);
            label4.Name = "label4";
            label4.Size = new Size(197, 25);
            label4.TabIndex = 10;
            label4.Text = "Confirma tu contraseña";
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Controls.Add(btnVolverALogin);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Controls.Add(btnRegistrarse);
            Name = "FormRegistro";
            Text = "FormRegistro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarse;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnVolverALogin;
        private Label lblTitulo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}