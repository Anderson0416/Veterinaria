namespace Precentacion
{
    partial class Consultorio
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
            this.txt_Nombre_Mascota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Id_Mascota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtb_Motivo_Consulta = new System.Windows.Forms.RichTextBox();
            this.rtb_Sintomas_Mascota = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_Vacunas_Previas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_Vacunas_Desparasitacion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_Tipo_Vivienda = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rtb_Dieta_Alimentacion = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_Actividad_Fisica = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_Estado_Reproductivo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rtb_Observaciones_Adicionales = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Mascota";
            // 
            // txt_Nombre_Mascota
            // 
            this.txt_Nombre_Mascota.Location = new System.Drawing.Point(133, 84);
            this.txt_Nombre_Mascota.Name = "txt_Nombre_Mascota";
            this.txt_Nombre_Mascota.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre_Mascota.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(134, 122);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(100, 20);
            this.txt_Descripcion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "id mascota";
            // 
            // txt_Id_Mascota
            // 
            this.txt_Id_Mascota.Location = new System.Drawing.Point(134, 48);
            this.txt_Id_Mascota.Name = "txt_Id_Mascota";
            this.txt_Id_Mascota.Size = new System.Drawing.Size(100, 20);
            this.txt_Id_Mascota.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Motivo De La consulta";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sintomas Que Presenta La Mascota";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // rtb_Motivo_Consulta
            // 
            this.rtb_Motivo_Consulta.Location = new System.Drawing.Point(42, 200);
            this.rtb_Motivo_Consulta.Name = "rtb_Motivo_Consulta";
            this.rtb_Motivo_Consulta.Size = new System.Drawing.Size(359, 96);
            this.rtb_Motivo_Consulta.TabIndex = 9;
            this.rtb_Motivo_Consulta.Text = "";
            // 
            // rtb_Sintomas_Mascota
            // 
            this.rtb_Sintomas_Mascota.Location = new System.Drawing.Point(42, 363);
            this.rtb_Sintomas_Mascota.Name = "rtb_Sintomas_Mascota";
            this.rtb_Sintomas_Mascota.Size = new System.Drawing.Size(359, 96);
            this.rtb_Sintomas_Mascota.TabIndex = 10;
            this.rtb_Sintomas_Mascota.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vacunas Previas ";
            // 
            // cmb_Vacunas_Previas
            // 
            this.cmb_Vacunas_Previas.FormattingEnabled = true;
            this.cmb_Vacunas_Previas.Items.AddRange(new object[] {
            "*NO HAY*",
            "Distemper",
            "Parvovirus",
            "Adenovirus tipo 1",
            "Vanguard® -Plus 5",
            "Nobivac® - Canine Flu H3",
            "Vanguard® - CIV H3N2/H3N8"});
            this.cmb_Vacunas_Previas.Location = new System.Drawing.Point(510, 64);
            this.cmb_Vacunas_Previas.Name = "cmb_Vacunas_Previas";
            this.cmb_Vacunas_Previas.Size = new System.Drawing.Size(151, 21);
            this.cmb_Vacunas_Previas.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(507, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Vacunas Previas De Desparasitacion  ( interna y externa )";
            // 
            // cmb_Vacunas_Desparasitacion
            // 
            this.cmb_Vacunas_Desparasitacion.FormattingEnabled = true;
            this.cmb_Vacunas_Desparasitacion.Items.AddRange(new object[] {
            "*NO HAY*",
            "Nobivac - DHPPi/L ",
            "Eurican -DAPPi-L",
            "Bronchicine - CAe",
            "Nobivac Tricat Trio ",
            "Purevax - RCP",
            "Filavac - VHD K + V",
            "Equivac - T"});
            this.cmb_Vacunas_Desparasitacion.Location = new System.Drawing.Point(510, 200);
            this.cmb_Vacunas_Desparasitacion.Name = "cmb_Vacunas_Desparasitacion";
            this.cmb_Vacunas_Desparasitacion.Size = new System.Drawing.Size(156, 21);
            this.cmb_Vacunas_Desparasitacion.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(680, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tipo De Vivienda";
            // 
            // cmb_Tipo_Vivienda
            // 
            this.cmb_Tipo_Vivienda.FormattingEnabled = true;
            this.cmb_Tipo_Vivienda.Items.AddRange(new object[] {
            "Casa",
            "Departamento",
            "Callejero",
            "Finca"});
            this.cmb_Tipo_Vivienda.Location = new System.Drawing.Point(683, 506);
            this.cmb_Tipo_Vivienda.Name = "cmb_Tipo_Vivienda";
            this.cmb_Tipo_Vivienda.Size = new System.Drawing.Size(156, 21);
            this.cmb_Tipo_Vivienda.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 490);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Dieta Y Alimentacion";
            // 
            // rtb_Dieta_Alimentacion
            // 
            this.rtb_Dieta_Alimentacion.Location = new System.Drawing.Point(42, 506);
            this.rtb_Dieta_Alimentacion.Name = "rtb_Dieta_Alimentacion";
            this.rtb_Dieta_Alimentacion.Size = new System.Drawing.Size(359, 96);
            this.rtb_Dieta_Alimentacion.TabIndex = 18;
            this.rtb_Dieta_Alimentacion.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(680, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Actividad Fisica";
            // 
            // cmb_Actividad_Fisica
            // 
            this.cmb_Actividad_Fisica.FormattingEnabled = true;
            this.cmb_Actividad_Fisica.Items.AddRange(new object[] {
            "Físicamente activo",
            "Físicamente inactivo ",
            "Sedentario"});
            this.cmb_Actividad_Fisica.Location = new System.Drawing.Point(683, 64);
            this.cmb_Actividad_Fisica.Name = "cmb_Actividad_Fisica";
            this.cmb_Actividad_Fisica.Size = new System.Drawing.Size(156, 21);
            this.cmb_Actividad_Fisica.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(507, 490);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Estado Reproductivo";
            // 
            // cmb_Estado_Reproductivo
            // 
            this.cmb_Estado_Reproductivo.FormattingEnabled = true;
            this.cmb_Estado_Reproductivo.Items.AddRange(new object[] {
            "Intacto",
            "Esterilizado",
            "Castrado "});
            this.cmb_Estado_Reproductivo.Location = new System.Drawing.Point(505, 506);
            this.cmb_Estado_Reproductivo.Name = "cmb_Estado_Reproductivo";
            this.cmb_Estado_Reproductivo.Size = new System.Drawing.Size(156, 21);
            this.cmb_Estado_Reproductivo.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(448, 347);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Observaciones Adicionales ";
            // 
            // rtb_Observaciones_Adicionales
            // 
            this.rtb_Observaciones_Adicionales.Location = new System.Drawing.Point(451, 363);
            this.rtb_Observaciones_Adicionales.Name = "rtb_Observaciones_Adicionales";
            this.rtb_Observaciones_Adicionales.Size = new System.Drawing.Size(359, 96);
            this.rtb_Observaciones_Adicionales.TabIndex = 24;
            this.rtb_Observaciones_Adicionales.Text = "";
            // 
            // Consultorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 629);
            this.Controls.Add(this.rtb_Observaciones_Adicionales);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmb_Estado_Reproductivo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmb_Actividad_Fisica);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rtb_Dieta_Alimentacion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmb_Tipo_Vivienda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_Vacunas_Desparasitacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_Vacunas_Previas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtb_Sintomas_Mascota);
            this.Controls.Add(this.rtb_Motivo_Consulta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Id_Mascota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Nombre_Mascota);
            this.Controls.Add(this.label1);
            this.Name = "Consultorio";
            this.Text = "Consultorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nombre_Mascota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Id_Mascota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtb_Motivo_Consulta;
        private System.Windows.Forms.RichTextBox rtb_Sintomas_Mascota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_Vacunas_Previas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_Vacunas_Desparasitacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_Tipo_Vivienda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rtb_Dieta_Alimentacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_Actividad_Fisica;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_Estado_Reproductivo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox rtb_Observaciones_Adicionales;
    }
}