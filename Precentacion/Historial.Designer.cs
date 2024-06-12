namespace Precentacion
{
    partial class Historial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial));
            this.dgv_Historial = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Documento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nombre_Cliente = new System.Windows.Forms.TextBox();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbm_Mascotas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.btn_Imprimir_Historial = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Historial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Historial
            // 
            this.dgv_Historial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_Historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Historial.Location = new System.Drawing.Point(12, 350);
            this.dgv_Historial.Name = "dgv_Historial";
            this.dgv_Historial.Size = new System.Drawing.Size(798, 204);
            this.dgv_Historial.TabIndex = 0;
            this.dgv_Historial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Historial_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(326, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Documento ( Cliente )  ";
            // 
            // txt_Documento
            // 
            this.txt_Documento.Location = new System.Drawing.Point(447, 101);
            this.txt_Documento.Name = "txt_Documento";
            this.txt_Documento.Size = new System.Drawing.Size(100, 20);
            this.txt_Documento.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(342, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre ( Cliente )";
            // 
            // txt_Nombre_Cliente
            // 
            this.txt_Nombre_Cliente.Location = new System.Drawing.Point(447, 133);
            this.txt_Nombre_Cliente.Name = "txt_Nombre_Cliente";
            this.txt_Nombre_Cliente.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre_Cliente.TabIndex = 4;
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Consultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Consultar.Location = new System.Drawing.Point(727, 261);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(83, 34);
            this.btn_Consultar.TabIndex = 5;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = false;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(380, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mascotas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbm_Mascotas
            // 
            this.cbm_Mascotas.FormattingEnabled = true;
            this.cbm_Mascotas.Location = new System.Drawing.Point(447, 214);
            this.cbm_Mascotas.Name = "cbm_Mascotas";
            this.cbm_Mascotas.Size = new System.Drawing.Size(100, 21);
            this.cbm_Mascotas.TabIndex = 7;
            this.cbm_Mascotas.SelectedIndexChanged += new System.EventHandler(this.cbm_Mascotas_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MintCream;
            this.label4.Location = new System.Drawing.Point(342, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido ( Cliente )";
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(447, 163);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_Apellido.TabIndex = 9;
            // 
            // btn_Imprimir_Historial
            // 
            this.btn_Imprimir_Historial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Imprimir_Historial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Imprimir_Historial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Imprimir_Historial.Location = new System.Drawing.Point(727, 301);
            this.btn_Imprimir_Historial.Name = "btn_Imprimir_Historial";
            this.btn_Imprimir_Historial.Size = new System.Drawing.Size(83, 43);
            this.btn_Imprimir_Historial.TabIndex = 10;
            this.btn_Imprimir_Historial.Text = "Imprimir historial";
            this.btn_Imprimir_Historial.UseVisualStyleBackColor = false;
            this.btn_Imprimir_Historial.Click += new System.EventHandler(this.btn_Imprimir_Historial_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Moccasin;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.Color.Olive;
            this.btn_Salir.Location = new System.Drawing.Point(12, 13);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 11;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(823, 576);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Location = new System.Drawing.Point(292, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 214);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 573);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Imprimir_Historial);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbm_Mascotas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.txt_Nombre_Cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Documento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Historial);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Historial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Historial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Historial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Documento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nombre_Cliente;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbm_Mascotas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.Button btn_Imprimir_Historial;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}