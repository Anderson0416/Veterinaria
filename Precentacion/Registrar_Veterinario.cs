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
    public partial class Registrar_Veterinario : Form
    {
        public Registrar_Veterinario()
        {
            InitializeComponent();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Veterinario veterinario = new Veterinario();

            veterinario.documento = txt_Numero_Documento.Text;
            veterinario.tipo_documento = cmb_Tipo_Documento.Text.ToString();
            veterinario.nombre = txt_Nombre.Text;
            veterinario.apellido = txt_Apellido.Text;
            veterinario.sexo = cmb_Sexo.SelectedIndex.ToString();
            veterinario.fecha_nacimiento = dtp_Fecha_Nacimiento.Text;
            veterinario.fecha_contrato = dtp_Fecha_Contrato.Text;
            veterinario.telefono = txt_Telefono.Text;


            try
            {
                Controladores control = new Controladores();
                string respuesta = control.control_Registro_Veterinario(veterinario);
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
    }
}
