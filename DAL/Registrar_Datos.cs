using Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Registrar_Datos
    {
        Conexion conexion = new Conexion();
        
        //public List<Cliente> Obtener_Clientes_Mascotas()
        //{
        //    var clientes = new List<Cliente>();

        //    using (var conectar = conexion.crearConexion())
        //    {
        //        conectar.Open();
        //        var command = new MySqlCommand("SELECT c.Nombre, c.Apellido, c.Tipo_Documento, c.Documento, c.Sexo, c.Fecha_Nacimiento, c.Telefono" +
        //            " m.Nombre AS MascotaNombre, m.Especie, m.Raza, m.Sexo, m.Edad, m.Edad2" +
        //            " FROM Clientes c LEFT JOIN Mascotas m ON c.Documento = m.Cliente_Documento", conectar);
        //        using (var reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                var Documento = reader.GetString("Documento");
        //                var cliente = clientes.FirstOrDefault(c => c.documento == Documento);

        //                if (cliente == null)
        //                {
        //                    cliente = new Cliente
        //                    {
        //                        nombre = reader.GetString("Nombre"),
        //                        apellido = reader.GetString("Apellido"),
        //                        tipo_documento = reader.GetString("Tipo_Documento"),
        //                        documento = reader.GetString("Documento"),
        //                        sexo = reader.GetString("Sexo"),
        //                        fecha_nacimiento = reader.GetString("Fecha_Nacimiento"),
        //                        telefono = reader.GetString("Telefono"),
        //                    };
        //                    clientes.Add(cliente);
        //                }

        //                if (!reader.IsDBNull(reader.GetOrdinal("MascotaID")))
        //                {
        //                    cliente.lista_mascotas.Add(new Mascota
        //                    {

        //                        nombre = reader.GetString("Nombre"),
        //                        especie = reader.GetString("Especie"),
        //                        raza = reader.GetString("Raza"),
        //                        sexo = reader.GetString("Sexo"),
        //                        edad = reader.GetString("Edad"),
        //                        edad2 = reader.GetString("Edad2"),
        //                        cliente.documento = Documento

        //                    });
                        
        //                }
        //            }
        //        }
        //    }

        //    return clientes;
        //}
    }
}
