using Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Anamnesis_Repositorio
    {
        Conexion conexion = new Conexion();
        public int Registrar_Anamnesis(Anamnesis anamnesis)
        {
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "INSERT INTO Anamnesis ( Peso, peso2, Estado_Reproductivo, Tipo_Vivienda, Actividad_Fisica," +
                " Vacunas_Previas, Vacunas_Previas_Desparasitacion, Motivo_Consulta, Sintomas_Mascota," +
                " Observacione, Dieta_Alimentacion, Id_Historial )" +
                "VALUES ( @Peso, @peso2, @Estado_Reproductivo, @Tipo_Vivienda, @Actividad_Fisica," +
                " @Vacunas_Previas, @Vacunas_Previas_Desparasitacion, @Motivo_Consulta, @Sintomas_Mascota," +
                " @Observacione, @Dieta_Alimentacion, @Id_Historial  )";

            MySqlCommand comando = new MySqlCommand(sql, conectar);

            comando.Parameters.AddWithValue("@Peso", anamnesis.peso);
            comando.Parameters.AddWithValue("@peso2", anamnesis.peso2);
            comando.Parameters.AddWithValue("@Estado_Reproductivo", anamnesis.estado_reproductivo);
            comando.Parameters.AddWithValue("@Tipo_Vivienda", anamnesis.tipo_vivienda);
            comando.Parameters.AddWithValue("@Actividad_Fisica", anamnesis.actividad_fisica);
            comando.Parameters.AddWithValue("@Vacunas_Previas", anamnesis.vacunas_previas);
            comando.Parameters.AddWithValue("@Vacunas_Previas_Desparasitacion", anamnesis.vacunas_precias_desparecitacion);
            comando.Parameters.AddWithValue("@Motivo_Consulta", anamnesis.motivos_consulta);
            comando.Parameters.AddWithValue("@Sintomas_Mascota", anamnesis.sintomas_mascota);
            comando.Parameters.AddWithValue("@Observacione", anamnesis.observaciones);
            comando.Parameters.AddWithValue("@Dieta_Alimentacion", anamnesis.dieta);
            comando.Parameters.AddWithValue("@Id_Historial", anamnesis.hitoriales.id);

            int resultado = comando.ExecuteNonQuery();

            conectar.Close();

            return resultado;
        }
        public Anamnesis Consulta_Anamnesis_id(int id)
        {
            Anamnesis anamnesis = new Anamnesis();
            MySqlDataReader reader;
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();
            string sql = @"
                         SELECT Id, Peso, Peso2, Estado_Reproductivo, Tipo_Vivienda, Actividad_Fisica, Vacunas_Previas,
                                Vacunas_Previas_Desparasitacion, Motivo_Consulta, Sintomas_Mascota, Observacione, Dieta_Alimentacion
                         FROM 
                                Anamnesis
                         WHERE 
                        Id = @IdAnamnesis";
                using (MySqlCommand comando = new MySqlCommand(sql, conectar))
                {
                comando.Parameters.AddWithValue("@IdAnamnesis", id);
                    using (reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            anamnesis = new Anamnesis
                            {
                                id = Convert.ToInt32(reader["Id"]),
                                peso = Convert.ToInt32(reader["Peso"]),
                                peso2 = reader["Peso2"].ToString(),
                                estado_reproductivo = reader["Estado_Reproductivo"].ToString(),
                                tipo_vivienda = reader["Tipo_Vivienda"].ToString(),
                                actividad_fisica = reader["Actividad_Fisica"].ToString(),
                                vacunas_previas = reader["Vacunas_Previas"].ToString(),
                                vacunas_precias_desparecitacion = reader["Vacunas_Previas_Desparasitacion"].ToString(),
                                motivos_consulta = reader["Motivo_Consulta"].ToString(),
                                sintomas_mascota = reader["Sintomas_Mascota"].ToString(),
                                observaciones = reader["Observacione"].ToString(),
                                dieta = reader["Dieta_Alimentacion"].ToString()
                            };
                        }
                    }
                }
            

            return anamnesis;
        }
        public Anamnesis Consulta_Anamnesis_id_Historial(int id_historial)
        {
            Anamnesis anamnesis = new Anamnesis();
            MySqlDataReader reader;
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();
            string sql = @"
                 SELECT Id, Peso, Peso2, Estado_Reproductivo, Tipo_Vivienda, Actividad_Fisica, Vacunas_Previas,
                        Vacunas_Previas_Desparasitacion, Motivo_Consulta, Sintomas_Mascota, Observacione, Dieta_Alimentacion
                 FROM 
                        Anamnesis
                 WHERE 
                        Id_Historial = @IdHistorial";
            using (MySqlCommand comando = new MySqlCommand(sql, conectar))
            {
                comando.Parameters.AddWithValue("@IdHistorial", id_historial);
                using (reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        anamnesis = new Anamnesis
                        {
                            id = Convert.ToInt32(reader["Id"]),
                            peso = Convert.ToInt32(reader["Peso"]),
                            peso2 = reader["Peso2"].ToString(),
                            estado_reproductivo = reader["Estado_Reproductivo"].ToString(),
                            tipo_vivienda = reader["Tipo_Vivienda"].ToString(),
                            actividad_fisica = reader["Actividad_Fisica"].ToString(),
                            vacunas_previas = reader["Vacunas_Previas"].ToString(),
                            vacunas_precias_desparecitacion = reader["Vacunas_Previas_Desparasitacion"].ToString(),
                            motivos_consulta = reader["Motivo_Consulta"].ToString(),
                            sintomas_mascota = reader["Sintomas_Mascota"].ToString(),
                            observaciones = reader["Observacione"].ToString(),
                            dieta = reader["Dieta_Alimentacion"].ToString()
                        };
                    }
                }
            }
            conectar.Close();
            return anamnesis;
        }
    }
}
