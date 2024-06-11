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
            
        }
        private void btn_Registrar_Cliente_Click(object sender, EventArgs e)
        {
            Registro_Cliente registro_cliente = new Registro_Cliente();
            registro_cliente.Visible = true;
            
        }
        private void btn_Registrar_Mascota_Click(object sender, EventArgs e)
        {
            Registro_Mascota registro_mascota = new Registro_Mascota();
            registro_mascota.Visible = true;
         
        }
        private void btn_Registrar_Veterinario_Click(object sender, EventArgs e)
        {
            Registrar_Veterinario registro_veterinario = new Registrar_Veterinario();
            registro_veterinario.Visible = true;
           
        }
        private void btn_Agendar_Click(object sender, EventArgs e)
        {
            Agendar_cita agendar_Cita = new Agendar_cita();
            agendar_Cita.Visible = true;
            
        }
        private void btn_Historial_Click(object sender, EventArgs e)
        {
            Historial historial = new Historial();
            historial.Visible = true;
           
        }
        private void btn_Consultar_Click(object sender, EventArgs e)
        {

           Todos_Los_Consultar todos_Los_Consultar = new Todos_Los_Consultar(); 
           todos_Los_Consultar.Visible = true;
         

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Seguro que quiere cerrar sesión?", "Confirmar cierre de sesión", MessageBoxButtons.OKCancel);

            // Verificar si el usuario seleccionó "OK"
            if (confirmacion == DialogResult.OK)
            {
                this.Close();

                // Abrir el nuevo formulario
                Login login = new Login();
                login.Show();
            }
        }
    }
}
