using Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Registrar_Datos
    {
        Conexion conexion = new Conexion();
        public int Registrar_datos(Usuario usuario)
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
        public Usuario ConsultaUsuario(string Nombre)
        {
            MySqlDataReader reader;
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "SELECT ID, Password, Nombre, id_tipo FROM usuarios where Nombre like @Nombre";

            MySqlCommand comando = new MySqlCommand(sql, conectar); ;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            reader = comando.ExecuteReader();

            Usuario usuarios = null;
            while (reader.Read())
            {
                usuarios = new Usuario();
                usuarios.id = int.Parse(reader["id"].ToString());
                usuarios.password = reader["Password"].ToString();
                usuarios.nombre = reader["Nombre"].ToString();
                usuarios.id_tipo = int.Parse(reader["id_tipo"].ToString());
            }
            return usuarios;
        }
    }
}
