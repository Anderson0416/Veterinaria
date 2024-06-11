namespace Precentacion
{
    partial class Producto_Mascota
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
            this.btn_Registrar_Producto = new System.Windows.Forms.Button();
            this.btn_Consultar_Producto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Registrar_Producto
            // 
            this.btn_Registrar_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrar_Producto.Location = new System.Drawing.Point(119, 42);
            this.btn_Registrar_Producto.Name = "btn_Registrar_Producto";
            this.btn_Registrar_Producto.Size = new System.Drawing.Size(128, 23);
            this.btn_Registrar_Producto.TabIndex = 0;
            this.btn_Registrar_Producto.Text = "Registrar Producto";
            this.btn_Registrar_Producto.UseVisualStyleBackColor = true;
            this.btn_Registrar_Producto.Click += new System.EventHandler(this.btn_Registrar_Producto_Click);
            // 
            // btn_Consultar_Producto
            // 
            this.btn_Consultar_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Consultar_Producto.Location = new System.Drawing.Point(114, 93);
            this.btn_Consultar_Producto.Name = "btn_Consultar_Producto";
            this.btn_Consultar_Producto.Size = new System.Drawing.Size(133, 23);
            this.btn_Consultar_Producto.TabIndex = 1;
            this.btn_Consultar_Producto.Text = "Consultar Producto";
            this.btn_Consultar_Producto.UseVisualStyleBackColor = true;
            this.btn_Consultar_Producto.Click += new System.EventHandler(this.btn_Consultar_Producto_Click);
            // 
            // Producto_Mascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 169);
            this.Controls.Add(this.btn_Consultar_Producto);
            this.Controls.Add(this.btn_Registrar_Producto);
            this.Name = "Producto_Mascota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto_Mascota";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Registrar_Producto;
        private System.Windows.Forms.Button btn_Consultar_Producto;
    }
}