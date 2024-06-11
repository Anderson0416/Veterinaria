namespace Precentacion
{
    partial class Compra
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
            this.dgv_Productos = new System.Windows.Forms.DataGridView();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtb_Descripcion = new System.Windows.Forms.RichTextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Compra = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Compra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Productos
            // 
            this.dgv_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Productos.Location = new System.Drawing.Point(61, 84);
            this.dgv_Productos.Name = "dgv_Productos";
            this.dgv_Productos.ReadOnly = true;
            this.dgv_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Productos.Size = new System.Drawing.Size(607, 150);
            this.dgv_Productos.TabIndex = 0;
            this.dgv_Productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Productos_CellClick);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(502, 290);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_Cantidad.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Cantidad";
            // 
            // rtb_Descripcion
            // 
            this.rtb_Descripcion.Location = new System.Drawing.Point(117, 333);
            this.rtb_Descripcion.Name = "rtb_Descripcion";
            this.rtb_Descripcion.Size = new System.Drawing.Size(259, 116);
            this.rtb_Descripcion.TabIndex = 48;
            this.rtb_Descripcion.Text = "";
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(117, 301);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(100, 20);
            this.txt_Precio.TabIndex = 47;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(117, 269);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 46;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(117, 240);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Descripcion ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "ID";
            // 
            // dgv_Compra
            // 
            this.dgv_Compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Compra.Location = new System.Drawing.Point(61, 503);
            this.dgv_Compra.Name = "dgv_Compra";
            this.dgv_Compra.ReadOnly = true;
            this.dgv_Compra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Compra.Size = new System.Drawing.Size(607, 150);
            this.dgv_Compra.TabIndex = 51;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(463, 336);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(125, 122);
            this.btn_agregar.TabIndex = 52;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(404, 678);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(143, 60);
            this.btn_eliminar.TabIndex = 53;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Compra";
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Location = new System.Drawing.Point(621, 697);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(75, 23);
            this.btn_Imprimir.TabIndex = 55;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 845);
            this.Controls.Add(this.btn_Imprimir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.dgv_Compra);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtb_Descripcion);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Productos);
            this.Name = "Compra";
            this.Text = "Compra";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Compra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Productos;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtb_Descripcion;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Compra;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Imprimir;
    }
}