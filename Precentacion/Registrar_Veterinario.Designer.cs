namespace Precentacion
{
    partial class Registrar_Veterinario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar_Veterinario));
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.dtp_Fecha_Nacimiento = new System.Windows.Forms.DateTimePicker();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_Fecha_Contrato = new System.Windows.Forms.DateTimePicker();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(410, 73);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(122, 20);
            this.txt_Telefono.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MintCream;
            this.label7.Location = new System.Drawing.Point(355, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Telefono";
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Registrar.Location = new System.Drawing.Point(480, 253);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(72, 26);
            this.btn_Registrar.TabIndex = 50;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = false;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // dtp_Fecha_Nacimiento
            // 
            this.dtp_Fecha_Nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Fecha_Nacimiento.Location = new System.Drawing.Point(56, 169);
            this.dtp_Fecha_Nacimiento.Name = "dtp_Fecha_Nacimiento";
            this.dtp_Fecha_Nacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtp_Fecha_Nacimiento.TabIndex = 49;
            // 
            // cmb_Sexo
            // 
            this.cmb_Sexo.FormattingEnabled = true;
            this.cmb_Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otros"});
            this.cmb_Sexo.Location = new System.Drawing.Point(410, 99);
            this.cmb_Sexo.Name = "cmb_Sexo";
            this.cmb_Sexo.Size = new System.Drawing.Size(73, 21);
            this.cmb_Sexo.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MintCream;
            this.label6.Location = new System.Drawing.Point(373, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MintCream;
            this.label5.Location = new System.Drawing.Point(53, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Fecha de nacimieto";
            // 
            // cmb_Tipo_Documento
            // 
            this.cmb_Tipo_Documento.FormattingEnabled = true;
            this.cmb_Tipo_Documento.Items.AddRange(new object[] {
            "Cédula de Ciudadanía"});
            this.cmb_Tipo_Documento.Location = new System.Drawing.Point(373, 103);
            this.cmb_Tipo_Documento.Name = "cmb_Tipo_Documento";
            this.cmb_Tipo_Documento.Size = new System.Drawing.Size(131, 21);
            this.cmb_Tipo_Documento.TabIndex = 45;
            this.cmb_Tipo_Documento.SelectedIndexChanged += new System.EventHandler(this.cmb_Tipo_Documento_SelectedIndexChanged);
            // 
            // txt_Numero_Documento
            // 
            this.txt_Numero_Documento.Location = new System.Drawing.Point(373, 130);
            this.txt_Numero_Documento.Name = "txt_Numero_Documento";
            this.txt_Numero_Documento.Size = new System.Drawing.Size(131, 20);
            this.txt_Numero_Documento.TabIndex = 44;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(103, 99);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(153, 20);
            this.txt_Apellido.TabIndex = 43;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(103, 73);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(153, 20);
            this.txt_Nombre.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Numero de documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tipo de documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(53, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(53, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MintCream;
            this.label8.Location = new System.Drawing.Point(53, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Fecha de contrato";
            // 
            // dtp_Fecha_Contrato
            // 
            this.dtp_Fecha_Contrato.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Fecha_Contrato.Location = new System.Drawing.Point(56, 223);
            this.dtp_Fecha_Contrato.Name = "dtp_Fecha_Contrato";
            this.dtp_Fecha_Contrato.Size = new System.Drawing.Size(200, 20);
            this.dtp_Fecha_Contrato.TabIndex = 55;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Moccasin;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.Color.Olive;
            this.btn_Salir.Location = new System.Drawing.Point(37, 13);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 56;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.txt_Numero_Documento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_Tipo_Documento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(37, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 205);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            // 
            // Registrar_Veterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 303);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.dtp_Fecha_Contrato);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_Fecha_Nacimiento);
            this.Controls.Add(this.cmb_Sexo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Registrar_Veterinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar_Veterinario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.DateTimePicker dtp_Fecha_Nacimiento;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_Fecha_Contrato;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}