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
using System.Xml.Linq;

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
            List<Citas> lista_Citas = citas_Repositorio.Consultar_CItas_Veterinarios(txt_Documento.Text);

            // Limpiar las filas existentes en el DataGridView
            dgv_Citas.Rows.Clear();

            // Agregar las columnas al DataGridView
            dgv_Citas.Columns.Clear(); // Limpiar las columnas existentes en el DataGridView
            dgv_Citas.Columns.Add("id", "ID de Cita");
            dgv_Citas.Columns.Add("fecha_consulta", "Fecha de Consulta");
            dgv_Citas.Columns.Add("descripcion", "Descripción");
            dgv_Citas.Columns.Add("mascota_id", "ID de Mascota");
            dgv_Citas.Columns.Add("mascota_nombre", "Nombre de Mascota");
            dgv_Citas.Columns.Add("veterinario_nombre", "Nombre de Veterinario");
            dgv_Citas.Columns.Add("veterinario_documento", "Documento de Veterinario");

            // Agregar las filas al DataGridView
            foreach (var cita in lista_Citas)
            {
                dgv_Citas.Rows.Add(
                    cita.id,
                    cita.fecha_consulta,
                    cita.descripcion,
                    cita.mascota.id,
                    cita.mascota.nombre,
                    cita.veterinario.nombre,
                    cita.veterinario.documento
                );
            }

        }
        private void dgv_Citas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Id_Mascota();
                string nombre = Nombre_Mascota();
                string descripcion = Descripcion_Cita();
                Consultorio consultorio = new Consultorio(id,nombre, descripcion);
                consultorio.Show();
            }
        } 
        public int Id_Mascota()
        {
            Mascota mascota = new Mascota();
            Citas citas = new Citas();
            
            mascota.id = int.Parse(dgv_Citas.SelectedCells[3].Value.ToString());
            mascota.nombre = dgv_Citas.SelectedCells[4].Value.ToString();
            citas.descripcion = dgv_Citas.SelectedCells[2].Value.ToString();

            return mascota.id;
        }
        public string Nombre_Mascota()
        {
            Mascota mascota = new Mascota();
            mascota.nombre = dgv_Citas.SelectedCells[4].Value.ToString();
            return mascota.nombre;
        }
        public string Descripcion_Cita()
        {
            Citas citas = new Citas();
            citas.descripcion = dgv_Citas.SelectedCells[2].Value.ToString();
            return citas.descripcion;
        }
    }
}
