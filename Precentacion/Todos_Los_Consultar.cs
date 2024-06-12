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
    public partial class Todos_Los_Consultar : Form
    {
        public Todos_Los_Consultar()
        {
            InitializeComponent();
        }

        private void btn_Consultar_Cliente_Click(object sender, EventArgs e)
        {
            Consulta_Cliente consulta_Cliente = new Consulta_Cliente();
            consulta_Cliente.Visible = true;
            this.Visible = false;

           
        }

        private void btn_Consultar_Cita_Click(object sender, EventArgs e)
        {
            Consultar_Cita consultar_Cita = new Consultar_Cita();
            consultar_Cita.Visible = true;
            this.Visible = false;   

        }

        private void btn_Consultar_Mascota_Click(object sender, EventArgs e)
        {
             Consultar_Mascota consultar_Mascota = new Consultar_Mascota();
            consultar_Mascota.Visible = true;
            this.Visible = false;
        }

        private void btn_Consultar_Veterinario_Click(object sender, EventArgs e)
        {
            Consultar_Veterinario consultar_Veterinario = new Consultar_Veterinario();
            consultar_Veterinario.Visible = true;
            this.Visible = false;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
      
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultar_Producto_Mascota consultar_Producto_Mascota = new Consultar_Producto_Mascota();
            consultar_Producto_Mascota.Visible = true;
            this.Visible = false;   
           
        }
    }
}
