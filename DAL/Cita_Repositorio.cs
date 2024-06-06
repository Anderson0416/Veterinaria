using Entity;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            comando.Parameters.AddWithValue("@Documento_Veterinario", cita.veterinario.documento);
            comando.Parameters.AddWithValue("@Id_Mascota", cita.mascota.id);

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
                        citas.mascota.id = reader.GetInt16("Id_Mascota");
                        citas.fecha_consulta = reader.GetString("Fecha_Consulta");
                        Citas.Add(citas);
                    }

                }
            }
            conectar.Close();
            return Citas;
        }

        public void Eliminar_Cita(string Id_Mascota)
        {
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "DELETE FROM citas WHERE (Id_Mascota) = @Id_Mascota";

            MySqlCommand comando = new MySqlCommand(sql, conectar);


            comando.Parameters.AddWithValue("@Id_Mascota", Id_Mascota);

            int resultado = comando.ExecuteNonQuery();
        }
        public List<Citas> Consultar_CItas_Veterinarios(string documento)
        {
            List<Citas> Citas_veterinarios = new List<Citas>();
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();
            MySqlDataReader reader;

            string sql = @"
                    SELECT 
                        Citas.Id AS CitaId,
                        Citas.Fecha_Consulta AS FechaConsulta,
                        Citas.Descripcion As Descripcion,
                        Mascotas.Id AS MascotaId,
                        Mascotas.Nombre AS MascotaNombre,
                        Veterinarios.Nombre AS VeterinarioNombre,
                        Veterinarios.Documento AS VeterinarioDocumento
                    FROM 
                        Citas
                    JOIN 
                        Mascotas ON Citas.Id_Mascota = Mascotas.Id
                    JOIN 
                        Veterinarios ON Citas.Documento_Veterinario = Veterinarios.Documento
                    WHERE
                    Veterinarios.Documento = @Documento_Veterinario";

            using (var comando = new MySqlCommand(sql, conectar))
            {
                comando.Parameters.AddWithValue("@Documento_Veterinario", documento);
                using (reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Citas_veterinarios.Add(Map(reader));
                    }

                }
            }
            conectar.Close();
            return Citas_veterinarios;
        }
        public List<Citas> Consultar_Todas_Citas()
        {
            List<Citas> Citas = new List<Citas>();
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();
            MySqlDataReader reader;

            string sql = @"
                    SELECT 
                        Citas.Id AS CitaId,
                        Citas.Fecha_Consulta AS FechaConsulta,
                        Citas.Descripcion As Descripcion,
                        Mascotas.Id AS MascotaId,
                        Mascotas.Nombre AS MascotaNombre,
                        Veterinarios.Nombre AS VeterinarioNombre,
                        Veterinarios.Documento AS VeterinarioDocumento
                    FROM 
                        Citas
                    JOIN 
                        Mascotas ON Citas.Id_Mascota = Mascotas.Id
                    JOIN 
                        Veterinarios ON Citas.Documento_Veterinario = Veterinarios.Documento";

            using (var comando = new MySqlCommand(sql, conectar))
            {
                using (reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Citas.Add(Map(reader));
                    }

                }
            }
            conectar.Close();
            return Citas;
        }
        public Citas Map(MySqlDataReader reader)
        {
            Veterinario veterinario = new Veterinario();
            Citas citas = new Citas
            {
                id = reader.GetInt32("CitaId"),
                descripcion = reader.GetString("Descripcion"),
                fecha_consulta = reader.GetString("FechaConsulta"),
            };

            if (!reader.IsDBNull(reader.GetOrdinal("MascotaId")))
            {
                Mascota mascota = new Mascota
                {
                    id = reader.GetInt32("MascotaId"),
                    nombre = reader.GetString("MascotaNombre"),
                };

                if (!reader.IsDBNull(reader.GetOrdinal("VeterinarioDocumento")))
                {
                    
                   
                        veterinario.documento = reader.GetString("VeterinarioDocumento");
                        veterinario.nombre = reader.GetString("VeterinarioNombre");
                    
                }

                citas.mascota = mascota;
                citas.veterinario = veterinario;
            }
            //else
            //{
            //    citas.Entrenador = null;
            //}

            return citas;
        }
    }
}
