namespace edu_comp
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnIniciarSesion = new Button();
            btnRegistro = new Button();
            lblTitulo = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(289, 73);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 27);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(289, 174);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(229, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.DarkViolet;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciarSesion.ForeColor = Color.Cyan;
            btnIniciarSesion.Location = new Point(231, 276);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(148, 49);
            btnIniciarSesion.TabIndex = 2;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.DarkViolet;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistro.ForeColor = Color.Cyan;
            btnRegistro.Location = new Point(446, 276);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(135, 49);
            btnRegistro.TabIndex = 3;
            btnRegistro.Text = "Registrarse";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(173, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(76, 31);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(202, 73);
            label1.Name = "label1";
            label1.Size = new Size(70, 31);
            label1.TabIndex = 5;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(137, 170);
            label2.Name = "label2";
            label2.Size = new Size(129, 31);
            label2.TabIndex = 6;
            label2.Text = "Contraseña";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Controls.Add(btnRegistro);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnIniciarSesion;
        private Button btnRegistro;
        private Label lblTitulo;
        private Label label1;
        private Label label2;
    }
}