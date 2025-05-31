namespace edu_comp
{
    partial class FormInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            btnEstudiante = new Button();
            btnMaestro = new Button();
            btnCerrar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnEstudiante
            // 
            btnEstudiante.BackColor = Color.MidnightBlue;
            btnEstudiante.FlatStyle = FlatStyle.Flat;
            btnEstudiante.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEstudiante.ForeColor = Color.LightSkyBlue;
            btnEstudiante.Location = new Point(255, 109);
            btnEstudiante.Name = "btnEstudiante";
            btnEstudiante.Size = new Size(287, 107);
            btnEstudiante.TabIndex = 0;
            btnEstudiante.Text = "Soy Estudiante";
            btnEstudiante.UseVisualStyleBackColor = false;
            btnEstudiante.Click += btnEstudiante_Click;
            // 
            // btnMaestro
            // 
            btnMaestro.BackColor = Color.MidnightBlue;
            btnMaestro.FlatStyle = FlatStyle.Flat;
            btnMaestro.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMaestro.ForeColor = Color.LightSkyBlue;
            btnMaestro.Location = new Point(255, 246);
            btnMaestro.Name = "btnMaestro";
            btnMaestro.Size = new Size(287, 107);
            btnMaestro.TabIndex = 1;
            btnMaestro.Text = "Soy Maestro";
            btnMaestro.UseVisualStyleBackColor = false;
            btnMaestro.Click += btnMaestro_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.DarkRed;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = SystemColors.ButtonHighlight;
            btnCerrar.Location = new Point(12, 404);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(96, 34);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Salir";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(46, 24);
            label1.Name = "label1";
            label1.Size = new Size(112, 60);
            label1.TabIndex = 3;
            label1.Text = "EDU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(143, 38);
            label2.Name = "label2";
            label2.Size = new Size(200, 41);
            label2.TabIndex = 4;
            label2.Text = "Comp Jutiapa";
            label2.Click += label2_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(803, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnMaestro);
            Controls.Add(btnEstudiante);
            DoubleBuffered = true;
            Name = "FormInicio";
            Text = "FormInicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEstudiante;
        private Button btnMaestro;
        private Button btnCerrar;
        private Label label1;
        private Label label2;
    }
}
