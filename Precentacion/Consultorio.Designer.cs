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
            this.lb_Nota = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Nota
            // 
            this.lb_Nota.AutoSize = true;
            this.lb_Nota.Location = new System.Drawing.Point(137, 122);
            this.lb_Nota.Name = "lb_Nota";
            this.lb_Nota.Size = new System.Drawing.Size(35, 13);
            this.lb_Nota.TabIndex = 0;
            this.lb_Nota.Text = "label1";
            // 
            // Consultorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Nota);
            this.Name = "Consultorio";
            this.Text = "Consultorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Nota;
    }
}