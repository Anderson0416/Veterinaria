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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void Consulta_Cliente_Load(object sender, EventArgs e)
        {

        }
        private void Consulta_Cliente_Load_1(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LlenarDataGridView_Cliente()
        {

            Cliente_Repositorio cliente_Repositorio = new Cliente_Repositorio();
            List<Cliente> listaClientes = cliente_Repositorio.Consultar_Todos_Cliente();

            dtv_Cliente.DataSource = listaClientes;
            dtv_Cliente.Columns["id"].HeaderText = "Id";
            dtv_Cliente.Columns["nombre"].HeaderText = "Nombre";
            dtv_Cliente.Columns["apellido"].HeaderText = "Apellido";
            dtv_Cliente.Columns["tipo_documento"].HeaderText = "Tipo de Documento";
            dtv_Cliente.Columns["documento"].HeaderText = "Documento";
            dtv_Cliente.Columns["sexo"].HeaderText = "Sexo";
            dtv_Cliente.Columns["fecha_nacimiento"].HeaderText = "Fecha de Nacimiento";
            dtv_Cliente.Columns["telefono"].HeaderText = "Teléfono";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dtv_Cliente.SelectedCells[0].Value.ToString();
            txt_Nombre.Text = dtv_Cliente.SelectedCells[1].Value.ToString();
            txt_Apellido.Text = dtv_Cliente.SelectedCells[2].Value.ToString();
            txt_Documento.Text = dtv_Cliente.SelectedCells[3].Value.ToString();
            txt_Tipo_Documento.Text = dtv_Cliente.SelectedCells[4].Value.ToString();
            cbx_Sexo.Text = dtv_Cliente.SelectedCells[5].Value.ToString();
            txt_Telefono.Text = dtv_Cliente.SelectedCells[7].Value.ToString();

        }
        private void btn_E_Cliente_Click(object sender, EventArgs e)
        {
            Cliente_Repositorio cliente_Repositorio = new Cliente_Repositorio();
            cliente_Repositorio.Eliminar_Cliente(txt_Tipo_Documento.Text);

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
            cliente.tipo_documento = txt_Tipo_Documento.Text;
            cliente.documento = txt_Documento.Text;
            cliente.sexo = cbx_Sexo.Text;
            //cliente.fecha_nacimiento = dtp_Fecha_Nacimiento.???;
            cliente.telefono = txt_Telefono.Text;


            Cliente_Repositorio cliente_Repositorio = new Cliente_Repositorio();
            cliente_Repositorio.Actualizar_Cliente(cliente);
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
    } 
}
    
