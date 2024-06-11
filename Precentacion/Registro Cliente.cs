using BLL;
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
    public partial class Registro_Cliente : Form
    {
        public Registro_Cliente()
        {
            InitializeComponent();
        }

        private void btn_Registro_Cliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.documento = txt_Numero_Documento.Text;
            cliente.tipo_documento = cmb_Tipo_Documento.Text;
            cliente.nombre = txt_Nombre.Text;
            cliente.apellido = txt_Apellido.Text;
            cliente.sexo = cmb_Sexo.Text;
            cliente.fecha_nacimiento = dtp_Fecha.Text;
            cliente.telefono = txt_Telefono.Text;


            try
            {
                Controladores control = new Controladores();
                string respuesta = control.Validacion_Cliente(cliente);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cliente registrado");
                    Menu_Recepcion recepcio = new Menu_Recepcion();
                    recepcio.Visible = true;
                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " holaaaa");
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void cmb_Tipo_Documento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cmb_Sexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
        
            this.Visible = false;
        }
    }
}
