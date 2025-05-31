namespace edu_comp
{
    partial class FormMaestro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaestro));
            txtConsulta = new TextBox();
            btnBuscar = new Button();
            txtResultado = new TextBox();
            btnHistorial = new Button();
            lblBienvenida = new Label();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // txtConsulta
            // 
            txtConsulta.Location = new Point(177, 75);
            txtConsulta.Name = "txtConsulta";
            txtConsulta.Size = new Size(288, 27);
            txtConsulta.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.LightSeaGreen;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(503, 70);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(142, 36);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.SteelBlue;
            txtResultado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.ForeColor = Color.White;
            txtResultado.Location = new Point(130, 152);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ScrollBars = ScrollBars.Vertical;
            txtResultado.Size = new Size(548, 218);
            txtResultado.TabIndex = 2;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.Violet;
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistorial.Location = new Point(133, 386);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(134, 30);
            btnHistorial.TabIndex = 3;
            btnHistorial.Text = "Ver mi historial";
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.BackColor = Color.Transparent;
            lblBienvenida.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.White;
            lblBienvenida.Location = new Point(96, 9);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(91, 38);
            lblBienvenida.TabIndex = 4;
            lblBienvenida.Text = "label1";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(192, 0, 0);
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(733, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(55, 36);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormMaestro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(lblBienvenida);
            Controls.Add(btnHistorial);
            Controls.Add(txtResultado);
            Controls.Add(btnBuscar);
            Controls.Add(txtConsulta);
            Name = "FormMaestro";
            Text = "FormMaestro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtConsulta;
        private Button btnBuscar;
        private TextBox txtResultado;
        private Button btnHistorial;
        private Label lblBienvenida;
        private Button btnCerrar;
    }
}