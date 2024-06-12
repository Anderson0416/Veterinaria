using Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class Producto_Repositorio
    {
        Conexion conexion = new Conexion();
        public bool Existencia_Producto(int ID)
        {
            MySqlDataReader reader;
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "SELECT ID FROM Productos where Id like @Id";

            MySqlCommand comando = new MySqlCommand(sql, conectar); ;
            comando.Parameters.AddWithValue("@Id", ID);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Registrar_Producto(Producto producto)
        {
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "INSERT INTO Productos ( Nombre, Descripcion, Precio, Cantidad )" +
                         "VALUES ( @Nombre, @Descripcion, @Precio, @Cantidad)";
            MySqlCommand comando = new MySqlCommand(sql, conectar);

            comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
            comando.Parameters.AddWithValue("@Precio", producto.Precio);
            comando.Parameters.AddWithValue("@Cantidad", producto.cantidad);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }
        public List<Producto> Consultar_Producto()
        {

            List<Producto> productos = new List<Producto>();


            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();
            MySqlDataReader reader;

            string sql = "SELECT Id, Nombre, " +
                " Precio, Cantidad, Descripcion FROM Productos";


            using (var comando = new MySqlCommand(sql, conectar))
            {
                using (reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        Producto producto = new Producto();
                        producto.Id = reader.GetInt32("Id");
                        producto.Nombre = reader.GetString("Nombre");
                        producto.cantidad = reader.GetInt32("Cantidad");
                        producto.Precio = reader.GetInt32("Precio");
                        producto.Descripcion = reader.GetString("Descripcion");
                        productos.Add(producto);

                    }
                }
            }
            conectar.Close();
            return productos;


        }

        public void Eliminar_Producto(int ID)
        {
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "DELETE FROM productos WHERE Id = @Id";

            MySqlCommand comando = new MySqlCommand(sql, conectar);


            comando.Parameters.AddWithValue("@Id", ID);

            int resultado = comando.ExecuteNonQuery();

        }
        public int Cantidad_Actual_Producto(int ID)
        {
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();
            MySqlDataReader reader;
            string sql = "SELECT Cantidad FROM Productos WHERE Id = @id";
            using (var comando = new MySqlCommand(sql, conectar))
            {
                comando.Parameters.AddWithValue("@id", ID);
                int Cantidad_Actual = Convert.ToInt32(comando.ExecuteScalar());
                return Cantidad_Actual;
            }
        }
        public void Actualizar_Cantidad_Resta_Producto(Producto producto)
        {
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();
            MySqlDataReader reader;
            string sql = "UPDATE Productos SET Cantidad = Cantidad - @cantidadComprada WHERE Id = @id";
            using (var comando = new MySqlCommand(sql, conectar))
            {
                comando.Parameters.AddWithValue("@cantidadComprada", producto.cantidad);
                comando.Parameters.AddWithValue("@id", producto.Id);
                comando.ExecuteNonQuery();
            }

        }
        public void Actualizar_Cantidad_Suma_Producto(Producto producto)
        {
            int cantidad_actual = Cantidad_Actual_Producto(producto.Id);
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();
            MySqlDataReader reader;
            string sql = "UPDATE Productos SET Cantidad = Cantidad + @cantidadComprada WHERE Id = @id";
            using (var comando = new MySqlCommand(sql, conectar))
            {
                comando.Parameters.AddWithValue("@cantidadComprada", producto.cantidad);
                comando.Parameters.AddWithValue("@id", producto.Id);
                comando.ExecuteNonQuery();
            }

        }
        public void Actualizar_Producto(Producto producto)
        {
            MySqlConnection conectar = conexion.crearConexion();

            conectar.Open();

            string sql = "UPDATE Productos SET Nombre = @Nombre, Descripcion = @Descripcion, " +
            "Precio = @Precio, Cantidad = @Cantidad WHERE Id = @Id";

            MySqlCommand comando = new MySqlCommand(sql, conectar);

            comando.Parameters.AddWithValue("@Id", producto.Id);
            comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
            comando.Parameters.AddWithValue("@Precio", producto.Precio);
            comando.Parameters.AddWithValue("@Cantidad", producto.cantidad);


            int resultado = comando.ExecuteNonQuery();

            if (resultado > 0)

            {
                Console.WriteLine("Producto actualizado correctamente.");
            }
            else
            {
                Console.WriteLine("No se encontró el Producto con el ID especificado.");
            }
        }
    }
    }
   
