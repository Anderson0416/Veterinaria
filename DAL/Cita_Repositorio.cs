using Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Cita_Repositorio
    {
        Conexion conexion = new Conexion();
        public int Registrar_Cita(Citas cita)
        {
            MySqlConnection conectar = conexion.crearConexion();
            conectar.Open();

            string sql = "INSERT INTO Clientes ( Fecha_Consulta, Descripcion, Documento_Veterinario, Id_Mascota )" +
                         "VALUES ( @Fecha_Consulta, @Descripcion, @Documento_Veterinario, @Id_Mascota)";
            MySqlCommand comando = new MySqlCommand(sql, conectar);

            comando.Parameters.AddWithValue("@Fecha_Consulta", cita.fecha_cita);
            comando.Parameters.AddWithValue("@Descripcion", cita.descripcion);
            comando.Parameters.AddWithValue("@Documento_Veterinario", cita.documento_veterinario);
            comando.Parameters.AddWithValue("@Id_Mascota", cita.id_mascota);
           
            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }
    }
}
