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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar_Producto_Mascota));
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Producto_Mascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(156, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(130, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(108, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MintCream;
            this.label4.Location = new System.Drawing.Point(137, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(180, 59);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 4;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(180, 88);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 5;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(180, 120);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(100, 20);
            this.txt_Precio.TabIndex = 7;
            // 
            // dgv_Producto_Mascota
            // 
            this.dgv_Producto_Mascota.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_Producto_Mascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Producto_Mascota.Location = new System.Drawing.Point(58, 324);
            this.dgv_Producto_Mascota.Name = "dgv_Producto_Mascota";
            this.dgv_Producto_Mascota.ReadOnly = true;
            this.dgv_Producto_Mascota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Producto_Mascota.Size = new System.Drawing.Size(523, 199);
            this.dgv_Producto_Mascota.TabIndex = 8;
            this.dgv_Producto_Mascota.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Producto_Mascota_CellClick);
            // 
            // btn_Eliminar_Producto
            // 
            this.btn_Eliminar_Producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Eliminar_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar_Producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Eliminar_Producto.Location = new System.Drawing.Point(495, 275);
            this.btn_Eliminar_Producto.Name = "btn_Eliminar_Producto";
            this.btn_Eliminar_Producto.Size = new System.Drawing.Size(86, 43);
            this.btn_Eliminar_Producto.TabIndex = 9;
            this.btn_Eliminar_Producto.Text = "Eliminar Producto";
            this.btn_Eliminar_Producto.UseVisualStyleBackColor = false;
            this.btn_Eliminar_Producto.Click += new System.EventHandler(this.btn_Eliminar_Producto_Click_1);
            // 
            // btn_Actualizar_Producto
            // 
            this.btn_Actualizar_Producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Actualizar_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizar_Producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Actualizar_Producto.Location = new System.Drawing.Point(495, 230);
            this.btn_Actualizar_Producto.Name = "btn_Actualizar_Producto";
            this.btn_Actualizar_Producto.Size = new System.Drawing.Size(86, 39);
            this.btn_Actualizar_Producto.TabIndex = 10;
            this.btn_Actualizar_Producto.Text = "Actualizar  Producto";
            this.btn_Actualizar_Producto.UseVisualStyleBackColor = false;
            this.btn_Actualizar_Producto.Click += new System.EventHandler(this.btn_Actualizar_Producto_Click_1);
            // 
            // rtb_Descripcion
            // 
            this.rtb_Descripcion.Location = new System.Drawing.Point(180, 188);
            this.rtb_Descripcion.Name = "rtb_Descripcion";
            this.rtb_Descripcion.Size = new System.Drawing.Size(259, 116);
            this.rtb_Descripcion.TabIndex = 38;
            this.rtb_Descripcion.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MintCream;
            this.label5.Location = new System.Drawing.Point(125, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Cantidad";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(180, 158);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_Cantidad.TabIndex = 40;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Moccasin;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.Color.Olive;
            this.btn_Salir.Location = new System.Drawing.Point(12, 12);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 41;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Location = new System.Drawing.Point(97, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 277);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(615, 543);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // Consultar_Producto_Mascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(614, 541);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.label5);
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
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Consultar_Producto_Mascota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto_Mascota";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Producto_Mascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}