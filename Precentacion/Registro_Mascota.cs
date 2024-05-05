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
    public partial class Registro_Mascota : Form
    {
        public Registro_Mascota()
        {
            InitializeComponent();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Registrar_Mascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            Cliente cliente = new Cliente();
            
            mascota.Codigo = txt_Codigo.Text;
            mascota.nombre_mascota = txt_Nombre_Mascota.Text;
            mascota.especie = txt_Especie.Text;
            mascota.raza = txt_Raza.Text;
            mascota.Peso = txt_Peso.Text;
            mascota.edad = txt_Edad.Text;
            mascota.edad2 = txt_Edad2.Text;
            mascota.sexo = cmb_Sexo.SelectedIndex.ToString();
              
            try
            {
                Controladores control = new Controladores();
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
    }
}
