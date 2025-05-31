namespace edu_comp
{
    partial class FormHistorial
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
            dgvHistorial = new DataGridView();
            btnVerDetalle = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.BackgroundColor = Color.DarkSlateBlue;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Dock = DockStyle.Fill;
            dgvHistorial.Location = new Point(0, 0);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(800, 450);
            dgvHistorial.TabIndex = 0;
            // 
            // btnVerDetalle
            // 
            btnVerDetalle.BackColor = Color.LightSeaGreen;
            btnVerDetalle.FlatStyle = FlatStyle.Flat;
            btnVerDetalle.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerDetalle.ForeColor = Color.WhiteSmoke;
            btnVerDetalle.Location = new Point(24, 361);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(116, 52);
            btnVerDetalle.TabIndex = 1;
            btnVerDetalle.Text = "Ver detalles";
            btnVerDetalle.UseVisualStyleBackColor = false;
            btnVerDetalle.Click += btnVerDetalle_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(192, 0, 0);
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(675, 400);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(113, 38);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click_1;
            // 
            // FormHistorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(btnVerDetalle);
            Controls.Add(dgvHistorial);
            Name = "FormHistorial";
            Text = "FormHistorial";
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHistorial;
        private Button btnVerDetalle;
        private Button btnCerrar;
    }
}