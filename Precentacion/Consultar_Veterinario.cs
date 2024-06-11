using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Precentacion
{
    public partial class Consultar_Veterinario : Form
    {
        public Consultar_Veterinario()
        {
            InitializeComponent();
            LlenarDataGribView_Veterinario();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     

        }
        private void Consultar_Veterinario_Load(object sender, EventArgs e)
        {

        }
        private void LlenarDataGribView_Veterinario()
{
         Veterinario_Repositorio veterinario_Repositorio = new Veterinario_Repositorio(); 

            List<Veterinario> veterinarios = veterinario_Repositorio.ObtenerVeterinarios();

            dgv_Veterinario.DataSource = veterinarios;

            dgv_Veterinario.Columns["ID"].HeaderText = "ID";
            dgv_Veterinario.Columns["nombre"].HeaderText = "Nombre";
            dgv_Veterinario.Columns["apellido"].HeaderText = "Apellido";
            dgv_Veterinario.Columns["tipo_documento"].HeaderText = "Tipo de Documento";
            dgv_Veterinario.Columns["documento"].HeaderText = "Documento";
            dgv_Veterinario.Columns["sexo"].HeaderText = "Sexo";
            dgv_Veterinario.Columns["telefono"].HeaderText = "Telefono";
            dgv_Veterinario.Columns["fecha_nacimiento"].HeaderText = "Fecha de Nacimiento";
            dgv_Veterinario.Columns["fecha_contrato"].HeaderText = "Fecha de Contrato";
     
}
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dgv_Veterinario.SelectedCells[1].Value.ToString();
            txt_Nombre.Text = dgv_Veterinario.SelectedCells[2].Value.ToString();
            txt_Apellido.Text = dgv_Veterinario.SelectedCells[3].Value.ToString();
            txt_Documento.Text = dgv_Veterinario.SelectedCells[4].Value.ToString();
            cbx_Tipo_Documento.Text = dgv_Veterinario.SelectedCells[5].Value.ToString();
            cbx_Sexo.Text = dgv_Veterinario.SelectedCells[6].Value.ToString();
            txt_Telefono.Text = dgv_Veterinario.SelectedCells[8].Value.ToString();
            dtp_Fecha_Nacimiento.Value = Convert.ToDateTime(dgv_Veterinario.SelectedCells[7].Value.ToString());
            dtp_Fecha_Contrato.Value = Convert.ToDateTime(dgv_Veterinario.SelectedCells[0].Value.ToString());



        }
        private void btn_E_Veterinario_Click(object sender, EventArgs e)
        {
            Veterinario_Repositorio veterinario_Repositorio = new Veterinario_Repositorio();
            veterinario_Repositorio.Eliminar_Veterinario(cbx_Tipo_Documento.Text);

        }
        private void btn_Eliminar_Veterinario_Click(object sender, EventArgs e)
        {
 
            string documento = txt_Documento.Text;
            Veterinario_Repositorio veterinario_repositorio = new Veterinario_Repositorio();    
            veterinario_repositorio.Eliminar_Veterinario(documento);
            LlenarDataGribView_Veterinario();
    }
        private void btn_Actualizar_Veterinario_Click(object sender, EventArgs e)
        {
            Veterinario veterinario = new Veterinario();

             veterinario.id = int.Parse(txt_ID.Text);
             veterinario.nombre = txt_Nombre.Text;  
             veterinario.apellido = txt_Apellido.Text;   
             veterinario.tipo_documento = cbx_Tipo_Documento.Text;   
             veterinario.documento = txt_Documento.Text;
             veterinario.sexo = cbx_Sexo.Text;
            veterinario.fecha_nacimiento = dtp_Fecha_Nacimiento.Text;
            veterinario.fecha_contrato = dtp_Fecha_Contrato.Text;
            veterinario.telefono = txt_Telefono.Text;   

            Veterinario_Repositorio veterinario_Repositorio = new Veterinario_Repositorio();
            veterinario_Repositorio.Actualizar_Veterinario(veterinario);
            LlenarDataGribView_Veterinario() ;

        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
        
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
