namespace Precentacion
{
    partial class Menu_Recepcio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Recepcio));
            this.btn_Registrar_Medico = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_Registrar_Cliente = new System.Windows.Forms.Button();
            this.btn_Registrar_Mascota = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Historial = new System.Windows.Forms.Button();
            this.btn_Agendar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Registrar_Medico
            // 
            this.btn_Registrar_Medico.Location = new System.Drawing.Point(109, 299);
            this.btn_Registrar_Medico.Name = "btn_Registrar_Medico";
            this.btn_Registrar_Medico.Size = new System.Drawing.Size(104, 24);
            this.btn_Registrar_Medico.TabIndex = 4;
            this.btn_Registrar_Medico.Text = "Registrar Medico";
            this.btn_Registrar_Medico.UseVisualStyleBackColor = true;
            this.btn_Registrar_Medico.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(404, 120);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(68, 23);
            this.btn_Actualizar.TabIndex = 7;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Location = new System.Drawing.Point(631, 120);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(61, 23);
            this.btn_Consultar.TabIndex = 8;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            // 
            // btn_Registrar_Cliente
            // 
            this.btn_Registrar_Cliente.Location = new System.Drawing.Point(109, 168);
            this.btn_Registrar_Cliente.Name = "btn_Registrar_Cliente";
            this.btn_Registrar_Cliente.Size = new System.Drawing.Size(104, 21);
            this.btn_Registrar_Cliente.TabIndex = 21;
            this.btn_Registrar_Cliente.Text = "Registrar Cliente";
            this.btn_Registrar_Cliente.UseVisualStyleBackColor = true;
            this.btn_Registrar_Cliente.Click += new System.EventHandler(this.btn_Registrar_Cliente_Click);
            // 
            // btn_Registrar_Mascota
            // 
            this.btn_Registrar_Mascota.Location = new System.Drawing.Point(109, 231);
            this.btn_Registrar_Mascota.Name = "btn_Registrar_Mascota";
            this.btn_Registrar_Mascota.Size = new System.Drawing.Size(104, 23);
            this.btn_Registrar_Mascota.TabIndex = 22;
            this.btn_Registrar_Mascota.Text = "Registrar Mascota";
            this.btn_Registrar_Mascota.UseVisualStyleBackColor = true;
            this.btn_Registrar_Mascota.Click += new System.EventHandler(this.btn_Registrar_Mascota_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(876, 477);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Historial
            // 
            this.btn_Historial.Location = new System.Drawing.Point(522, 120);
            this.btn_Historial.Name = "btn_Historial";
            this.btn_Historial.Size = new System.Drawing.Size(62, 23);
            this.btn_Historial.TabIndex = 24;
            this.btn_Historial.Text = "Historial";
            this.btn_Historial.UseVisualStyleBackColor = true;
            // 
            // btn_Agendar
            // 
            this.btn_Agendar.Location = new System.Drawing.Point(282, 120);
            this.btn_Agendar.Name = "btn_Agendar";
            this.btn_Agendar.Size = new System.Drawing.Size(82, 23);
            this.btn_Agendar.TabIndex = 25;
            this.btn_Agendar.Text = "Agendar cita";
            this.btn_Agendar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(739, 120);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(61, 23);
            this.btn_Eliminar.TabIndex = 26;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // Menu_Recepcio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 472);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Agendar);
            this.Controls.Add(this.btn_Historial);
            this.Controls.Add(this.btn_Registrar_Mascota);
            this.Controls.Add(this.btn_Registrar_Cliente);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_Registrar_Medico);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu_Recepcio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Recepcio";
            this.Load += new System.EventHandler(this.Menu_Recepcio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Registrar_Medico;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Button btn_Registrar_Cliente;
        private System.Windows.Forms.Button btn_Registrar_Mascota;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Historial;
        private System.Windows.Forms.Button btn_Agendar;
        private System.Windows.Forms.Button btn_Eliminar;
    }
}