using Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Usuario_Repositorio
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
        public bool Existecia_Usuario(string nombre)
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
    }
}
