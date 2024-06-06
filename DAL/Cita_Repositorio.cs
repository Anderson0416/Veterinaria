using Entity;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//namespace DAL
//{
 
    //public class Cita_Repositoriox  
    //{

        //Conexion conexion = new Conexion();
        //public int Registrar_Cita(Citas cita)
        //{
        //    MySqlConnection conectar = conexion.crearConexion();
        //    conectar.Open();

        //    string sql = "INSERT INTO Citas ( Fecha_Consulta, Descripcion, Documento_Veterinario, Id_Mascota )" +
        //                 "VALUES ( @Fecha_Consulta, @Descripcion, @Documento_Veterinario, @Id_Mascota)";
        //    MySqlCommand comando = new MySqlCommand(sql, conectar);

        //    comando.Parameters.AddWithValue("@Fecha_Consulta", cita.fecha_consulta);
        //    comando.Parameters.AddWithValue("@Descripcion", cita.descripcion);
        //    comando.Parameters.AddWithValue("@Documento_Veterinario", cita.documento_veterinario);
        //    comando.Parameters.AddWithValue("@Id_Mascota", cita.id_mascota);

        //    int resultado = comando.ExecuteNonQuery();

        //    return resultado;
        //}
        //public List<Citas> Consultar_Citas_Veterinario(string documento)
        //{
        //    List<Citas> Citas = new List<Citas>();

        //    MySqlConnection conectar = conexion.crearConexion();
        //    conectar.Open();
        //    MySqlDataReader reader;

        //    string sql = "SELECT Id, Fecha_Consulta, Descripcion, Id_Mascota" +
        //        " FROM citas WHERE Documento_Veterinario LIKE @Documento_Veterinario";

        //    using (var comando = new MySqlCommand(sql, conectar))
        //    {
        //        comando.Parameters.AddWithValue("@Documento_Veterinario", documento);
        //        using (reader = comando.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                Citas citas = new Citas();
        //                citas.id = reader.GetInt32("Id");
        //                citas.descripcion = reader.GetString("Descripcion");
        //                citas.id_mascota = reader.GetInt16("Id_Mascota");
        //                citas.fecha_consulta = reader.GetString("Fecha_Consulta");
        //                Citas.Add(citas);
        //            }

        //        }
        //    }
        //    conectar.Close();
        //    return Citas;
        //}

        //public List<Citas> Consultar_Todos_Cita()
        //{
        //    List<Citas> citas = new List<Citas>();
        //    List<Mascota> mascotas = new List<Mascota>();   
        //    List<Veterinario> veterinarios = new List<Veterinario>();   

        //    MySqlConnection conectar = conexion.crearConexion();
        //    conectar.Open();
        //    MySqlDataReader reader;

        //    string sql =

        //       @"SELECT 
        //     Citas.Fecha_Consulta,
        //     Citas.Descripcion,
        //     Mascotas.Id AS Id_Mascota,
        //     Mascotas.Nombre AS Nombre_Mascota,
        //     Mascotas.Especie,
        //     Mascotas.Raza,
        //     Veterinarios.Nombre AS Nombre_Veterinario,
        //     Veterinarios.Documento AS Documento_Veterinario
        //     FROM 
        //     Citas
        //     JOIN 
        //     Mascotas ON Citas.Id_Mascota = Mascotas.Id
        //     JOIN 
        //     Veterinarios ON Citas.Documento_Veterinario = Veterinarios.Documento;";


        //    using (var comando = new MySqlCommand(sql, conectar))
        //    {
        //        using (reader = comando.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {


        //                Citas cita = new Citas
        //                {
        //                    fecha_consulta = reader["Fecha_Consulta"].ToString(),
        //                    descripcion = reader["Descripcion"].ToString(),
                         
        //                     Mascota = new Mascota
        //                    {
        //                    id = Convert.ToInt32(reader["Id_Mascota"]),
        //                    nombre = reader["Nombre_Mascota"].ToString(),
        //                    especie = reader["Especie"].ToString(),
        //                    raza = reader["Raza"].ToString()
        //                    },

        //                    Veterinario = new Veterinario
        //                    {
        //                     nombre = reader["Nombre_Veterinario"].ToString(),
        //                     documento = reader["Documento_Veterinario"].ToString()
        //                    }
        //                };
        //                citas.Add(cita);
        //            }

        //        }
        //    }
        //    conectar.Close();
        //    return citas;



        //}

        //public void Eliminar_Cita (string Id_Mascota)
        //{
        //    MySqlConnection conectar = conexion.crearConexion();
        //    conectar.Open();

        //    string sql = "DELETE FROM citas WHERE (Id_Mascota) = @Id_Mascota";

        //    MySqlCommand comando = new MySqlCommand(sql, conectar);


        //    comando.Parameters.AddWithValue("@Id_Mascota", Id_Mascota);

        //    int resultado = comando.ExecuteNonQuery();
        //}
       

//    }
//}
