using Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Mascota_Repositorio
    {
        Conexion conexion = new Conexion();
        public int Registrar_Mascota(Mascota mascota)
        {
            using (var conectar = conexion.crearConexion())
            {
                conectar.Open();

                string sql = "INSERT INTO Mascotas (Nombre, Especie, Raza, Sexo, Edad, Edad2, Cliente_Documento) " +
                             "VALUES (@Nombre, @Especie, @Raza, @Sexo, @Edad, @Edad2, @Cliente_Documento)";
                MySqlCommand comando = new MySqlCommand(sql, conectar);

                comando.Parameters.AddWithValue("@Nombre", mascota.nombre_mascota);
                comando.Parameters.AddWithValue("@Especie", mascota.especie);
                comando.Parameters.AddWithValue("@Raza", mascota.raza);
                comando.Parameters.AddWithValue("@Sexo", mascota.sexo);
                comando.Parameters.AddWithValue("@Edad", mascota.edad);
                comando.Parameters.AddWithValue("@Edad2", mascota.edad2);
                comando.Parameters.AddWithValue("@Cliente_Documento", mascota.cliente_documento);

                int resultado = comando.ExecuteNonQuery();

                return resultado;
            }
        }
        public List<Mascota> Consulta_Mascota_Cliente(string documento)
        {
            List<Mascota> mascotas = new List<Mascota>();

            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();
            MySqlDataReader reader;

            string sql = "SELECT Id, Nombre, Especie, Raza, Sexo, Edad, Edad2, Cliente_Documento " +
                         "FROM Mascotas WHERE Cliente_Documento = @DocumentoCliente";

            using (var comando = new MySqlCommand(sql, conectar))
            {
                comando.Parameters.AddWithValue("@DocumentoCliente", documento);

                using ( reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                 
                     Mascota mascota = new Mascota();
                     mascota.id = reader.GetInt32("Id");
                     mascota.nombre_mascota = reader.GetString("Nombre");
                     mascota.especie = reader.GetString("Especie");
                     mascota.raza = reader.GetString("Raza");
                     mascota.sexo = reader.GetString("Sexo");
                     mascota.edad = reader.GetString("Edad");
                     mascota.edad2 = reader.GetString("Edad2");
                     mascota.cliente_documento = reader.GetString("Cliente_Documento");
                     mascotas.Add(mascota);
                        
                    }
                }
            }

            conectar.Close();
            return mascotas;
        }

    }
}
