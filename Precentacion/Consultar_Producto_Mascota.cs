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
    public partial class Consultar_Producto_Mascota : Form
    {
        public Consultar_Producto_Mascota()
        {
            InitializeComponent();
            LlenarDataGribView_Producto_Mascota();
        }

        private void LlenarDataGribView_Producto_Mascota()
        {

            Producto_Repositorio producto_Repositorio = new Producto_Repositorio();
            List<Producto> producto = producto_Repositorio.Consultar_Producto();

            dgv_Producto_Mascota.DataSource = producto;
            dgv_Producto_Mascota.Columns[0].HeaderText = "Id";
            dgv_Producto_Mascota.Columns[1].HeaderText = "Nombre";
            dgv_Producto_Mascota.Columns[2].HeaderText = "Precio";
            dgv_Producto_Mascota.Columns[3].HeaderText = "Cantidad";
            dgv_Producto_Mascota.Columns[4].HeaderText = "Descripcion";

        }
        private void dgv_Producto_Mascota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dgv_Producto_Mascota.SelectedCells[0].Value.ToString();
            txt_Nombre.Text = dgv_Producto_Mascota.SelectedCells[1].Value.ToString();
            rtb_Descripcion.Text = dgv_Producto_Mascota.SelectedCells[4].Value.ToString();
            txt_Precio.Text = dgv_Producto_Mascota.SelectedCells[2].Value.ToString();
            txt_Cantidad.Text = dgv_Producto_Mascota.SelectedCells[3].Value.ToString();

        }
        private void btn_Eliminar_Producto_Click_1(object sender, EventArgs e)
        {
            int Id = int.Parse(txt_ID.Text);

            Producto_Repositorio producto_Repositorio = new Producto_Repositorio();
            producto_Repositorio.Eliminar_Producto(Id);
            LlenarDataGribView_Producto_Mascota();
        }

        private void btn_Actualizar_Producto_Click_1(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            producto.Id = int.Parse(txt_ID.Text);
            producto.Nombre = txt_Nombre.Text;
            producto.Descripcion = rtb_Descripcion.Text;
            producto.Precio = int.Parse(txt_Precio.Text);
            producto.cantidad = int.Parse(txt_Cantidad.Text);

            Producto_Repositorio producto_Repositorio = new Producto_Repositorio();
            producto_Repositorio.Actualizar_Producto(producto);
            LlenarDataGribView_Producto_Mascota();




        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
          
            this.Visible = false;
        }
    }
    }
