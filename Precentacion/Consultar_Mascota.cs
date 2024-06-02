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
    public partial class Consultar_Mascota : Form
    {
        public Consultar_Mascota()
        {
            InitializeComponent();
            LlenarDataGribView_Mascota();
        }

        private void Consultar_Mascota_Load(object sender, EventArgs e)
        {

        }
        private void LlenarDataGribView_Mascota()
        {
            Mascota_Repositorio mascota_Repositorio = new Mascota_Repositorio();

            List<Mascota> mascotas = mascota_Repositorio.Consultar_Todos_Mascota();

            dgv_Mascota.DataSource = mascotas;

            dgv_Mascota.Columns["ID"].HeaderText = "ID";
            dgv_Mascota.Columns["nombre"].HeaderText = "Nombre";
            dgv_Mascota.Columns["especie"].HeaderText = "Especie";
            dgv_Mascota.Columns["raza"].HeaderText = "Raza";
            dgv_Mascota.Columns["sexo"].HeaderText = "Sexo";
            dgv_Mascota.Columns["edad"].HeaderText = "Edad";
            dgv_Mascota.Columns["edad2"].HeaderText = "Edad2";
            dgv_Mascota.Columns["cliente_documento"].HeaderText = "Documento del cliente";



        }
        private void dgv_Mascota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dgv_Mascota.SelectedCells[0].Value.ToString();
            txt_Nombre.Text = dgv_Mascota.SelectedCells[1].Value.ToString();
            txt_Especie.Text = dgv_Mascota.SelectedCells[2].Value.ToString();
            txt_Raza.Text = dgv_Mascota.SelectedCells[3].Value.ToString();
            cbx_Sexo.Text = dgv_Mascota.SelectedCells[4].Value.ToString();
            txt_Edad.Text = dgv_Mascota.SelectedCells[5].Value.ToString();
            txt_Edad2.Text = dgv_Mascota.SelectedCells[6].Value.ToString();
            txt_Cliente_Documento.Text = dgv_Mascota.SelectedCells[7].Value.ToString();

        }
       private void btn_E_Mascota_Click(object sender, EventArgs e)
        {
            Mascota_Repositorio mascota_Repositorio = new Mascota_Repositorio();
            mascota_Repositorio.Eliminar_Mascota(txt_Cliente_Documento.Text);

            Veterinario_Repositorio veterinario_Repositorio = new Veterinario_Repositorio();
            veterinario_Repositorio.Eliminar_Veterinario(txt_ID.Text);

        }
        private void btn_Eliminar_Mascota_Click(object sender, EventArgs e)
        {
            string documento = txt_ID.Text;

            Mascota_Repositorio mascota_Repositorio = new Mascota_Repositorio();
            mascota_Repositorio.Eliminar_Mascota(documento);
            LlenarDataGribView_Mascota();

        }
        private void btn_Actualizar_Mascota_Click(object sender, EventArgs e)
        {

                Mascota mascota = new Mascota();   

                mascota.id = int.Parse(txt_ID.Text);
                mascota.nombre = txt_Nombre.Text;
                mascota.especie = txt_Especie.Text;
                mascota.raza = txt_Raza.Text;
                mascota.sexo = cbx_Sexo.Text;
                mascota.edad = txt_Edad.Text;
                mascota.edad2 = txt_Edad2.Text;
                mascota.cliente_documento = txt_Cliente_Documento.Text;

            Mascota_Repositorio mascota_Repositorio = new Mascota_Repositorio();
            mascota_Repositorio.Actualizar_Mascota(mascota);
          
            }
    }
}