using DAL;
using Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ejemlo
    {
        
        static void Main(string[] args)
        {
            // Aquí puedes llamar a tu función Consultar_CItas_Veterinarios con el documento adecuado
            string documento = "111"; // Reemplaza "documento_del_veterinario_a_consultar" con el documento real del veterinario que deseas consultar

            // Llama a la función para obtener la lista de citas
            List<Citas> listaCitas = Consultar_CItas_Veterinarios(documento);

            // Muestra cada cita en la consola
            MostrarCitasEnConsola(listaCitas);

            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        // Función para consultar las citas de un veterinario dado su documento

        static List<Citas> Consultar_CItas_Veterinarios(string documento)
            {
            Conexion conexion = new Conexion();
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
                Veterinarios ON Citas.Documento_Veterinario = Veterinarios.Documento"
                ;

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
            
        
        static Citas Map(MySqlDataReader reader)
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
        // Función para mostrar las citas en la consola
        static void MostrarCitasEnConsola(List<Citas> citas)
        {
            foreach (var cita in citas)
            {
                Console.WriteLine("ID de Cita: " + cita.id);
                Console.WriteLine("Fecha de Consulta: " + cita.fecha_consulta);
                Console.WriteLine("Descripción: " + cita.descripcion);
                Console.WriteLine("ID de Mascota: " + cita.mascota.id);
                Console.WriteLine("Nombre de Mascota: " + cita.mascota.nombre);
                Console.WriteLine("Nombre de Veterinario: " + cita.veterinario.nombre);
                Console.WriteLine("Documento de Veterinario: " + cita.veterinario.documento);
                Console.WriteLine("-------------------------------------");
            }
        }
    }
}