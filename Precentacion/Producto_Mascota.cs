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
    public partial class Producto_Mascota : Form
    {
        public Producto_Mascota()
        {
            InitializeComponent();
        }

        private void btn_Registrar_Producto_Click(object sender, EventArgs e)
        {
            Registrar_Producto registrar_Producto = new Registrar_Producto();
            registrar_Producto.Visible = true;
            this.Visible = false;

        }

        private void btn_Consultar_Producto_Click(object sender, EventArgs e)
        {
            Consultar_Producto_Mascota consultar_Producto_Mascota= new Consultar_Producto_Mascota();
            consultar_Producto_Mascota.Visible = true;
            this.Visible = false;

        }
    }
}
