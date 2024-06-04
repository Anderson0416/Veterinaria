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
    public class Cita_Repositorio
    {
        Conexion conexion = new Conexion();
        public int Registrar_Cita(Citas cita)
        {
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "INSERT INTO Citas ( Fecha_Consulta, Descripcion, Documento_Veterinario, Id_Mascota )" +
                         "VALUES ( @Fecha_Consulta, @Descripcion, @Documento_Veterinario, @Id_Mascota)";
            MySqlCommand comando = new MySqlCommand(sql, conectar);

            comando.Parameters.AddWithValue("@Fecha_Consulta", cita.fecha_consulta);
            comando.Parameters.AddWithValue("@Descripcion", cita.descripcion);
            comando.Parameters.AddWithValue("@Documento_Veterinario", cita.documento_veterinario);
            comando.Parameters.AddWithValue("@Id_Mascota", cita.id_mascota);
           
            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }
        public List<Citas> Consultar_Citas_Veterinario(string documento)
        {
            List<Citas> Citas = new List<Citas>();

            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();
            MySqlDataReader reader;

            string sql = "SELECT Id, Fecha_Consulta, Descripcion, Id_Mascota" +
                " FROM citas WHERE Documento_Veterinario LIKE @Documento_Veterinario";

            using (var comando = new MySqlCommand(sql, conectar))
            {
                comando.Parameters.AddWithValue("@Documento_Veterinario", documento);
                using (reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Citas citas = new Citas();
                        citas.id = reader.GetInt32("Id");
                        citas.descripcion = reader.GetString("Descripcion");
                        citas.id_mascota = reader.GetInt16("Id_Mascota");
                        citas.fecha_consulta = reader.GetString("Fecha_Consulta");
                        Citas.Add(citas);
                    }

                }
            }
            conectar.Close();
            return Citas;
        }
    }
}
