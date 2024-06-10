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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Historial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Historial
            // 
            this.dgv_Historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Historial.Location = new System.Drawing.Point(12, 321);
            this.dgv_Historial.Name = "dgv_Historial";
            this.dgv_Historial.Size = new System.Drawing.Size(806, 186);
            this.dgv_Historial.TabIndex = 0;
            this.dgv_Historial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Historial_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "documento (cliente)";
            // 
            // txt_Documento
            // 
            this.txt_Documento.Location = new System.Drawing.Point(175, 57);
            this.txt_Documento.Name = "txt_Documento";
            this.txt_Documento.Size = new System.Drawing.Size(100, 20);
            this.txt_Documento.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre (cliente)";
            // 
            // txt_Nombre_Cliente
            // 
            this.txt_Nombre_Cliente.Location = new System.Drawing.Point(175, 95);
            this.txt_Nombre_Cliente.Name = "txt_Nombre_Cliente";
            this.txt_Nombre_Cliente.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre_Cliente.TabIndex = 4;
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Location = new System.Drawing.Point(364, 57);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_Consultar.TabIndex = 5;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mascotas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbm_Mascotas
            // 
            this.cbm_Mascotas.FormattingEnabled = true;
            this.cbm_Mascotas.Location = new System.Drawing.Point(155, 217);
            this.cbm_Mascotas.Name = "cbm_Mascotas";
            this.cbm_Mascotas.Size = new System.Drawing.Size(121, 21);
            this.cbm_Mascotas.TabIndex = 7;
            this.cbm_Mascotas.SelectedIndexChanged += new System.EventHandler(this.cbm_Mascotas_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido (cliente)";
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(175, 135);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_Apellido.TabIndex = 9;
            // 
            // btn_Imprimir_Historial
            // 
            this.btn_Imprimir_Historial.Location = new System.Drawing.Point(404, 131);
            this.btn_Imprimir_Historial.Name = "btn_Imprimir_Historial";
            this.btn_Imprimir_Historial.Size = new System.Drawing.Size(127, 23);
            this.btn_Imprimir_Historial.TabIndex = 10;
            this.btn_Imprimir_Historial.Text = "Imprimir historial";
            this.btn_Imprimir_Historial.UseVisualStyleBackColor = true;
            this.btn_Imprimir_Historial.Click += new System.EventHandler(this.btn_Imprimir_Historial_Click);
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 551);
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
            this.Name = "Historial";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Historial)).EndInit();
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
    }
}