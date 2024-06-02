﻿using Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class Mascota_Repositorio
    {
        Conexion conexion = new Conexion();
        public int Registrar_Mascota(Mascota mascota)
        {
            //using (var conectar = conexion.crearConexion())

            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();
            {
                string sql = "INSERT INTO Mascotas (Nombre, Especie, Raza, Sexo, Edad, Edad2, Cliente_Documento) " +
                             "VALUES (@Nombre, @Especie, @Raza, @Sexo, @Edad, @Edad2, @Cliente_Documento)";
                MySqlCommand comando = new MySqlCommand(sql, conectar);

                comando.Parameters.AddWithValue("@Nombre", mascota.nombre);
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
                         "FROM Mascotas WHERE Cliente_Documento = @Documento_Cliente";

            using (var comando = new MySqlCommand(sql, conectar))
            {
                comando.Parameters.AddWithValue("@Documento_Cliente", documento);

                using ( reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                 
                     Mascota mascota = new Mascota();
                     mascota.id = reader.GetInt32("Id");
                     mascota.nombre = reader.GetString("Nombre");
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
        public List<Mascota> Consultar_Todos_Mascota()
        {
            List<Mascota> mascotas = new List<Mascota>();

            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();
            MySqlDataReader reader;

            string sql = "SELECT Id, Nombre, Especie, Raza, Sexo, Edad, Edad2," +
                " Cliente_Documento FROM Mascotas";
            using (var comando = new MySqlCommand(sql, conectar))
            {
                using (reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Mascota mascota = new Mascota();
                        mascota.id = reader.GetInt32("Id");
                        mascota.nombre = reader.GetString("Nombre");
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
        public void Eliminar_Mascota(string Id)
        {

            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "DELETE FROM mascotas WHERE (Id) = @Id";

            MySqlCommand comando = new MySqlCommand(sql, conectar);


            comando.Parameters.AddWithValue("@Id", Id);

            int resultado = comando.ExecuteNonQuery();
        }
        public void Actualizar_Mascota(Mascota mascota)
        {
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "UPDATE Mascotas SET Nombre = @Nombre, Especie = @Especie, Raza = @Raza, Sexo = @Sexo, Edad = @Edad, " +
             "Edad2 = @Edad2, Cliente_Documento = @Cliente_Documento WHERE Id = @Id";

            MySqlCommand comando = new MySqlCommand(sql, conectar);

            comando.Parameters.AddWithValue("@Id", mascota.id);
            comando.Parameters.AddWithValue("@Nombre", mascota.nombre);
            comando.Parameters.AddWithValue("@Especie", mascota.especie);
            comando.Parameters.AddWithValue("@Raza", mascota.raza);
            comando.Parameters.AddWithValue("@Sexo", mascota.sexo);
            comando.Parameters.AddWithValue("@Edad", mascota.edad);
            comando.Parameters.AddWithValue("@Edad2", mascota.edad2);
            comando.Parameters.AddWithValue("@Cliente_Documento", mascota.cliente_documento);
           

            int resultado = comando.ExecuteNonQuery();

            if (resultado > 0)
            {
                Console.WriteLine("Mascota actualizado correctamente.");
            }
            else
            {
                Console.WriteLine("No se encontró el Mascota con el ID especificado.");
            }
        }
    }
}