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
            Cliente_Repositorio cliente_repositorio = new Cliente_Repositorio();
            Cliente cliente = new Cliente();
            
            string cedula = txt_cedulacliente.Text;
            cliente = cliente_repositorio.Consulta_Documento_Cliente(cedula);
            if(cliente != null)
            {
                txt_Nombre_Cliente.Text = cliente.nombre;
                txt_Apellido_Cliente.Text = cliente.apellido;
            }
            else
            {
                MessageBox.Show("CLIENTE NO ENCONTRADO, POR FAVOR REALIZAR EL REGISTRO");
            }

        }

        private void btn_Registrar_Mascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();

         
            mascota.nombre = txt_Nombre.Text;
            mascota.especie = txt_Especie.Text;
            mascota.raza = txt_Raza.Text;
            mascota.edad = txt_Edad.Text;
            mascota.edad2 = cmb_Edad2.Text;
            mascota.sexo = cmb_Sexo.Text;
            mascota.cliente_documento = txt_cedulacliente.Text;

            try
            {
                Controladores control = new Controladores();
                string respuesta = control.Validacion_Mascota(mascota);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mascota registrada");
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

        private void btn_Registro_Cliente_Click(object sender, EventArgs e)
        {
           Registro_Cliente registro_Cliente = new Registro_Cliente();
            registro_Cliente.Visible = true;
            this.Visible=false;

        }

        private void txt_cedulacliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
