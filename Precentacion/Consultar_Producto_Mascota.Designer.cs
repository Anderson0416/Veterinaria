namespace Precentacion
{
    partial class Consultar_Producto_Mascota
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
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.dgv_Producto_Mascota = new System.Windows.Forms.DataGridView();
            this.btn_Eliminar_Producto = new System.Windows.Forms.Button();
            this.btn_Actualizar_Producto = new System.Windows.Forms.Button();
            this.rtb_Descripcion = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Producto_Mascota)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(137, 68);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 4;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(137, 106);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 5;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(137, 151);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(100, 20);
            this.txt_Precio.TabIndex = 7;
            // 
            // dgv_Producto_Mascota
            // 
            this.dgv_Producto_Mascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Producto_Mascota.Location = new System.Drawing.Point(12, 282);
            this.dgv_Producto_Mascota.Name = "dgv_Producto_Mascota";
            this.dgv_Producto_Mascota.ReadOnly = true;
            this.dgv_Producto_Mascota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Producto_Mascota.Size = new System.Drawing.Size(630, 150);
            this.dgv_Producto_Mascota.TabIndex = 8;
            this.dgv_Producto_Mascota.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Producto_Mascota_CellClick);
            // 
            // btn_Eliminar_Producto
            // 
            this.btn_Eliminar_Producto.Location = new System.Drawing.Point(523, 253);
            this.btn_Eliminar_Producto.Name = "btn_Eliminar_Producto";
            this.btn_Eliminar_Producto.Size = new System.Drawing.Size(119, 23);
            this.btn_Eliminar_Producto.TabIndex = 9;
            this.btn_Eliminar_Producto.Text = "Eliminar Producto";
            this.btn_Eliminar_Producto.UseVisualStyleBackColor = true;
            this.btn_Eliminar_Producto.Click += new System.EventHandler(this.btn_Eliminar_Producto_Click_1);
            // 
            // btn_Actualizar_Producto
            // 
            this.btn_Actualizar_Producto.Location = new System.Drawing.Point(523, 211);
            this.btn_Actualizar_Producto.Name = "btn_Actualizar_Producto";
            this.btn_Actualizar_Producto.Size = new System.Drawing.Size(119, 23);
            this.btn_Actualizar_Producto.TabIndex = 10;
            this.btn_Actualizar_Producto.Text = "Actualizar  Producto";
            this.btn_Actualizar_Producto.UseVisualStyleBackColor = true;
            this.btn_Actualizar_Producto.Click += new System.EventHandler(this.btn_Actualizar_Producto_Click_1);
            // 
            // rtb_Descripcion
            // 
            this.rtb_Descripcion.Location = new System.Drawing.Point(383, 65);
            this.rtb_Descripcion.Name = "rtb_Descripcion";
            this.rtb_Descripcion.Size = new System.Drawing.Size(259, 116);
            this.rtb_Descripcion.TabIndex = 38;
            this.rtb_Descripcion.Text = "";
            // 
            // Consultar_Producto_Mascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 444);
            this.Controls.Add(this.rtb_Descripcion);
            this.Controls.Add(this.btn_Actualizar_Producto);
            this.Controls.Add(this.btn_Eliminar_Producto);
            this.Controls.Add(this.dgv_Producto_Mascota);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Consultar_Producto_Mascota";
            this.Text = "Producto_Mascota";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Producto_Mascota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.DataGridView dgv_Producto_Mascota;
        private System.Windows.Forms.Button btn_Eliminar_Producto;
        private System.Windows.Forms.Button btn_Actualizar_Producto;
        private System.Windows.Forms.RichTextBox rtb_Descripcion;
    }
}