namespace Precentacion
{
    partial class Form2
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
            this.btn_Form = new System.Windows.Forms.Button();
            this.txtFechaConsulta = new System.Windows.Forms.TextBox();
            this.dgv_Form = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Form)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Form
            // 
            this.btn_Form.Location = new System.Drawing.Point(66, 53);
            this.btn_Form.Name = "btn_Form";
            this.btn_Form.Size = new System.Drawing.Size(75, 23);
            this.btn_Form.TabIndex = 0;
            this.btn_Form.Text = "boton";
            this.btn_Form.UseVisualStyleBackColor = true;
            this.btn_Form.Click += new System.EventHandler(this.btn_Form_Click);
            // 
            // txtFechaConsulta
            // 
            this.txtFechaConsulta.Location = new System.Drawing.Point(157, 53);
            this.txtFechaConsulta.Name = "txtFechaConsulta";
            this.txtFechaConsulta.Size = new System.Drawing.Size(100, 20);
            this.txtFechaConsulta.TabIndex = 1;
            // 
            // dgv_Form
            // 
            this.dgv_Form.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Form.Location = new System.Drawing.Point(51, 116);
            this.dgv_Form.Name = "dgv_Form";
            this.dgv_Form.Size = new System.Drawing.Size(464, 150);
            this.dgv_Form.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Form);
            this.Controls.Add(this.txtFechaConsulta);
            this.Controls.Add(this.btn_Form);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Form)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Form;
        private System.Windows.Forms.TextBox txtFechaConsulta;
        private System.Windows.Forms.DataGridView dgv_Form;
    }
}