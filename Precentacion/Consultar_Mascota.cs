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

            dgv_Mascota.Rows.Clear();
            dgv_Mascota.Columns.Add("ID", "ID");
            dgv_Mascota.Columns.Add("Nombre", "Nombre");
            dgv_Mascota.Columns.Add("Especie", "Especie");
            dgv_Mascota.Columns.Add("Raza", "Raza");
            dgv_Mascota.Columns.Add("Sexo", "Sexo");
            dgv_Mascota.Columns.Add("Edad", "Edad");
            dgv_Mascota.Columns.Add("Edad2", "Edad2");
            dgv_Mascota.Columns.Add("Cliente_Documento", "Documento del Cliente");
            foreach (Mascota mascota in mascotas)
            {
                dgv_Mascota.Rows.Add(
                    mascota.id,
                    mascota.nombre,
                    mascota.especie,
                    mascota.raza,
                    mascota.sexo,
                    mascota.edad,
                    mascota.edad2,
                    mascota.cliente.documento
                );
            }
            
        }
        private void dgv_Mascota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_Mascota.Rows[e.RowIndex];
            txt_ID.Text = row.Cells["id"].Value.ToString();
            txt_Nombre.Text = row.Cells["nombre"].Value.ToString();
            txt_Especie.Text = row.Cells["especie"].Value.ToString();
            txt_Raza.Text = row.Cells["raza"].Value.ToString();
            cbx_Sexo.Text = row.Cells["sexo"].Value.ToString();
            txt_Edad.Text = row.Cells["edad"].Value.ToString();
            cbx_Edad2.Text = row.Cells["edad2"].Value.ToString();
            txt_Cliente_Documento.Text = row.Cells["cliente_documento"].Value.ToString();
            

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
                mascota.edad2 = cbx_Edad2.Text;
           

            Mascota_Repositorio mascota_Repositorio = new Mascota_Repositorio();
            mascota_Repositorio.Actualizar_Mascota(mascota);
            LlenarDataGribView_Mascota();

        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
           
            this.Visible = false;
        }
    }
}