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
    public partial class Compra : Form
    {
        DataTable tabla;
        public Compra()
        {
            InitializeComponent();
            Llenar_dgv_Productos();
            Titulos_dgv_Compra();
        }

        private void Llenar_dgv_Productos()
        {

            Producto_Repositorio producto_Repositorio = new Producto_Repositorio();
            List<Producto> producto = producto_Repositorio.Consultar_Producto();

            dgv_Productos.DataSource = producto;
            dgv_Productos.Columns[0].HeaderText = "Id";
            dgv_Productos.Columns[1].HeaderText = "Nombre";
            dgv_Productos.Columns[2].HeaderText = "Precio";
            dgv_Productos.Columns[3].HeaderText = "Cantidad";
            dgv_Productos.Columns[4].HeaderText = "Descripcion";

        }
        private void Titulos_dgv_Compra()
        {
            tabla = new DataTable();
            tabla.Columns.Add("ID");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Cantidad");
            tabla.Columns.Add("Precio");
            dgv_Compra.DataSource = tabla;
        }
        private void Lennar_dgv_compra()
        {
            int respuesta = Restar_Cantidad_Producto();
            if (respuesta == 1)
            {
                DataRow row = tabla.NewRow();
                row["Id"] = txt_ID.Text;
                row["Nombre"] = txt_Nombre.Text;
                row["Cantidad"] = txt_Cantidad.Text;
                row["Precio"] = Calcular_Precio();
                tabla.Rows.Add(row);
            }
            else if (respuesta == 2)
            {
                MessageBox.Show("Cantidad de " + txt_Nombre.Text + " insuficiente");
            }

        }
        private int Calcular_Precio()
        {
            Servicios_Productos servicios_Productos = new Servicios_Productos();
            int cantidad = int.Parse(txt_Cantidad.Text);
            int precio = int.Parse(txt_Precio.Text);
            int total = servicios_Productos.Calcular_Precio(precio, cantidad);
            return total;
        }
        private void limpiar ()
        {
            txt_ID.Clear();
            txt_Nombre.Clear();
            txt_Precio.Clear();
            txt_Cantidad.Clear();
            rtb_Descripcion.Clear();
        }
        private int Restar_Cantidad_Producto()
        {
            if (string.IsNullOrEmpty(txt_ID.Text) || string.IsNullOrEmpty(txt_Cantidad.Text))
            {
                return 2;
            }

            Servicios_Productos servicios_Productos = new Servicios_Productos();
            Producto producto = new Producto
            {
                Id = int.Parse(txt_ID.Text),
                cantidad = int.Parse(txt_Cantidad.Text)
            };

            bool exito = servicios_Productos.Calcular_Resta_Cantidad(producto);
            return exito ? 1 : 2;

        }
        private void Sumar_Cantidad_PRoducto(int rowIndex)
        {
            DataGridViewRow selectedRow = dgv_Compra.Rows[rowIndex];
            int productoId = int.Parse(selectedRow.Cells[0].Value.ToString());
            int cantidadProducto = int.Parse(selectedRow.Cells[2].Value.ToString());
            Producto producto = new Producto
            {
                Id = productoId,
                cantidad = cantidadProducto
            };
            Servicios_Productos servicios_Productos = new Servicios_Productos();
            servicios_Productos.Calcular_Suma_Cantidad(producto);
        }

        private void dgv_Productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dgv_Productos.SelectedCells[0].Value.ToString();
            txt_Nombre.Text = dgv_Productos.SelectedCells[1].Value.ToString();
            rtb_Descripcion.Text = dgv_Productos.SelectedCells[4].Value.ToString();
            txt_Precio.Text = dgv_Productos.SelectedCells[2].Value.ToString();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Lennar_dgv_compra();
            limpiar();
            Llenar_dgv_Productos();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Compra.SelectedCells.Count > 0)
            {
                int rowIndex = dgv_Compra.SelectedCells[0].RowIndex;

                if (rowIndex >= 0)
                {
                    Sumar_Cantidad_PRoducto(rowIndex);

                    DataRow row = tabla.Rows[rowIndex];
                    row.Delete();

                    tabla.AcceptChanges();
                    dgv_Compra.DataSource = tabla; 

                    Llenar_dgv_Productos();
                }
            }
        }
    }
}
