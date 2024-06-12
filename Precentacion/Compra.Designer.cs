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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compra));
            this.dgv_Productos = new System.Windows.Forms.DataGridView();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.btn_Salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtb_Descripcion = new System.Windows.Forms.RichTextBox();
            this.lb_Total_Pagar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Compra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Productos
            // 
            this.dgv_Productos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Productos.Location = new System.Drawing.Point(47, 48);
            this.dgv_Productos.Name = "dgv_Productos";
            this.dgv_Productos.ReadOnly = true;
            this.dgv_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Productos.Size = new System.Drawing.Size(543, 150);
            this.dgv_Productos.TabIndex = 0;
            this.dgv_Productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Productos_CellClick);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(370, 218);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_Cantidad.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MintCream;
            this.label5.Location = new System.Drawing.Point(315, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Cantidad";
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(114, 280);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(100, 20);
            this.txt_Precio.TabIndex = 47;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(114, 248);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 46;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(114, 221);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(46, 20);
            this.txt_ID.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MintCream;
            this.label4.Location = new System.Drawing.Point(71, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(64, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Descripcion ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(64, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(80, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "ID";
            // 
            // dgv_Compra
            // 
            this.dgv_Compra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Compra.Location = new System.Drawing.Point(56, 393);
            this.dgv_Compra.Name = "dgv_Compra";
            this.dgv_Compra.ReadOnly = true;
            this.dgv_Compra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Compra.Size = new System.Drawing.Size(445, 144);
            this.dgv_Compra.TabIndex = 51;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.MintCream;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_agregar.Location = new System.Drawing.Point(434, 14);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(94, 46);
            this.btn_agregar.TabIndex = 52;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_eliminar.Location = new System.Drawing.Point(507, 407);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(83, 47);
            this.btn_eliminar.TabIndex = 53;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(261, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 36);
            this.label6.TabIndex = 54;
            this.label6.Text = "Compra";
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Imprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Imprimir.Location = new System.Drawing.Point(507, 460);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(83, 41);
            this.btn_Imprimir.TabIndex = 55;
            this.btn_Imprimir.Text = "Imprimir Recibo";
            this.btn_Imprimir.UseVisualStyleBackColor = false;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Moccasin;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.Color.Olive;
            this.btn_Salir.Location = new System.Drawing.Point(13, 9);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 56;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(674, 594);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.rtb_Descripcion);
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.ForeColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Location = new System.Drawing.Point(56, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 183);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // rtb_Descripcion
            // 
            this.rtb_Descripcion.Location = new System.Drawing.Point(80, 102);
            this.rtb_Descripcion.Name = "rtb_Descripcion";
            this.rtb_Descripcion.Size = new System.Drawing.Size(273, 75);
            this.rtb_Descripcion.TabIndex = 49;
            this.rtb_Descripcion.Text = "";
            // 
            // lb_Total_Pagar
            // 
            this.lb_Total_Pagar.AutoSize = true;
            this.lb_Total_Pagar.Location = new System.Drawing.Point(64, 552);
            this.lb_Total_Pagar.Name = "lb_Total_Pagar";
            this.lb_Total_Pagar.Size = new System.Drawing.Size(13, 13);
            this.lb_Total_Pagar.TabIndex = 60;
            this.lb_Total_Pagar.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(547, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 61;
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 585);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_Total_Pagar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Imprimir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.dgv_Compra);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Productos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Compra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Productos;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtb_Descripcion;
        private System.Windows.Forms.Label lb_Total_Pagar;
        private System.Windows.Forms.Label label7;
    }
}