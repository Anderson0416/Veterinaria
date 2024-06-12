﻿namespace Precentacion
{
    partial class Registro_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Cliente));
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.cmb_Sexo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Tipo_Documento = new System.Windows.Forms.ComboBox();
            this.txt_Numero_Documento = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Registrar_Cliente = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Registro_Cliente = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Location = new System.Drawing.Point(52, 150);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(200, 20);
            this.dtp_Fecha.TabIndex = 33;
            // 
            // cmb_Sexo
            // 
            this.cmb_Sexo.FormattingEnabled = true;
            this.cmb_Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otros"});
            this.cmb_Sexo.Location = new System.Drawing.Point(378, 84);
            this.cmb_Sexo.Name = "cmb_Sexo";
            this.cmb_Sexo.Size = new System.Drawing.Size(73, 21);
            this.cmb_Sexo.TabIndex = 32;
            this.cmb_Sexo.SelectedIndexChanged += new System.EventHandler(this.cmb_Sexo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MintCream;
            this.label6.Location = new System.Drawing.Point(341, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MintCream;
            this.label5.Location = new System.Drawing.Point(49, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fecha de nacimieto";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmb_Tipo_Documento
            // 
            this.cmb_Tipo_Documento.FormattingEnabled = true;
            this.cmb_Tipo_Documento.Items.AddRange(new object[] {
            "Tarjeta de identidad",
            "Cédula de Ciudadanía"});
            this.cmb_Tipo_Documento.Location = new System.Drawing.Point(154, 199);
            this.cmb_Tipo_Documento.Name = "cmb_Tipo_Documento";
            this.cmb_Tipo_Documento.Size = new System.Drawing.Size(131, 21);
            this.cmb_Tipo_Documento.TabIndex = 29;
            this.cmb_Tipo_Documento.SelectedIndexChanged += new System.EventHandler(this.cmb_Tipo_Documento_SelectedIndexChanged);
            // 
            // txt_Numero_Documento
            // 
            this.txt_Numero_Documento.Location = new System.Drawing.Point(170, 224);
            this.txt_Numero_Documento.Name = "txt_Numero_Documento";
            this.txt_Numero_Documento.Size = new System.Drawing.Size(115, 20);
            this.txt_Numero_Documento.TabIndex = 28;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(99, 89);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(186, 20);
            this.txt_Apellido.TabIndex = 27;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(99, 62);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(186, 20);
            this.txt_Nombre.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MintCream;
            this.label4.Location = new System.Drawing.Point(49, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Numero de documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(49, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tipo de documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(49, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(49, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre";
            // 
            // btn_Registrar_Cliente
            // 
            this.btn_Registrar_Cliente.Location = new System.Drawing.Point(372, 194);
            this.btn_Registrar_Cliente.Name = "btn_Registrar_Cliente";
            this.btn_Registrar_Cliente.Size = new System.Drawing.Size(110, 46);
            this.btn_Registrar_Cliente.TabIndex = 34;
            this.btn_Registrar_Cliente.Text = "Registrar";
            this.btn_Registrar_Cliente.UseVisualStyleBackColor = true;
            this.btn_Registrar_Cliente.Click += new System.EventHandler(this.btn_Registro_Cliente_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MintCream;
            this.label7.Location = new System.Drawing.Point(323, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Telefono";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(378, 62);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(122, 20);
            this.txt_Telefono.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_Registro_Cliente
            // 
            this.btn_Registro_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Registro_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registro_Cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Registro_Cliente.Location = new System.Drawing.Point(388, 266);
            this.btn_Registro_Cliente.Name = "btn_Registro_Cliente";
            this.btn_Registro_Cliente.Size = new System.Drawing.Size(125, 22);
            this.btn_Registro_Cliente.TabIndex = 38;
            this.btn_Registro_Cliente.Text = "Registrar Cliente";
            this.btn_Registro_Cliente.UseVisualStyleBackColor = false;
            this.btn_Registro_Cliente.Click += new System.EventHandler(this.btn_Registro_Cliente_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Moccasin;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.Color.Olive;
            this.btn_Salir.Location = new System.Drawing.Point(35, 12);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 39;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Location = new System.Drawing.Point(36, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 219);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // Registro_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 294);
            this.Controls.Add(this.btn_Registro_Cliente);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_Fecha);
            this.Controls.Add(this.cmb_Sexo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_Tipo_Documento);
            this.Controls.Add(this.txt_Numero_Documento);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Registro_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro_Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.ComboBox cmb_Sexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Tipo_Documento;
        private System.Windows.Forms.TextBox txt_Numero_Documento;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Registrar_Cliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Registro_Cliente;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}