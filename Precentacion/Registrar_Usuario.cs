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
    public partial class Registrar_Usuario : Form
    {
        public Registrar_Usuario()
        {
            InitializeComponent();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.Cedula = txt_Numero_Documento.Text;
            usuario.tipo_documento = cmb_Tipo_Documento.Text.ToString();
            usuario.nombre = txt_Nombre.Text;
            usuario.apellido = txt_Apellido.Text;
            usuario.sexo = cmb_Sexo.SelectedIndex.ToString();
            usuario.fecha_nacimiento = dtp_Fecha.Text;
            usuario.password = txt_Contraseña.Text;
            usuario.conpassword = txt_Confirmar_Contraseña.Text;

            try
            {
                Controladores control = new Controladores();
                string respuesta = control.control_Registro(usuario);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario registrado");
                    Login login = new Login();
                    login.Visible = true;
                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " holaaaa");
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            this.Visible = false;
        }
    }
}
