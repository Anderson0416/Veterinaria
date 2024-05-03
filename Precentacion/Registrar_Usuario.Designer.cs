namespace Precentacion
{
    partial class Registrar_Usuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Numero_Documento = new System.Windows.Forms.TextBox();
            this.cmb_Tipo_Documento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_Sexo = new System.Windows.Forms.ComboBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Confirmar_Contraseña = new System.Windows.Forms.TextBox();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero de documento";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(117, 96);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(176, 20);
            this.txt_Nombre.TabIndex = 4;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(117, 147);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(176, 20);
            this.txt_Apellido.TabIndex = 5;
            // 
            // txt_Numero_Documento
            // 
            this.txt_Numero_Documento.Location = new System.Drawing.Point(465, 147);
            this.txt_Numero_Documento.Name = "txt_Numero_Documento";
            this.txt_Numero_Documento.Size = new System.Drawing.Size(121, 20);
            this.txt_Numero_Documento.TabIndex = 6;
            // 
            // cmb_Tipo_Documento
            // 
            this.cmb_Tipo_Documento.FormattingEnabled = true;
            this.cmb_Tipo_Documento.Items.AddRange(new object[] {
            "Tarjeta de identidad",
            "Cédula de Ciudadanía"});
            this.cmb_Tipo_Documento.Location = new System.Drawing.Point(465, 96);
            this.cmb_Tipo_Documento.Name = "cmb_Tipo_Documento";
            this.cmb_Tipo_Documento.Size = new System.Drawing.Size(121, 21);
            this.cmb_Tipo_Documento.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de nacimieto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sexo";
            // 
            // cmb_Sexo
            // 
            this.cmb_Sexo.FormattingEnabled = true;
            this.cmb_Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otros"});
            this.cmb_Sexo.Location = new System.Drawing.Point(117, 307);
            this.cmb_Sexo.Name = "cmb_Sexo";
            this.cmb_Sexo.Size = new System.Drawing.Size(85, 21);
            this.cmb_Sexo.TabIndex = 14;
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(202, 387);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(145, 20);
            this.txt_Contraseña.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Contraseña";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Confimar contraseña";
            // 
            // txt_Confirmar_Contraseña
            // 
            this.txt_Confirmar_Contraseña.Location = new System.Drawing.Point(202, 438);
            this.txt_Confirmar_Contraseña.Name = "txt_Confirmar_Contraseña";
            this.txt_Confirmar_Contraseña.Size = new System.Drawing.Size(145, 20);
            this.txt_Confirmar_Contraseña.TabIndex = 18;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(202, 534);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(151, 40);
            this.btn_Registrar.TabIndex = 19;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(25, 13);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 20;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Location = new System.Drawing.Point(69, 242);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(200, 20);
            this.dtp_Fecha.TabIndex = 21;
            // 
            // Registrar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 655);
            this.Controls.Add(this.dtp_Fecha);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.txt_Confirmar_Contraseña);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Contraseña);
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
            this.Name = "Registrar_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Numero_Documento;
        private System.Windows.Forms.ComboBox cmb_Tipo_Documento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_Sexo;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Confirmar_Contraseña;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
    }
}