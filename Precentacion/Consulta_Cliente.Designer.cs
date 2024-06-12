namespace Precentacion
{
    partial class Consulta_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Cliente));
            this.dgv_Cliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Documento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_Fecha_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Eliminar_Cliente = new System.Windows.Forms.Button();
            this.btn_Actualizar_Cliente = new System.Windows.Forms.Button();
            this.cbx_Sexo = new System.Windows.Forms.ComboBox();
            this.cbx_Tipo_Documento = new System.Windows.Forms.ComboBox();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Cliente
            // 
            this.dgv_Cliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cliente.Location = new System.Drawing.Point(12, 338);
            this.dgv_Cliente.Name = "dgv_Cliente";
            this.dgv_Cliente.ReadOnly = true;
            this.dgv_Cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Cliente.Size = new System.Drawing.Size(838, 226);
            this.dgv_Cliente.TabIndex = 0;
            this.dgv_Cliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Cliente_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(85, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(135, 69);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 2;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(135, 95);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_Apellido.TabIndex = 3;
            // 
            // txt_Documento
            // 
            this.txt_Documento.Location = new System.Drawing.Point(135, 124);
            this.txt_Documento.Name = "txt_Documento";
            this.txt_Documento.ReadOnly = true;
            this.txt_Documento.Size = new System.Drawing.Size(100, 20);
            this.txt_Documento.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(85, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(67, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MintCream;
            this.label4.Location = new System.Drawing.Point(43, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo de documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MintCream;
            this.label5.Location = new System.Drawing.Point(111, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sexo";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(483, 65);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_Telefono.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MintCream;
            this.label6.Location = new System.Drawing.Point(428, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefono";
            // 
            // dtp_Fecha_Nacimiento
            // 
            this.dtp_Fecha_Nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Fecha_Nacimiento.Location = new System.Drawing.Point(483, 121);
            this.dtp_Fecha_Nacimiento.Name = "dtp_Fecha_Nacimiento";
            this.dtp_Fecha_Nacimiento.Size = new System.Drawing.Size(212, 20);
            this.dtp_Fecha_Nacimiento.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MintCream;
            this.label7.Location = new System.Drawing.Point(369, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha de Nacimiento";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(483, 91);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MintCream;
            this.label8.Location = new System.Drawing.Point(459, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "ID";
            // 
            // btn_Eliminar_Cliente
            // 
            this.btn_Eliminar_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Eliminar_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar_Cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Eliminar_Cliente.Location = new System.Drawing.Point(718, 289);
            this.btn_Eliminar_Cliente.Name = "btn_Eliminar_Cliente";
            this.btn_Eliminar_Cliente.Size = new System.Drawing.Size(132, 43);
            this.btn_Eliminar_Cliente.TabIndex = 17;
            this.btn_Eliminar_Cliente.Text = "Eliminar Veterinario";
            this.btn_Eliminar_Cliente.UseVisualStyleBackColor = false;
            this.btn_Eliminar_Cliente.Click += new System.EventHandler(this.btn_Eliminar_Cliente_Click);
            // 
            // btn_Actualizar_Cliente
            // 
            this.btn_Actualizar_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Actualizar_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizar_Cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Actualizar_Cliente.Location = new System.Drawing.Point(718, 242);
            this.btn_Actualizar_Cliente.Name = "btn_Actualizar_Cliente";
            this.btn_Actualizar_Cliente.Size = new System.Drawing.Size(132, 41);
            this.btn_Actualizar_Cliente.TabIndex = 18;
            this.btn_Actualizar_Cliente.Text = "Actualizar Cliente";
            this.btn_Actualizar_Cliente.UseVisualStyleBackColor = false;
            this.btn_Actualizar_Cliente.Click += new System.EventHandler(this.btn_Actualizar_Cliente_Click);
            // 
            // cbx_Sexo
            // 
            this.cbx_Sexo.FormattingEnabled = true;
            this.cbx_Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otros..."});
            this.cbx_Sexo.Location = new System.Drawing.Point(148, 231);
            this.cbx_Sexo.Name = "cbx_Sexo";
            this.cbx_Sexo.Size = new System.Drawing.Size(121, 21);
            this.cbx_Sexo.TabIndex = 19;
            // 
            // cbx_Tipo_Documento
            // 
            this.cbx_Tipo_Documento.FormattingEnabled = true;
            this.cbx_Tipo_Documento.Items.AddRange(new object[] {
            "Tarjeta de Identidad",
            "Cedula de Ciudadania"});
            this.cbx_Tipo_Documento.Location = new System.Drawing.Point(148, 204);
            this.cbx_Tipo_Documento.Name = "cbx_Tipo_Documento";
            this.cbx_Tipo_Documento.Size = new System.Drawing.Size(121, 21);
            this.cbx_Tipo_Documento.TabIndex = 20;
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackColor = System.Drawing.Color.Moccasin;
            this.btn_Regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.ForeColor = System.Drawing.Color.Olive;
            this.btn_Regresar.Location = new System.Drawing.Point(12, 12);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(75, 23);
            this.btn_Regresar.TabIndex = 21;
            this.btn_Regresar.Text = "Salir";
            this.btn_Regresar.UseVisualStyleBackColor = false;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(864, 597);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Location = new System.Drawing.Point(30, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 224);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MintCream;
            this.groupBox2.Location = new System.Drawing.Point(348, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 108);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // Consulta_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 595);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.cbx_Tipo_Documento);
            this.Controls.Add(this.cbx_Sexo);
            this.Controls.Add(this.btn_Actualizar_Cliente);
            this.Controls.Add(this.btn_Eliminar_Cliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_Fecha_Nacimiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Documento);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Cliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Consulta_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta_Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Documento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_Fecha_Nacimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Eliminar_Cliente;
        private System.Windows.Forms.Button btn_Actualizar_Cliente;
        private System.Windows.Forms.ComboBox cbx_Sexo;
        private System.Windows.Forms.ComboBox cbx_Tipo_Documento;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}