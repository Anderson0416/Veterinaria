namespace Precentacion
{
    partial class Consultar_Mascota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar_Mascota));
            this.dgv_Mascota = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Especie = new System.Windows.Forms.TextBox();
            this.txt_Raza = new System.Windows.Forms.TextBox();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.txt_Cliente_Documento = new System.Windows.Forms.TextBox();
            this.btn_Eliminar_Mascota = new System.Windows.Forms.Button();
            this.cbx_Sexo = new System.Windows.Forms.ComboBox();
            this.btn_Actualizar_Mascota = new System.Windows.Forms.Button();
            this.cbx_Edad2 = new System.Windows.Forms.ComboBox();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Mascota
            // 
            this.dgv_Mascota.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Mascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mascota.Location = new System.Drawing.Point(12, 327);
            this.dgv_Mascota.Name = "dgv_Mascota";
            this.dgv_Mascota.ReadOnly = true;
            this.dgv_Mascota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Mascota.Size = new System.Drawing.Size(800, 240);
            this.dgv_Mascota.TabIndex = 0;
            this.dgv_Mascota.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Mascota_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Especie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Raza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sexo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Documento de Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Edad";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(53, 36);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 9;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(53, 78);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 10;
            // 
            // txt_Especie
            // 
            this.txt_Especie.Location = new System.Drawing.Point(53, 111);
            this.txt_Especie.Name = "txt_Especie";
            this.txt_Especie.Size = new System.Drawing.Size(100, 20);
            this.txt_Especie.TabIndex = 11;
            // 
            // txt_Raza
            // 
            this.txt_Raza.Location = new System.Drawing.Point(53, 137);
            this.txt_Raza.Name = "txt_Raza";
            this.txt_Raza.Size = new System.Drawing.Size(100, 20);
            this.txt_Raza.TabIndex = 12;
            // 
            // txt_Edad
            // 
            this.txt_Edad.Location = new System.Drawing.Point(135, 59);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(42, 20);
            this.txt_Edad.TabIndex = 14;
            // 
            // txt_Cliente_Documento
            // 
            this.txt_Cliente_Documento.Location = new System.Drawing.Point(135, 28);
            this.txt_Cliente_Documento.Name = "txt_Cliente_Documento";
            this.txt_Cliente_Documento.Size = new System.Drawing.Size(100, 20);
            this.txt_Cliente_Documento.TabIndex = 16;
            // 
            // btn_Eliminar_Mascota
            // 
            this.btn_Eliminar_Mascota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Eliminar_Mascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar_Mascota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Eliminar_Mascota.Location = new System.Drawing.Point(685, 291);
            this.btn_Eliminar_Mascota.Name = "btn_Eliminar_Mascota";
            this.btn_Eliminar_Mascota.Size = new System.Drawing.Size(127, 30);
            this.btn_Eliminar_Mascota.TabIndex = 17;
            this.btn_Eliminar_Mascota.Text = "Eliminar Mascota";
            this.btn_Eliminar_Mascota.UseVisualStyleBackColor = false;
            this.btn_Eliminar_Mascota.Click += new System.EventHandler(this.btn_Eliminar_Mascota_Click);
            // 
            // cbx_Sexo
            // 
            this.cbx_Sexo.FormattingEnabled = true;
            this.cbx_Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otros..."});
            this.cbx_Sexo.Location = new System.Drawing.Point(53, 167);
            this.cbx_Sexo.Name = "cbx_Sexo";
            this.cbx_Sexo.Size = new System.Drawing.Size(121, 21);
            this.cbx_Sexo.TabIndex = 18;
            // 
            // btn_Actualizar_Mascota
            // 
            this.btn_Actualizar_Mascota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Actualizar_Mascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizar_Mascota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Actualizar_Mascota.Location = new System.Drawing.Point(685, 242);
            this.btn_Actualizar_Mascota.Name = "btn_Actualizar_Mascota";
            this.btn_Actualizar_Mascota.Size = new System.Drawing.Size(127, 43);
            this.btn_Actualizar_Mascota.TabIndex = 19;
            this.btn_Actualizar_Mascota.Text = "Actualizar Mascota";
            this.btn_Actualizar_Mascota.UseVisualStyleBackColor = false;
            this.btn_Actualizar_Mascota.Click += new System.EventHandler(this.btn_Actualizar_Mascota_Click);
            // 
            // cbx_Edad2
            // 
            this.cbx_Edad2.FormattingEnabled = true;
            this.cbx_Edad2.Items.AddRange(new object[] {
            "Años",
            "Meses",
            "Dias"});
            this.cbx_Edad2.Location = new System.Drawing.Point(183, 58);
            this.cbx_Edad2.Name = "cbx_Edad2";
            this.cbx_Edad2.Size = new System.Drawing.Size(52, 21);
            this.cbx_Edad2.TabIndex = 21;
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackColor = System.Drawing.Color.Moccasin;
            this.btn_Regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.ForeColor = System.Drawing.Color.Olive;
            this.btn_Regresar.Location = new System.Drawing.Point(12, 12);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(75, 23);
            this.btn_Regresar.TabIndex = 22;
            this.btn_Regresar.Text = "Salir";
            this.btn_Regresar.UseVisualStyleBackColor = false;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(832, 589);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbx_Sexo);
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Raza);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Especie);
            this.groupBox1.Location = new System.Drawing.Point(123, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 239);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MintCream;
            this.groupBox2.Controls.Add(this.txt_Cliente_Documento);
            this.groupBox2.Controls.Add(this.cbx_Edad2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_Edad);
            this.groupBox2.Location = new System.Drawing.Point(394, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 127);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // Consultar_Mascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 586);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.btn_Actualizar_Mascota);
            this.Controls.Add(this.btn_Eliminar_Mascota);
            this.Controls.Add(this.dgv_Mascota);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Consultar_Mascota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar_Mascota";
            this.Load += new System.EventHandler(this.Consultar_Mascota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Mascota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Especie;
        private System.Windows.Forms.TextBox txt_Raza;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.TextBox txt_Cliente_Documento;
        private System.Windows.Forms.Button btn_Eliminar_Mascota;
        private System.Windows.Forms.ComboBox cbx_Sexo;
        private System.Windows.Forms.Button btn_Actualizar_Mascota;
        private System.Windows.Forms.ComboBox cbx_Edad2;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}