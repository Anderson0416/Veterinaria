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
    public partial class Menu_Veterinario : Form
    {
        public Menu_Veterinario()
        {
            InitializeComponent();
        }
        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            Consultar_Veterinario();
            Consultar_Citas_Veterinario();
        }
        private void Consultar_Veterinario()
        {
            Veterinario_Repositorio veterinario_repositorio = new Veterinario_Repositorio();
            Veterinario veterinario = new Veterinario();
            string cedula = txt_Documento.Text;
            veterinario = veterinario_repositorio.Consulta_Documento_Veterinario(cedula);
            if (veterinario != null)
            {
                txt_Nombre.Text = veterinario.nombre;
            }
            else
            {
                MessageBox.Show("el usuario no a sido registrado, en el boton resgistrar lo puede hacer");
            }
        }
        private void Consultar_Citas_Veterinario()
        {
            Cita_Repositorio citas_Repositorio = new Cita_Repositorio();
            List<Citas> lista_Citas = citas_Repositorio.Consultar_Citas_Veterinario(txt_Documento.Text);

            dgv_Citas.DataSource = lista_Citas;
            //dgv_Citas.Columns["Id"].DisplayIndex = 0;
            //dgv_Citas.Columns["Descripcion"].DisplayIndex = 1;
            //dgv_Citas.Columns["Id_Mascota"].DisplayIndex = 2;
            //dgv_Citas.Columns["Fecha_Consulta"].DisplayIndex = 3;
            dgv_Citas.Columns[0].HeaderText = "id";
            dgv_Citas.Columns[1].HeaderText = "descripcion";
            dgv_Citas.Columns[2].HeaderText = "id_mascota";
            dgv_Citas.Columns[3].HeaderText = "fecha_consulta";
        }
        private void dgv_Citas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Id_Mascota();
                Consultorio consultorio = new Consultorio(id);
                consultorio.Show();
            }
        } 
        public int Id_Mascota()
        {
            Mascota mascota = new Mascota();
            
            mascota.id = int.Parse(dgv_Citas.SelectedCells[4].Value.ToString());

            return mascota.id;
        }
    }
}
