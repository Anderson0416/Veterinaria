namespace Precentacion
{
    partial class Registrar_Producto
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.rtb_Descripcion = new System.Windows.Forms.RichTextBox();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Registrar_Producto
            // 
            this.btn_Registrar_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrar_Producto.Location = new System.Drawing.Point(448, 325);
            this.btn_Registrar_Producto.Name = "btn_Registrar_Producto";
            this.btn_Registrar_Producto.Size = new System.Drawing.Size(118, 37);
            this.btn_Registrar_Producto.TabIndex = 39;
            this.btn_Registrar_Producto.Text = "Registrar Producto";
            this.btn_Registrar_Producto.UseVisualStyleBackColor = true;
            this.btn_Registrar_Producto.Click += new System.EventHandler(this.Registrar_Producto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Precio";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(110, 38);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 44;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(110, 77);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(100, 20);
            this.txt_Precio.TabIndex = 45;
            // 
            // rtb_Descripcion
            // 
            this.rtb_Descripcion.Location = new System.Drawing.Point(110, 186);
            this.rtb_Descripcion.Name = "rtb_Descripcion";
            this.rtb_Descripcion.Size = new System.Drawing.Size(245, 124);
            this.rtb_Descripcion.TabIndex = 47;
            this.rtb_Descripcion.Text = "";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rjButton1.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 3;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rjButton1.Location = new System.Drawing.Point(304, 108);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 48;
            this.rjButton1.Text = "Agregar Cita";
            this.rjButton1.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Cantidad";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(110, 134);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_Cantidad.TabIndex = 50;
            // 
            // Registrar_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 374);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.rtb_Descripcion);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Registrar_Producto);
            this.Name = "Registrar_Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar_Producto";
            this.Load += new System.EventHandler(this.Registrar_Producto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Registrar_Producto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.RichTextBox rtb_Descripcion;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Cantidad;
    }
}