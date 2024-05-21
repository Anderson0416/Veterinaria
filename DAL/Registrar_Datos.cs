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
        public int Registrar_Usuario(Persona usuario)
        {
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "INSERT INTO usuarios ( Cedula, Nombre, Apellido, Sexo, Fecha_Nacimiento, Password, id_tipo,Tipo_Documento)" +
                         "VALUES ( @Cedula, @Nombre, @Apellido, @Sexo, @Fecha_Nacimiento, @Password, @id_tipo, @Tipo_Documento)";
            MySqlCommand comando = new MySqlCommand(sql, conectar);

            comando.Parameters.AddWithValue("@Cedula", usuario.Cedula);
            comando.Parameters.AddWithValue("@Tipo_Documento", usuario.tipo_documento);
            comando.Parameters.AddWithValue("@Nombre", usuario.nombre);
            comando.Parameters.AddWithValue("@Apellido", usuario.apellido);
            comando.Parameters.AddWithValue("@Sexo", usuario.sexo);
            comando.Parameters.AddWithValue("@Fecha_Nacimiento", usuario.fecha_nacimiento);
            comando.Parameters.AddWithValue("@Password", usuario.password);
            comando.Parameters.AddWithValue("@id_tipo", 1);
            
            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }
        public int Registrar_Cliente(Cliente cliente)
        {
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "INSERT INTO cliente ( Nombre, Apellido, Tipo_Documento, Documento, Sexo, Fecha_Nacimiento, Telefono )" +
                         "VALUES ( @Nombre, @Apellido, @Tipo_Documento, @Documento, @Sexo, @Fecha_Nacimiento, @Telefono)";
            MySqlCommand comando = new MySqlCommand(sql, conectar);

            comando.Parameters.AddWithValue("@Nombre", cliente.nombre);
            comando.Parameters.AddWithValue("@Apellido", cliente.apellido);
            comando.Parameters.AddWithValue("@Tipo_Documento", cliente.tipo_documento);
            comando.Parameters.AddWithValue("@Documento", cliente.Cedula);
            comando.Parameters.AddWithValue("@Sexo", cliente.sexo);
            comando.Parameters.AddWithValue("@Fecha_Nacimiento", cliente.fecha_nacimiento);
            comando.Parameters.AddWithValue("@Telefono", cliente.telefono);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }
        public int Registrar_Mascota(Mascota mascota)
        {
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "INSERT INTO mascota ( Codigo, Nombre, Especie, Raza, Peso, Sexo, Edad, Edad2,Codigo_Cliente )" +
                         "VALUES ( @Codigo, @Nombre, @Especie, @Raza, @Peso, @Sexo, @Edad, @Edad2, @cliente_id)";
            MySqlCommand comando = new MySqlCommand(sql, conectar);

            comando.Parameters.AddWithValue("@Codigo", mascota.Codigo);
            comando.Parameters.AddWithValue("@Nombre", mascota.nombre_mascota);
            comando.Parameters.AddWithValue("@Especie", mascota.especie);
            comando.Parameters.AddWithValue("@Raza", mascota.raza);
            comando.Parameters.AddWithValue("@Peso", mascota.Peso);
            comando.Parameters.AddWithValue("@Sexo", mascota.sexo);
            comando.Parameters.AddWithValue("@Edad", mascota.edad);
            comando.Parameters.AddWithValue("@Edad2", mascota.edad2);
            comando.Parameters.AddWithValue("@cliente_id", mascota.codigo_cliente);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }
        public int Registrar_Veterinario(Veterinario veterinario)
        {
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "INSERT INTO cliente ( Nombre, Apellido, Tipo_Documento, Documento, Sexo, Fecha_Nacimiento, Telefono, Fecha_Contrato )" +
                         "VALUES ( @Nombre, @Apellido, @Tipo_Documento, @Documento, @Sexo, @Fecha_Nacimiento, @Telefono, Fecha_Contrato )";
            MySqlCommand comando = new MySqlCommand(sql, conectar);

            comando.Parameters.AddWithValue("@Nombre", veterinario.nombre);
            comando.Parameters.AddWithValue("@Apellido", veterinario.apellido);
            comando.Parameters.AddWithValue("@Tipo_Documento", veterinario.tipo_documento);
            comando.Parameters.AddWithValue("@Documento", veterinario.Cedula);
            comando.Parameters.AddWithValue("@Sexo", veterinario.sexo);
            comando.Parameters.AddWithValue("@Fecha_Nacimiento", veterinario.fecha_nacimiento);
            comando.Parameters.AddWithValue("@Telefono", veterinario.telefono);
            comando.Parameters.AddWithValue("@Fecha_Contrato", veterinario.fecha_contrato);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }
        public bool existeciaCedula(string Cedula)
        {
            MySqlDataReader reader;
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "SELECT ID FROM usuarios where Cedula like @Cedula";

            MySqlCommand comando = new MySqlCommand(sql, conectar); ;
            comando.Parameters.AddWithValue("@Cedula", Cedula);

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

            string sql = "SELECT Nombre, Apellido FROM cliente where Documento like @Documento";

            MySqlCommand comando = new MySqlCommand(sql, conectar); ;
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
                return null;
            }
        }

        public Persona ConsultaUsuario(string Nombre)
        {
            MySqlDataReader reader;
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "SELECT ID, Password, Nombre, id_tipo FROM usuarios where Nombre like @Nombre";

            MySqlCommand comando = new MySqlCommand(sql, conectar); ;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            reader = comando.ExecuteReader();

            Persona usuarios = null;
            while (reader.Read())
            {
                usuarios = new Persona();
                usuarios.id = int.Parse(reader["id"].ToString());
                usuarios.password = reader["Password"].ToString();
                usuarios.nombre = reader["Nombre"].ToString();
                usuarios.id_tipo = int.Parse(reader["id_tipo"].ToString());
            }
            return usuarios;
        }

    }
}
