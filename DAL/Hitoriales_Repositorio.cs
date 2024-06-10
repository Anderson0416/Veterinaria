using Entity;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace DAL
{
    public class Hitoriales_Repositorio
    {
        Conexion conexion = new Conexion();
        public int Registrar_Historial (Hitoriales hitoriales)
        {
            MySqlConnection conectar = conexion.crearConexion();
            int historialId;
            conectar.Open();
            string sql = @"INSERT INTO Historial (MascotaId, Fecha_Creacion) 
                       VALUES (@MascotaId, @Fecha_Creacion);
                       SELECT LAST_INSERT_ID();";

            using (MySqlCommand insertHistorialesCommand = new MySqlCommand(sql, conectar))
            {
                using (MySqlCommand comando = new MySqlCommand(sql, conectar))
                {
                    
                    comando.Parameters.AddWithValue("@MascotaId", hitoriales.mascota.id);
                    comando.Parameters.AddWithValue("@Fecha_Creacion", hitoriales.fecha_consulta );
                    historialId = Convert.ToInt32(comando.ExecuteScalar());
                }
                return historialId;
                conectar.Close();
            }
        }
        public List<Hitoriales> Consultar_Historial_Mascota(int idMascota)
        {
            List<Hitoriales> historiales = new List<Hitoriales>();
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();
            MySqlDataReader reader;
            string sql = @"
        SELECT 
            h.Id AS HistorialId,
            h.Fecha_Creacion AS FechaCreacion,
            m.Id AS MascotaId,
            m.Nombre AS NombreMascota,
            a.Id AS AnamnesisId,
            a.Observacione AS Observaciones
        FROM 
            Historial h
        JOIN 
            Mascotas m ON h.MascotaId = m.Id
        LEFT JOIN 
            Anamnesis a ON h.Id = a.Id_Historial
        WHERE 
            m.Id = @IdMascota";

            using (var comando = new MySqlCommand(sql, conectar))
            {
                comando.Parameters.AddWithValue("@IdMascota", idMascota);
                using (reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                        {
                          Hitoriales historial = new Hitoriales
                           {
                             id = Convert.ToInt32(reader["HistorialId"]),
                             fecha_consulta = reader["FechaCreacion"].ToString(),
                             mascota = new Mascota
                             {
                                id = Convert.ToInt32(reader["MascotaId"]),
                                nombre = reader["NombreMascota"].ToString()
                             }
                         };

                            if (reader["AnamnesisId"] != DBNull.Value)
                            {
                                historial.anamnesis = new Anamnesis
                                {
                                    id = Convert.ToInt32(reader["AnamnesisId"]),
                                    observaciones = reader["Observaciones"].ToString()
                                };
                            }

                            historiales.Add(historial);
                        }
                    
                }
            }

            return historiales;
        }
        public Hitoriales Consultar_Historial_Id(int idHistorial)
        {
            Hitoriales historial = null;


            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();
            MySqlDataReader reader;
            string sql = @"
                  SELECT 
                         h.Id AS HistorialId,
                         h.Fecha_Creacion AS FechaCreacion,
                         m.Id AS MascotaId,
                         m.Nombre AS NombreMascota,
                         m.Especie,
                         m.Raza,
                         m.Sexo,
                         m.Edad,
                         m.Edad2,
                         m.Cliente_Documento
                  FROM 
                         Historial h
                  JOIN 
                         Mascotas m ON h.MascotaId = m.Id
                  WHERE 
                         h.Id = @Id";
            using (MySqlCommand comando = new MySqlCommand(sql, conectar))
            {
                comando.Parameters.AddWithValue("@Id", idHistorial);

                using (reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        historial = new Hitoriales
                        {
                            id = Convert.ToInt32(reader["HistorialId"]),
                            fecha_consulta = reader["FechaCreacion"].ToString(),
                            mascota = new Mascota
                            {
                                id = Convert.ToInt32(reader["MascotaId"]),
                                nombre = reader["NombreMascota"].ToString(),
                                especie = reader["Especie"].ToString(),
                                raza = reader["Raza"].ToString(),
                                sexo = reader["Sexo"].ToString(),
                                edad = reader["Edad"].ToString(),
                                edad2 = reader["Edad2"].ToString()
                            }
                        };
                    }
                }
            }
            conectar.Close();
            return historial;
        }

    }
}
