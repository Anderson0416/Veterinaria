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
    public partial class Registro_Mascota : Form
    {
        public Registro_Mascota()
        {
            InitializeComponent();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            Registrar_Datos registrar_Datos = new Registrar_Datos();
            Cliente cliente = new Cliente();
            
            string cedula = txt_cedulacliente.Text;
            cliente = registrar_Datos.existeciaCliente(cedula);
            if(cliente != null)
            {
                txt_Nombre_Cliente.Text = cliente.nombre;
                txt_Apellido_Cliente.Text = cliente.apellido;
            }
            else
            {
                MessageBox.Show("el usuario no a sido registrado, en el boton resgistrar lo puede hacer");
            }

        }

        private void btn_Registrar_Mascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            Cliente cliente = new Cliente();
            
           
            mascota.nombre_mascota = txt_Nombre_Mascota.Text;
            mascota.especie = txt_Especie.Text;
            mascota.raza = txt_Raza.Text;
            mascota.edad = txt_Edad.Text;
            mascota.edad2 = cmb_Edad2.Text.ToString();
            mascota.sexo = cmb_Sexo.SelectedIndex.ToString();
            mascota.cliente_documento = txt_cedulacliente.Text;
              
            try
            {
                Controladores control = new Controladores();
                Registrar_Datos registrar_Datos = new Registrar_Datos();
                string respuesta = control.control_Registro_Mascota(mascota);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario registrado");
                    Menu_Recepcio recepcio = new Menu_Recepcio();
                    recepcio.Visible = true;
                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " holaaaa");
            }
        }

        private void btn_Registrar_Cliente_Click(object sender, EventArgs e)
        {
            Registro_Cliente registro_cliente = new Registro_Cliente();
            registro_cliente.Visible = true;
            this.Visible = false ;
        }
    }
}
