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
    public partial class Consultorio : Form
    {
        public Consultorio(int id, string nombre, string descripcion)
        {
            InitializeComponent();
            txt_Id_Mascota.Text = id.ToString();
            txt_Nombre_Mascota.Text = nombre;
            txt_Descripcion.Text = descripcion;
        }

    }
}
