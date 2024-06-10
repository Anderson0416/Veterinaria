using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Precentacion
{
    public partial class Menu_Recepcio : Form
    {
        public Menu_Recepcio()
        {
            InitializeComponent();
        }
        private void Menu_Recepcio_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //private void label3_Click(object sender, EventArgs e);
        private void button2_Click(object sender, EventArgs e)
        {
            Agendar_cita agendar_Cita = new Agendar_cita();
            agendar_Cita.Visible = true;
            this.Visible = false;
        }
        private void btn_Registrar_Cliente_Click(object sender, EventArgs e)
        {
            Registro_Cliente registro_cliente = new Registro_Cliente();
            registro_cliente.Visible = true;
            this.Visible = false;
        }
        private void btn_Registrar_Mascota_Click(object sender, EventArgs e)
        {
            Registro_Mascota registro_mascota = new Registro_Mascota();
            registro_mascota.Visible = true;
            this.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Registrar_Veterinario registro_veterinario = new Registrar_Veterinario();
            registro_veterinario.Visible = true;
            this.Visible = false;
        }
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

          

            
        }

        private void btn_Agendar_Click(object sender, EventArgs e)
        {
            Agendar_cita agendar_Cita = new Agendar_cita();
            agendar_Cita.Visible = true;
            this.Visible=false;
        }

        private void btn_Historial_Click(object sender, EventArgs e)
        {
            Historial historial = new Historial();
            historial.Visible = true;
            this.Visible=false;
        }
    }
}
