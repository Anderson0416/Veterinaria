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

            string sql = "INSERT INTO Productos ( Nombre, Descripcion, Precio )" +
                         "VALUES ( @Nombre, @Descripcion, @Precio)";
            MySqlCommand comando = new MySqlCommand(sql, conectar);

            comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
            comando.Parameters.AddWithValue("@Precio", producto.Precio);


            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }
        public List<Producto> Consultar_Producto()
        {

            List<Producto> productos = new List<Producto>();
            

                MySqlConnection conectar = conexion.crearConexion();
                conectar.Open();
                MySqlDataReader reader;

                string sql = "SELECT Id, Precio, " +
                    " Nombre, Descripcion FROM Productos";


                using (var comando = new MySqlCommand(sql, conectar))
                {
                    using (reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            Producto producto = new Producto();
                            producto.Id = reader.GetInt32("Id");
                            producto.Nombre = reader.GetString("Nombre");
                            producto.Descripcion = reader.GetString("Descripcion");
                            producto.Precio = reader.GetInt32("Precio");
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

        public void Actualizar_Producto(Producto producto)
        {
            MySqlConnection conectar = conexion.crearConexion() ;
            
                conectar.Open();

            string sql = "UPDATE Productos SET Nombre = @Nombre, Descripcion = @Descripcion, " +
            "Precio = @Precio WHERE Id = @Id";

            MySqlCommand comando = new MySqlCommand(sql, conectar) ;

                comando.Parameters.AddWithValue("@Id", producto.Id);
                comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                comando.Parameters.AddWithValue("@Precio", producto.Precio);

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
   
