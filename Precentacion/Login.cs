using BLL;
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
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }
        private void Inicio_Seccion()
        {
            Menu_Recepcio menu_recepcio = new Menu_Recepcio();
            Menu_Veterinario menu_veterinario = new Menu_Veterinario();
            int tipo_Usuario = Seccion.Tipo_usuario;
            
            if(tipo_Usuario == 1)
            {
                menu_recepcio.Visible = true;
                this.Visible = false;
            }
            
            if(tipo_Usuario == 2)
              {
                 menu_veterinario.Visible = true;
                 this .Visible = false;
              }
            
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            Controladores controladores = new Controladores();
            string respuesta = controladores.control_Login(txt_Usuario.Text, txt_Contraseña.Text);
            if (respuesta.Length > 0)
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                Inicio_Seccion();
            }
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Registrar_Usuario registro_Usuario = new Registrar_Usuario();
            registro_Usuario.Visible = true;
            this.Visible = false;
        }

        
    }
}
