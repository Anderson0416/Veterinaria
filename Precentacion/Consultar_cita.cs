using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Precentacion
{
    public partial class Consultar_Cita : Form
    {
        
        public Consultar_Cita()
        {
            InitializeComponent();
            Llenar_Tabla_Citas();
            Mostrar_Veterinario_cmb();


        }
        private void Mostrar_Veterinario_cmb()
        {
            Veterinario_Repositorio veterinario_repositorio = new Veterinario_Repositorio();
            Veterinario veterinario = new Veterinario();
            List<Veterinario> veterinarios;
            veterinarios = veterinario_repositorio.ObtenerVeterinarios();
            cmb_Nombre_Veterinario.DataSource = veterinarios;
            cmb_Nombre_Veterinario.DisplayMember = "nombre";
            cmb_Nombre_Veterinario.ValueMember = "documento";
        }
        private void Consultar_Cita_Load(object sender, EventArgs e)
        {

        }
        private void Llenar_Tabla_Citas()
        {
            Cita_Repositorio citas_Repositorio = new Cita_Repositorio();
            List<Citas> lista_Citas = citas_Repositorio.Consultar_Todas_Citas();

            dgv_Llenar_Tabla_Cita.Rows.Clear();

            dgv_Llenar_Tabla_Cita.Columns.Clear(); 
            dgv_Llenar_Tabla_Cita.Columns.Add("id", "ID de Cita");
            dgv_Llenar_Tabla_Cita.Columns.Add("fecha_consulta", "Fecha de Consulta");
            dgv_Llenar_Tabla_Cita.Columns.Add("descripcion", "Descripción");
            dgv_Llenar_Tabla_Cita.Columns.Add("mascota_id", "ID de Mascota");
            dgv_Llenar_Tabla_Cita.Columns.Add("mascota_nombre", "Nombre de Mascota");
            dgv_Llenar_Tabla_Cita.Columns.Add("veterinario_nombre", "Nombre de Veterinario");
            dgv_Llenar_Tabla_Cita.Columns.Add("veterinario_documento", "Documento de Veterinario");

            foreach (var cita in lista_Citas)
            {
                dgv_Llenar_Tabla_Cita.Rows.Add(
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
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            string Id = txt_Id_Cita.Text;
            Cita_Repositorio cita_Repositorio = new Cita_Repositorio();
            cita_Repositorio.Eliminar_Cita(Id);
            Llenar_Tabla_Citas();
  
        }
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            Citas citas = new Citas();

            citas.veterinario = new Veterinario();
            citas.mascota = new Mascota();

            citas.id = int.Parse(txt_Id_Cita.Text);
            citas.mascota.id = int.Parse(txt_ID_Mascot.Text);
            citas.fecha_consulta = dtp_Fecha_Consulta.Text;
            citas.descripcion = rtb_Descripcion.Text;
            citas.veterinario.documento = (string)cmb_Nombre_Veterinario.SelectedValue;

            Cita_Repositorio cita_Repositorio = new Cita_Repositorio();
            cita_Repositorio.Actualizar_Cita(citas);
            Llenar_Tabla_Citas();
        }
        //public void actualizar()
        //{
        //    //Cita_Repositorio cita_Repositorio = new Cita_Repositorio();
        //    //DateTime fechaConsulta;

        //    //// Intentar convertir el texto del TextBox a una fecha
        //    //if (DateTime.TryParse(txtFechaConsulta.Text, out fechaConsulta))
        //    //{
        //    //    // Llamar al método para buscar citas por fecha
        //    //    List<Citas> citas = cita_Repositorio.Consultar_Citas_Por_Fecha(fechaConsulta);

        //    //    // Mostrar los resultados en el DataGridView
        //    //    if (citas != null && citas.Count > 0)
        //    //    {
        //    //        dgv_Form.DataSource = citas;
        //    //    }
        //    //    else
        //    //    {
        //    //        MessageBox.Show("No se encontraron citas para la fecha especificada.");
        //    //    }
        //    //}
        //    //else
        //    //{
        //    //    MessageBox.Show("Por favor, ingrese una fecha válida.");
        //    //}
        //}
        private void dgv_Llenar_Tabla_Cita_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Id_Cita.Text = dgv_Llenar_Tabla_Cita.SelectedCells[0].Value.ToString();
            txt_ID_Mascot.Text = dgv_Llenar_Tabla_Cita.SelectedCells[3].Value.ToString();
            txt_Nombre_Mascot.Text = dgv_Llenar_Tabla_Cita.SelectedCells[4].Value.ToString();
            cmb_Nombre_Veterinario.Text = dgv_Llenar_Tabla_Cita.SelectedCells[5].Value.ToString();
            dtp_Fecha_Consulta.Value = Convert.ToDateTime(dgv_Llenar_Tabla_Cita.SelectedCells[1].Value.ToString());
            rtb_Descripcion.Text = dgv_Llenar_Tabla_Cita.SelectedCells[2].Value.ToString();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
         
            this.Visible = false;
        }
    }
}
