namespace Precentacion
{
    partial class Todos_Los_Consultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Todos_Los_Consultar));
            this.btn_Consultar_Cliente = new System.Windows.Forms.Button();
            this.btn_Consultar_Cita = new System.Windows.Forms.Button();
            this.btn_Consultar_Mascota = new System.Windows.Forms.Button();
            this.btn_Consultar_Veterinario = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Consultar_Cliente
            // 
            this.btn_Consultar_Cliente.Location = new System.Drawing.Point(28, 29);
            this.btn_Consultar_Cliente.Name = "btn_Consultar_Cliente";
            this.btn_Consultar_Cliente.Size = new System.Drawing.Size(117, 23);
            this.btn_Consultar_Cliente.TabIndex = 0;
            this.btn_Consultar_Cliente.Text = "Consultar Cliente";
            this.btn_Consultar_Cliente.UseVisualStyleBackColor = true;
            this.btn_Consultar_Cliente.Click += new System.EventHandler(this.btn_Consultar_Cliente_Click);
            // 
            // btn_Consultar_Cita
            // 
            this.btn_Consultar_Cita.Location = new System.Drawing.Point(28, 74);
            this.btn_Consultar_Cita.Name = "btn_Consultar_Cita";
            this.btn_Consultar_Cita.Size = new System.Drawing.Size(117, 23);
            this.btn_Consultar_Cita.TabIndex = 1;
            this.btn_Consultar_Cita.Text = "Consultar Cita";
            this.btn_Consultar_Cita.UseVisualStyleBackColor = true;
            this.btn_Consultar_Cita.Click += new System.EventHandler(this.btn_Consultar_Cita_Click);
            // 
            // btn_Consultar_Mascota
            // 
            this.btn_Consultar_Mascota.Location = new System.Drawing.Point(28, 121);
            this.btn_Consultar_Mascota.Name = "btn_Consultar_Mascota";
            this.btn_Consultar_Mascota.Size = new System.Drawing.Size(117, 23);
            this.btn_Consultar_Mascota.TabIndex = 2;
            this.btn_Consultar_Mascota.Text = "Consultar Mascota";
            this.btn_Consultar_Mascota.UseVisualStyleBackColor = true;
            this.btn_Consultar_Mascota.Click += new System.EventHandler(this.btn_Consultar_Mascota_Click);
            // 
            // btn_Consultar_Veterinario
            // 
            this.btn_Consultar_Veterinario.Location = new System.Drawing.Point(28, 171);
            this.btn_Consultar_Veterinario.Name = "btn_Consultar_Veterinario";
            this.btn_Consultar_Veterinario.Size = new System.Drawing.Size(117, 23);
            this.btn_Consultar_Veterinario.TabIndex = 3;
            this.btn_Consultar_Veterinario.Text = "Consultar Veterinario";
            this.btn_Consultar_Veterinario.UseVisualStyleBackColor = true;
            this.btn_Consultar_Veterinario.Click += new System.EventHandler(this.btn_Consultar_Veterinario_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(191, 12);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(51, 23);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Consultar_Cliente);
            this.groupBox1.Controls.Add(this.btn_Consultar_Veterinario);
            this.groupBox1.Controls.Add(this.btn_Consultar_Cita);
            this.groupBox1.Controls.Add(this.btn_Consultar_Mascota);
            this.groupBox1.Location = new System.Drawing.Point(40, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 220);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // Todos_Los_Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 333);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Todos_Los_Consultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todos_Los_Consultar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Consultar_Cliente;
        private System.Windows.Forms.Button btn_Consultar_Cita;
        private System.Windows.Forms.Button btn_Consultar_Mascota;
        private System.Windows.Forms.Button btn_Consultar_Veterinario;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}