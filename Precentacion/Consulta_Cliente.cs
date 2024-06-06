using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Precentacion
{
    public partial class Consulta_Cliente : Form
    {

        public Consulta_Cliente()
        {
            InitializeComponent();
            LlenarDataGridView_Cliente();
        }
    
        private void LlenarDataGridView_Cliente()
        {

            Cliente_Repositorio cliente_Repositorio = new Cliente_Repositorio();
            List<Cliente> listaClientes = cliente_Repositorio.Consultar_Todos_Cliente();

            dgv_Cliente.DataSource = listaClientes;
            dgv_Cliente.Columns["id"].HeaderText = "Id";
            dgv_Cliente.Columns["nombre"].HeaderText = "Nombre";
            dgv_Cliente.Columns["apellido"].HeaderText = "Apellido";
            dgv_Cliente.Columns["tipo_documento"].HeaderText = "Tipo de Documento";
            dgv_Cliente.Columns["documento"].HeaderText = "Documento";
            dgv_Cliente.Columns["sexo"].HeaderText = "Sexo";
            dgv_Cliente.Columns["fecha_nacimiento"].HeaderText = "Fecha de Nacimiento";
            dgv_Cliente.Columns["telefono"].HeaderText = "Teléfono";
        }
        private void dgv_Cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dgv_Cliente.SelectedCells[0].Value.ToString();
            txt_Nombre.Text = dgv_Cliente.SelectedCells[1].Value.ToString();
            txt_Apellido.Text = dgv_Cliente.SelectedCells[2].Value.ToString();
            txt_Documento.Text = dgv_Cliente.SelectedCells[3].Value.ToString();
            cbx_Tipo_Documento.Text = dgv_Cliente.SelectedCells[4].Value.ToString();
            cbx_Sexo.Text = dgv_Cliente.SelectedCells[5].Value.ToString();
            txt_Telefono.Text = dgv_Cliente.SelectedCells[7].Value.ToString();
            dateTimePicker1.Value= Convert.ToDateTime(dgv_Cliente.SelectedCells[6].Value.ToString());
           
        }
        private void btn_E_Cliente_Click(object sender, EventArgs e)
        {
            Cliente_Repositorio cliente_Repositorio = new Cliente_Repositorio();
            cliente_Repositorio.Eliminar_Cliente(cbx_Tipo_Documento.Text);

        }
        private void btn_Eliminar_Cliente_Click(object sender, EventArgs e)
        {
            string documento = txt_Documento.Text;

            Cliente_Repositorio cliente_Repositorio = new Cliente_Repositorio();
            cliente_Repositorio.Eliminar_Cliente(documento);
            LlenarDataGridView_Cliente();


        }
        private void btn_Actualizar_Cliente_Click(object sender, EventArgs e)
        {

            Cliente cliente = new Cliente();

            cliente.id = int.Parse(txt_ID.Text);
            cliente.nombre = txt_Nombre.Text;
            cliente.apellido = txt_Apellido.Text;
            cliente.tipo_documento = cbx_Tipo_Documento.Text;
            cliente.documento = txt_Documento.Text;
            cliente.sexo = cbx_Sexo.Text;
            //cliente.fecha_nacimiento = dtp_Fecha_Nacimiento.???;
            cliente.telefono = txt_Telefono.Text;


            Cliente_Repositorio cliente_Repositorio = new Cliente_Repositorio();
            cliente_Repositorio.Actualizar_Cliente(cliente);
            LlenarDataGridView_Cliente();
        }
       
       
    } 
}
    
