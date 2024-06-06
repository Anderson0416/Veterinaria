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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Mascota";
            // 
            // txt_Nombre_Mascota
            // 
            this.txt_Nombre_Mascota.Location = new System.Drawing.Point(143, 98);
            this.txt_Nombre_Mascota.Name = "txt_Nombre_Mascota";
            this.txt_Nombre_Mascota.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre_Mascota.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(373, 98);
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
            // Consultorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 629);
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
    }
}