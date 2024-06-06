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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Veterinario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Veterinario
            // 
            this.dgv_Veterinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Veterinario.Location = new System.Drawing.Point(12, 179);
            this.dgv_Veterinario.Name = "dgv_Veterinario";
            this.dgv_Veterinario.ReadOnly = true;
            this.dgv_Veterinario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Veterinario.Size = new System.Drawing.Size(874, 203);
            this.dgv_Veterinario.TabIndex = 0;
            this.dgv_Veterinario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo_Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha_Nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fecha_Contraro";
            // 
            // txt_Documento
            // 
            this.txt_Documento.Location = new System.Drawing.Point(322, 56);
            this.txt_Documento.Name = "txt_Documento";
            this.txt_Documento.ReadOnly = true;
            this.txt_Documento.Size = new System.Drawing.Size(127, 20);
            this.txt_Documento.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(520, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(501, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Telefono";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(556, 52);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 17;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(556, 27);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_Telefono.TabIndex = 18;
            // 
            // dtp_Fecha_Nacimiento
            // 
            this.dtp_Fecha_Nacimiento.Location = new System.Drawing.Point(356, 106);
            this.dtp_Fecha_Nacimiento.Name = "dtp_Fecha_Nacimiento";
            this.dtp_Fecha_Nacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtp_Fecha_Nacimiento.TabIndex = 19;
            // 
            // dtp_Fecha_Contrato
            // 
            this.dtp_Fecha_Contrato.Location = new System.Drawing.Point(350, 132);
            this.dtp_Fecha_Contrato.Name = "dtp_Fecha_Contrato";
            this.dtp_Fecha_Contrato.Size = new System.Drawing.Size(200, 20);
            this.dtp_Fecha_Contrato.TabIndex = 20;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(81, 56);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_Apellido.TabIndex = 9;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(80, 30);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 8;
            // 
            // btn_Eliminar_Veterinario
            // 
            this.btn_Eliminar_Veterinario.Location = new System.Drawing.Point(732, 56);
            this.btn_Eliminar_Veterinario.Name = "btn_Eliminar_Veterinario";
            this.btn_Eliminar_Veterinario.Size = new System.Drawing.Size(120, 23);
            this.btn_Eliminar_Veterinario.TabIndex = 21;
            this.btn_Eliminar_Veterinario.Text = "Eliminar Veterinario";
            this.btn_Eliminar_Veterinario.UseVisualStyleBackColor = true;
            this.btn_Eliminar_Veterinario.Click += new System.EventHandler(this.btn_Eliminar_Veterinario_Click);
            // 
            // cbx_Sexo
            // 
            this.cbx_Sexo.FormattingEnabled = true;
            this.cbx_Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otros..."});
            this.cbx_Sexo.Location = new System.Drawing.Point(80, 128);
            this.cbx_Sexo.Name = "cbx_Sexo";
            this.cbx_Sexo.Size = new System.Drawing.Size(121, 21);
            this.cbx_Sexo.TabIndex = 22;
            // 
            // btn_Actualizar_Veterinario
            // 
            this.btn_Actualizar_Veterinario.Location = new System.Drawing.Point(732, 25);
            this.btn_Actualizar_Veterinario.Name = "btn_Actualizar_Veterinario";
            this.btn_Actualizar_Veterinario.Size = new System.Drawing.Size(120, 23);
            this.btn_Actualizar_Veterinario.TabIndex = 23;
            this.btn_Actualizar_Veterinario.Text = "Actualizar Veterinario";
            this.btn_Actualizar_Veterinario.UseVisualStyleBackColor = true;
            this.btn_Actualizar_Veterinario.Click += new System.EventHandler(this.btn_Actualizar_Veterinario_Click);
            // 
            // cbx_Tipo_Documento
            // 
            this.cbx_Tipo_Documento.FormattingEnabled = true;
            this.cbx_Tipo_Documento.Items.AddRange(new object[] {
            "Tarjeta de Identidad",
            "Cedula de Ciudadania"});
            this.cbx_Tipo_Documento.Location = new System.Drawing.Point(349, 29);
            this.cbx_Tipo_Documento.Name = "cbx_Tipo_Documento";
            this.cbx_Tipo_Documento.Size = new System.Drawing.Size(121, 21);
            this.cbx_Tipo_Documento.TabIndex = 24;
            // 
            // Consultar_Veterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 394);
            this.Controls.Add(this.cbx_Tipo_Documento);
            this.Controls.Add(this.btn_Actualizar_Veterinario);
            this.Controls.Add(this.cbx_Sexo);
            this.Controls.Add(this.btn_Eliminar_Veterinario);
            this.Controls.Add(this.dtp_Fecha_Contrato);
            this.Controls.Add(this.dtp_Fecha_Nacimiento);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Documento);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Veterinario);
            this.Name = "Consultar_Veterinario";
            this.Text = "Consulta_Veterinario";
            this.Load += new System.EventHandler(this.Consultar_Veterinario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Veterinario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}