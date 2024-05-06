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

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.Cedula = txt_Numero_Documento.Text;
            cliente.tipo_documento = cmb_Tipo_Documento.Text.ToString();
            cliente.nombre = txt_Nombre.Text;
            cliente.apellido = txt_Apellido.Text;
            cliente.sexo = cmb_Sexo.SelectedIndex.ToString();
            cliente.fecha_nacimiento = dtp_Fecha.Text;
            cliente.telefono = txt_Telefono.Text;
            

            try
            {
                Controladores control = new Controladores();
                string respuesta = control.control_Registro_Cliente(cliente);
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
