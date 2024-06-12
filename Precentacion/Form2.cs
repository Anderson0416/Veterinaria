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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Form_Click(object sender, EventArgs e)
        {
            //Cita_Repositorio cita_Repositorio = new Cita_Repositorio();
            //DateTime fechaConsulta;

            //// Intentar convertir el texto del TextBox a una fecha
            //if (DateTime.TryParse(txtFechaConsulta.Text, out fechaConsulta))
            //{
            //    // Llamar al método para buscar citas por fecha
            //    List<Citas> citas = cita_Repositorio.Consultar_Citas_Por_Fecha(fechaConsulta);

            //    // Mostrar los resultados en el DataGridView
            //    if (citas != null && citas.Count > 0)
            //    {
            //        dgv_Form.DataSource = citas;
            //    }
            //    else
            //    {
            //        MessageBox.Show("No se encontraron citas para la fecha especificada.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Por favor, ingrese una fecha válida.");
            //}
        }
    }
}
