using Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Registrar_Datos
    {
        Conexion conexion = new Conexion();
        public int Registrar_Usuario(Usuarios usuario)
        {
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "INSERT INTO usuarios ( Nombre, Contraseña)" +
                         "VALUES ( @Nombre, @Contraseña)";
            MySqlCommand comando = new MySqlCommand(sql, conectar);

            comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
            
            
            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }
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
        public int Registrar_Mascota(Mascota mascota)
        {
            
            using (var conectar = conexion.crearConexion())
            {
                conectar.Open();

                string sql = "INSERT INTO Mascotas (Nombre, Especie, Raza, Sexo, Edad, Edad2, Cliente_Documento) " +
                             "VALUES (@Nombre, @Especie, @Raza, @Sexo, @Edad, @Edad2, @Cliente_Documento)";
                MySqlCommand comando = new MySqlCommand(sql, conectar);

                comando.Parameters.AddWithValue("@Nombre", mascota.nombre_mascota);
                comando.Parameters.AddWithValue("@Especie", mascota.especie);
                comando.Parameters.AddWithValue("@Raza", mascota.raza);
                comando.Parameters.AddWithValue("@Sexo", mascota.sexo);
                comando.Parameters.AddWithValue("@Edad", mascota.edad);
                comando.Parameters.AddWithValue("@Edad2", mascota.edad2);
                comando.Parameters.AddWithValue("@Cliente_Documento",mascota.cliente_documento);

                int resultado = comando.ExecuteNonQuery();

                return resultado;
            }
        }
        public int Registrar_Veterinario(Veterinario veterinario)
        {
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "INSERT INTO Veterinarios ( Nombre, Apellido, Tipo_Documento, Documento, Sexo, Fecha_Nacimiento, Telefono, Fecha_Contrato )" +
                         "VALUES ( @Nombre, @Apellido, @Tipo_Documento, @Documento, @Sexo, @Fecha_Nacimiento, @Telefono, Fecha_Contrato )";
            MySqlCommand comando = new MySqlCommand(sql, conectar);

            comando.Parameters.AddWithValue("@Nombre", veterinario.nombre);
            comando.Parameters.AddWithValue("@Apellido", veterinario.apellido);
            comando.Parameters.AddWithValue("@Tipo_Documento", veterinario.tipo_documento);
            comando.Parameters.AddWithValue("@Documento", veterinario.documento);
            comando.Parameters.AddWithValue("@Sexo", veterinario.sexo);
            comando.Parameters.AddWithValue("@Fecha_Nacimiento", veterinario.fecha_nacimiento);
            comando.Parameters.AddWithValue("@Telefono", veterinario.telefono);
            comando.Parameters.AddWithValue("@Fecha_Contrato", veterinario.fecha_contrato);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }
        /********************************************************************************/
        public bool existeciaUsuario(string nombre)
        {
            MySqlDataReader reader;
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "SELECT ID FROM Usuarios where Nombre like @Nombre";

            MySqlCommand comando = new MySqlCommand(sql, conectar); ;
            comando.Parameters.AddWithValue("@Nombre", nombre);

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
        public bool control_Veterinario(string documento)
        {
            MySqlDataReader reader;
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "SELECT ID FROM Veterinarios where Documento like @Documento";

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
        public bool control_CLiente(string documento)
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

        public Cliente existeciaCliente(string Cedula)
        {
            Cliente cliente = new Cliente();
            MySqlDataReader reader;
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "SELECT Nombre, Apellido FROM Clientes where Documento like @Documento";

            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@Documento", Cedula);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cliente.nombre = reader.GetString(0);
                    cliente.apellido = reader.GetString(1);
                }
                return cliente;
            }
            else
            {
                return cliente;
            }
        }

        public Usuarios ConsultaUsuario(string Nombre)
        {
            MySqlDataReader reader;
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "SELECT ID, Contraseña, Nombre FROM Usuarios where Nombre like @Nombre";

            MySqlCommand comando = new MySqlCommand(sql, conectar); ;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            reader = comando.ExecuteReader();

            Usuarios usuarios = null;
            while (reader.Read())
            {
                usuarios = new Usuarios();

                usuarios.Nombre = reader["Nombre"].ToString();
                usuarios.Contraseña = reader["Contraseña"].ToString();
            }
            return usuarios;
        }


        public List<Cliente> Obtener_Clientes_Mascotas()
        {
            var clientes = new List<Cliente>();

            using (var conectar = conexion.crearConexion())
            {
                conectar.Open();
                var command = new MySqlCommand("SELECT c.Nombre, c.Apellido, c.Tipo_Documento, c.Documento, c.Sexo, c.Fecha_Nacimiento, c.Telefono" +
                    " m.Nombre AS MascotaNombre, m.Especie, m.Raza, m.Sexo, m.Edad, m.Edad2" +
                    " FROM Clientes c LEFT JOIN Mascotas m ON c.Documento = m.Cliente_Documento", conectar);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var Documento = reader.GetString("Documento");
                        var cliente = clientes.FirstOrDefault(c => c.documento == Documento);

                        if (cliente == null)
                        {
                            cliente = new Cliente
                            {
                                nombre = reader.GetString("Nombre"),
                                apellido = reader.GetString("Apellido"),
                                tipo_documento = reader.GetString("Tipo_Documento"),
                                documento = reader.GetString("Documento"),
                                sexo = reader.GetString("Sexo"),
                                fecha_nacimiento = reader.GetString("Fecha_Nacimiento"),
                                telefono = reader.GetString("Telefono"),
                            };
                            clientes.Add(cliente);
                        }

                        if (!reader.IsDBNull(reader.GetOrdinal("MascotaID")))
                        {
                            cliente.lista_mascotas.Add(new Mascota
                            {

                                nombre_mascota = reader.GetString("MascotaNombre"),
                                especie = reader.GetString("Especie"),
                                raza = reader.GetString("Raza"),
                                sexo = reader.GetString("Sexo"),
                                edad = reader.GetString("Edad"),
                                edad2 = reader.GetString("Edad2"),
                                cliente_documento = Documento
                            });
                        }
                    }
                }
            }

            return clientes;
        }
    }
}
