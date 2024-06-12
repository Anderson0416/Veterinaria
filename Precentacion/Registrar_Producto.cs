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
    public partial class Registrar_Producto : Form
    {
        public Registrar_Producto()
        {
            InitializeComponent();
        }


        private void Registrar_Producto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
         
            producto.Nombre = txt_Nombre.Text;
            producto.Descripcion = rtb_Descripcion.Text;
            producto.Precio =int.Parse(txt_Precio.Text);
            producto.cantidad = int.Parse(txt_Cantidad.Text);


            try
            {
                Controladores control = new Controladores();
                string respuesta = control.Validacion_Producto(producto);   
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Producto registrado");

                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " holaaaa");
            }

        }

        private void Registrar_Producto_Load(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
    }

