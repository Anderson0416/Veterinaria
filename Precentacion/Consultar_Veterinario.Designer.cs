namespace Precentacion
{
    partial class Consultar_Veterinario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar_Veterinario));
            this.dgv_Veterinario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Documento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.dtp_Fecha_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.dtp_Fecha_Contrato = new System.Windows.Forms.DateTimePicker();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Eliminar_Veterinario = new System.Windows.Forms.Button();
            this.cbx_Sexo = new System.Windows.Forms.ComboBox();
            this.btn_Actualizar_Veterinario = new System.Windows.Forms.Button();
            this.cbx_Tipo_Documento = new System.Windows.Forms.ComboBox();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Veterinario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Veterinario
            // 
            this.dgv_Veterinario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_Veterinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Veterinario.Location = new System.Drawing.Point(12, 327);
            this.dgv_Veterinario.Name = "dgv_Veterinario";
            this.dgv_Veterinario.ReadOnly = true;
            this.dgv_Veterinario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Veterinario.Size = new System.Drawing.Size(836, 231);
            this.dgv_Veterinario.TabIndex = 0;
            this.dgv_Veterinario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha Nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fecha Contraro";
            // 
            // txt_Documento
            // 
            this.txt_Documento.Location = new System.Drawing.Point(342, 62);
            this.txt_Documento.Name = "txt_Documento";
            this.txt_Documento.ReadOnly = true;
            this.txt_Documento.Size = new System.Drawing.Size(127, 20);
            this.txt_Documento.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(540, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(509, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Telefono";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(564, 59);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 17;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(564, 33);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_Telefono.TabIndex = 18;
            // 
            // dtp_Fecha_Nacimiento
            // 
            this.dtp_Fecha_Nacimiento.Location = new System.Drawing.Point(136, 126);
            this.dtp_Fecha_Nacimiento.Name = "dtp_Fecha_Nacimiento";
            this.dtp_Fecha_Nacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtp_Fecha_Nacimiento.TabIndex = 19;
            // 
            // dtp_Fecha_Contrato
            // 
            this.dtp_Fecha_Contrato.Location = new System.Drawing.Point(123, 152);
            this.dtp_Fecha_Contrato.Name = "dtp_Fecha_Contrato";
            this.dtp_Fecha_Contrato.Size = new System.Drawing.Size(213, 20);
            this.dtp_Fecha_Contrato.TabIndex = 20;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(87, 62);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_Apellido.TabIndex = 9;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(87, 36);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 8;
            // 
            // btn_Eliminar_Veterinario
            // 
            this.btn_Eliminar_Veterinario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Eliminar_Veterinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar_Veterinario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Eliminar_Veterinario.Location = new System.Drawing.Point(718, 266);
            this.btn_Eliminar_Veterinario.Name = "btn_Eliminar_Veterinario";
            this.btn_Eliminar_Veterinario.Size = new System.Drawing.Size(130, 38);
            this.btn_Eliminar_Veterinario.TabIndex = 21;
            this.btn_Eliminar_Veterinario.Text = "Eliminar Veterinario";
            this.btn_Eliminar_Veterinario.UseVisualStyleBackColor = false;
            this.btn_Eliminar_Veterinario.Click += new System.EventHandler(this.btn_Eliminar_Veterinario_Click);
            // 
            // cbx_Sexo
            // 
            this.cbx_Sexo.FormattingEnabled = true;
            this.cbx_Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otros..."});
            this.cbx_Sexo.Location = new System.Drawing.Point(564, 88);
            this.cbx_Sexo.Name = "cbx_Sexo";
            this.cbx_Sexo.Size = new System.Drawing.Size(100, 21);
            this.cbx_Sexo.TabIndex = 22;
            // 
            // btn_Actualizar_Veterinario
            // 
            this.btn_Actualizar_Veterinario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Actualizar_Veterinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizar_Veterinario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Actualizar_Veterinario.Location = new System.Drawing.Point(718, 222);
            this.btn_Actualizar_Veterinario.Name = "btn_Actualizar_Veterinario";
            this.btn_Actualizar_Veterinario.Size = new System.Drawing.Size(130, 38);
            this.btn_Actualizar_Veterinario.TabIndex = 23;
            this.btn_Actualizar_Veterinario.Text = "Actualizar Veterinario";
            this.btn_Actualizar_Veterinario.UseVisualStyleBackColor = false;
            this.btn_Actualizar_Veterinario.Click += new System.EventHandler(this.btn_Actualizar_Veterinario_Click);
            // 
            // cbx_Tipo_Documento
            // 
            this.cbx_Tipo_Documento.FormattingEnabled = true;
            this.cbx_Tipo_Documento.Items.AddRange(new object[] {
            "Tarjeta de Identidad",
            "Cedula de Ciudadania"});
            this.cbx_Tipo_Documento.Location = new System.Drawing.Point(342, 36);
            this.cbx_Tipo_Documento.Name = "cbx_Tipo_Documento";
            this.cbx_Tipo_Documento.Size = new System.Drawing.Size(121, 21);
            this.cbx_Tipo_Documento.TabIndex = 24;
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackColor = System.Drawing.Color.Moccasin;
            this.btn_Regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.ForeColor = System.Drawing.Color.Olive;
            this.btn_Regresar.Location = new System.Drawing.Point(12, 13);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(75, 23);
            this.btn_Regresar.TabIndex = 25;
            this.btn_Regresar.Text = "Salir";
            this.btn_Regresar.UseVisualStyleBackColor = false;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-25, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(910, 595);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Controls.Add(this.cbx_Tipo_Documento);
            this.groupBox1.Controls.Add(this.cbx_Sexo);
            this.groupBox1.Controls.Add(this.dtp_Fecha_Contrato);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_Fecha_Nacimiento);
            this.groupBox1.Controls.Add(this.txt_Apellido);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.txt_Telefono);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Documento);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 196);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // Consultar_Veterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 590);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.btn_Actualizar_Veterinario);
            this.Controls.Add(this.btn_Eliminar_Veterinario);
            this.Controls.Add(this.dgv_Veterinario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Consultar_Veterinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta_Veterinario";
            this.Load += new System.EventHandler(this.Consultar_Veterinario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Veterinario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Veterinario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Documento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.DateTimePicker dtp_Fecha_Nacimiento;
        private System.Windows.Forms.DateTimePicker dtp_Fecha_Contrato;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Button btn_Eliminar_Veterinario;
        private System.Windows.Forms.ComboBox cbx_Sexo;
        private System.Windows.Forms.Button btn_Actualizar_Veterinario;
        private System.Windows.Forms.ComboBox cbx_Tipo_Documento;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}