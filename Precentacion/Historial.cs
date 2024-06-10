using BLL;
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
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbm_Mascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbm_Mascotas.SelectedValue != null)
            {
                int idMascota;
                if (int.TryParse(cbm_Mascotas.SelectedValue.ToString(), out idMascota))
                {
                    Llenar_Tabla_Historia_Mascota(idMascota);
                }
            }
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            Consultar_CLiente();
        }
        private void Consultar_CLiente()
        {
            Cliente_Repositorio cliente_repositorio = new Cliente_Repositorio();
            Cliente cliente = new Cliente();
            string cedula = txt_Documento.Text;
            cliente = cliente_repositorio.Consulta_Documento_Cliente(cedula);
            if (cliente != null)
            {
                txt_Nombre_Cliente.Text = cliente.nombre;
                txt_Apellido.Text = cliente.apellido;
                Mostrar_Mascota_cmb();
            }
            else
            {
                MessageBox.Show("el usuario no a sido registrado, en el boton resgistrar lo puede hacer");
            }
        }
        private void Llenar_Tabla_Historia_Mascota(int id)
        {
            Hitoriales_Repositorio historial_repositorio = new Hitoriales_Repositorio();
            List<Hitoriales> lista_historial = historial_repositorio.Consultar_Historial_Mascota(id);

            dgv_Historial.Columns.Clear();
            dgv_Historial.Columns.Add("HistorialId", "ID del Historial");
            dgv_Historial.Columns.Add("FechaCreacion", "Fecha de la cita");
            dgv_Historial.Columns.Add("MascotaId", "ID de la mascota");
            dgv_Historial.Columns.Add("NombreMascota", "Nombre de la mascota");
            dgv_Historial.Columns.Add("AnamnesisId", "ID de anamnesis");
            dgv_Historial.Columns.Add("Observaciones", "Observaciones");

            foreach (var historial in lista_historial)
            {
                dgv_Historial.Rows.Add(
                    historial.id,
                    historial.fecha_consulta,
                    historial.mascota.id,
                    historial.mascota.nombre,
                    historial.anamnesis.id,
                    historial.anamnesis.observaciones
                );
            }

        }
        private void Mostrar_Mascota_cmb()
        {
            Mascota_Repositorio mascota_repositorio = new Mascota_Repositorio();
            List<Mascota> mascotas = mascota_repositorio.Consulta_Mascota_Cliente(txt_Documento.Text);
            cbm_Mascotas.DataSource = mascotas;
            cbm_Mascotas.DisplayMember = "nombre";
            cbm_Mascotas.ValueMember = "id";
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            
        }

        private void dgv_Historial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id_anamnesis = Id_Anamnesis();
                int id_historial = Id_Historial();
                int id_mascota = 0;
                int id_cita = 0;
                string nombre = "";
                string descripcion = "";

                Consultorio consultorio = new Consultorio(id_mascota, id_cita, nombre, descripcion, id_anamnesis, id_historial);
                consultorio.Show();
                this.Visible = false;
            }
        }
        public int Id_Anamnesis()
        {
            Anamnesis anamnesis = new Anamnesis();
            anamnesis.id = int.Parse(dgv_Historial.SelectedCells[4].Value.ToString());
            return anamnesis.id;
        }
        public int Id_Historial()
        {
            Hitoriales hitoriales = new Hitoriales();
            hitoriales.id = int.Parse(dgv_Historial.SelectedCells[4].Value.ToString());
            return hitoriales.id;
        }

        private void btn_Imprimir_Historial_Click(object sender, EventArgs e)
        {
            int idHistorial = int.Parse(dgv_Historial.SelectedCells[0].Value.ToString());
            string rutaDirectorio = @"C:\Users\RYZEN\Desktop\c#\Veterinaria_2\Veterinaria\pdf";
            pdf_Historial pdf_Historial = new pdf_Historial();
            string respuesta = (pdf_Historial.Generar_Pdf_List_aHistorial(idHistorial, rutaDirectorio));
            MessageBox.Show(respuesta);
        }
    }
}
