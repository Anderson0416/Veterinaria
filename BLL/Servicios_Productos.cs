using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Servicios_Productos
    {
        public int Calcular_Precio(int precio, int cantidad)
        {
            int Total=0;
            if(cantidad != 0)
            {
                Total = precio * cantidad;
            }
            return Total;
        }
        public bool Calcular_Resta_Cantidad (Producto producto)
        {
            Producto_Repositorio producto_Repositorio = new Producto_Repositorio();
            int cantidad_actual = producto_Repositorio.Cantidad_Actual_Producto(producto.Id);
            if (cantidad_actual >= producto.cantidad)
            {
                producto_Repositorio.Actualizar_Cantidad_Resta_Producto(producto);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Calcular_Suma_Cantidad(Producto producto)
        {
            Producto_Repositorio producto_Repositorio = new Producto_Repositorio();
            producto_Repositorio.Actualizar_Cantidad_Suma_Producto(producto);

        }
    }
}
