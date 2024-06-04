using Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Veterinario_Repositorio
    {
        Conexion conexion = new Conexion();
        public int Registrar_Veterinario(Veterinario veterinario)
        {
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "INSERT INTO Veterinarios ( Nombre, Apellido, Tipo_Documento, Documento, Sexo, Fecha_Nacimiento, Telefono, Fecha_Contrato )" +
                         "VALUES ( @Nombre, @Apellido, @Tipo_Documento, @Documento, @Sexo, @Fecha_Nacimiento, @Telefono, @Fecha_Contrato )";
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
        public bool Existencia_Veterinario(string documento)
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
        public List<Veterinario> ObtenerVeterinarios()
        {
            List<Veterinario> veterinarios = new List<Veterinario>();
            
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();
            MySqlDataReader reader;

            string sql = "SELECT Id, Nombre, Apellido, Tipo_Documento, Documento, Sexo, Fecha_Nacimiento," +
                " Telefono, Fecha_Contrato FROM Veterinarios";
                using (var comando = new MySqlCommand(sql, conectar))
                {
                    using ( reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                        Veterinario veterinario = new Veterinario();
                        veterinario.id = reader.GetInt32("Id");
                        veterinario.nombre = reader.GetString("Nombre");
                        veterinario.apellido = reader.GetString("Apellido");
                        veterinario.tipo_documento = reader.GetString("Tipo_Documento");
                        veterinario.documento = reader.GetString("Documento");
                        veterinario.sexo = reader.GetString("Sexo");
                        veterinario.fecha_nacimiento = reader.GetString("Fecha_Nacimiento");
                        veterinario.telefono = reader.GetString("Telefono");
                        veterinario.fecha_contrato = reader.GetString("Fecha_Contrato");
                        veterinarios.Add(veterinario);
                        }
                     }
                }
            conectar.Close();
            return veterinarios;
        }
        public Veterinario Consulta_Documento_Veterinario(string documento)
        {
            Veterinario veterinario = new Veterinario();
            MySqlDataReader reader;
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "SELECT Nombre, Apellido, Tipo_Documento, Documento, Sexo, Fecha_Nacimiento, Fecha_Contrato " +
             "FROM Veterinarios WHERE Documento LIKE @Documento";

            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@Documento", documento);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    veterinario.nombre = reader.GetString(0);
                    veterinario.apellido = reader.GetString(1);
                    veterinario.tipo_documento = reader.GetString(2);
                    veterinario.documento = reader.GetString(3);
                    veterinario.sexo = reader.GetString(4);
                    veterinario.fecha_nacimiento = reader.GetString(5);
                    veterinario.fecha_contrato = reader.GetString(6);
                }
            }
            return veterinario;
        }
        public void Eliminar_Veterinario(string documento)
        {
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "DELETE FROM veterinarios WHERE (Documento) = @Documento";

            MySqlCommand comando = new MySqlCommand(sql, conectar);


            comando.Parameters.AddWithValue("@Documento", documento);

            int resultado = comando.ExecuteNonQuery();

        }
        public void Actualizar_Veterinario(Veterinario veterinario)
        {
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "UPDATE Veterinarios SET Nombre = @Nombre, Apellido = @Apellido, Tipo_Documento = @Tipo_Documento" +
                ", Documento = @Documento, Sexo = @Sexo, Fecha_Nacimiento = @Fecha_Nacimiento, Telefono = @Telefono," +
                " Fecha_Contrato = @Fecha_Contrato  WHERE Id = @Id";

            MySqlCommand comando = new MySqlCommand(sql, conectar);

            comando.Parameters.AddWithValue("@Id", veterinario.id);
            comando.Parameters.AddWithValue("@Nombre", veterinario.nombre);
            comando.Parameters.AddWithValue("@Apellido", veterinario.apellido);
            comando.Parameters.AddWithValue("@Tipo_Documento", veterinario.tipo_documento);
            comando.Parameters.AddWithValue("@Documento", veterinario.documento);
            comando.Parameters.AddWithValue("@Sexo", veterinario.sexo);
            comando.Parameters.AddWithValue("@Fecha_Nacimiento", veterinario.fecha_nacimiento);
            comando.Parameters.AddWithValue("@Telefono", veterinario.telefono);
            comando.Parameters.AddWithValue("@Fecha_Contrato", veterinario.fecha_contrato);

            int resultado = comando.ExecuteNonQuery();

            if (resultado > 0)
            {
                Console.WriteLine("Veterinario actualizado correctamente.");
            }
            else
            {
                Console.WriteLine("No se encontró el Veterinario con el ID especificado.");
            }
        }
    }
}
