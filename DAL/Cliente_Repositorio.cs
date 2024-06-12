using Entity;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class Cliente_Repositorio
    {
        Conexion conexion = new Conexion();
        public int Registrar_Cliente(Cliente cliente)
        {
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "INSERT INTO Clientes ( Nombre, Apellido, Tipo_Documento, Documento, Sexo, Fecha_Nacimiento, Telefono )" +
                         "VALUES ( @Nombre, @Apellido, @Tipo_Documento, @Documento, @Sexo, @Fecha_Nacimiento, @Telefono)";
            MySqlCommand comando = new MySqlCommand(sql, conectar);

            comando.Parameters.AddWithValue("@Nombre", cliente.nombre);
            comando.Parameters.AddWithValue("@Apellido", cliente.apellido);
            comando.Parameters.AddWithValue("@Tipo_Documento", cliente.tipo_documento);
            comando.Parameters.AddWithValue("@Documento", cliente.documento);
            comando.Parameters.AddWithValue("@Sexo", cliente.sexo);
            comando.Parameters.AddWithValue("@Fecha_Nacimiento", cliente.fecha_nacimiento);
            comando.Parameters.AddWithValue("@Telefono", cliente.telefono);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }
        public bool Existencia_CLiente(string documento)
        {
            MySqlDataReader reader;
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "SELECT ID FROM Clientes where Documento like @Documento";

            MySqlCommand comando = new MySqlCommand(sql, conectar); ;
            comando.Parameters.AddWithValue("@Documento", documento);

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
        public Cliente Consulta_Documento_Cliente(string documento)
        {
            Cliente cliente = new Cliente();
            MySqlDataReader reader;
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "SELECT Nombre, Apellido, Tipo_Documento, Documento, Sexo, Fecha_Nacimiento " +
             "FROM Clientes WHERE Documento LIKE @Documento";

            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@Documento", documento);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cliente.nombre = reader.GetString(0);
                    cliente.apellido = reader.GetString(1);
                    cliente.tipo_documento = reader.GetString(2);
                    cliente.documento = reader.GetString(3);
                    cliente.sexo = reader.GetString(4);
                    cliente.fecha_nacimiento = reader.GetString(5);
                }
                return cliente;
            }
            else
            {
                return cliente;
            }
        }
        public List<Cliente> Consultar_Todos_Cliente()
        {
            List<Cliente> clientes = new List<Cliente>();


            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();
            MySqlDataReader reader;

            string sql = "SELECT Id, Nombre, Apellido, Tipo_Documento, Documento, Sexo, Fecha_Nacimiento," +
                " Telefono FROM Clientes";

            using (var comando = new MySqlCommand(sql, conectar))
            {
                using (reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.id = reader.GetInt32("Id");
                        cliente.nombre = reader.GetString("Nombre");
                        cliente.apellido = reader.GetString("Apellido");
                        cliente.tipo_documento = reader.GetString("Tipo_Documento");
                        cliente.documento = reader.GetString("Documento");
                        cliente.sexo = reader.GetString("Sexo");
                        cliente.fecha_nacimiento = reader.GetString("Fecha_Nacimiento");
                        cliente.telefono = reader.GetString("Telefono");
                        clientes.Add(cliente);
                    }

                }
            }
            conectar.Close();
            return clientes;
        }
        public void Eliminar_Cliente (string documento)
        {
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "DELETE FROM clientes WHERE (Documento) = @Documento";

            MySqlCommand comando = new MySqlCommand(sql, conectar);
           

            comando.Parameters.AddWithValue("@Documento", documento);

            int resultado = comando.ExecuteNonQuery();

        }
        public void Actualizar_Cliente(Cliente cliente)
        {
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "UPDATE Clientes SET Nombre = @Nombre, Apellido = @Apellido, Tipo_Documento = @Tipo_Documento, " +
                 "Documento = @Documento, Sexo = @Sexo, Fecha_Nacimiento = @Fecha_Nacimiento, Telefono = @Telefono " +
                 "WHERE Id = @Id";

            MySqlCommand comando = new MySqlCommand(sql, conectar);

            comando.Parameters.AddWithValue("@Id", cliente.id);
            comando.Parameters.AddWithValue("@Nombre", cliente.nombre);
            comando.Parameters.AddWithValue("@Apellido", cliente.apellido);
            comando.Parameters.AddWithValue("@Tipo_Documento", cliente.tipo_documento);
            comando.Parameters.AddWithValue("@Documento", cliente.documento);
            comando.Parameters.AddWithValue("@Sexo", cliente.sexo);
            comando.Parameters.AddWithValue("@Fecha_Nacimiento", cliente.fecha_nacimiento);
            comando.Parameters.AddWithValue("@Telefono", cliente.telefono);

            int resultado = comando.ExecuteNonQuery();

            if (resultado > 0)
             
                {
                    Console.WriteLine("Cliente actualizado correctamente.");
                }
                else
                {
                    Console.WriteLine("No se encontró el cliente con el ID especificado.");
                }
        }
    }
}



