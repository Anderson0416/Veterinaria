using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Controladores
    {
        Registrar_Datos registro = new Registrar_Datos();
        public string control_Registro(Usuarios usuario)
        {

            string respuesta = "";

            if (string.IsNullOrEmpty(usuario.Contraseña) ||
                string.IsNullOrEmpty(usuario.Confirmar_Contraseña) || string.IsNullOrEmpty(usuario.Nombre))
            {
                respuesta = "DEBE LLENAR TODOS LOS DATOS";
            }
            else
            {
                if (usuario.Contraseña == usuario.Confirmar_Contraseña)
                {
                    if (registro.existeciaUsuario(usuario.Nombre))
                    {
                        respuesta = "EL USUARIO YA EXISTE";
                    }
                    else
                    {
                        usuario.Contraseña = generarSHA1(usuario.Contraseña);
                        registro.Registrar_Usuario(usuario);
                    }
                }
                else
                {
                    respuesta = "LAS CONTRASEÑAS NO COINCIDE";
                }
            }
            return respuesta;
        }
        public string control_Registro_Cliente(Cliente cliente)
        {

            string respuesta = "";

            if (string.IsNullOrEmpty(cliente.documento) || string.IsNullOrEmpty(cliente.apellido) ||
                string.IsNullOrEmpty(cliente.tipo_documento) || string.IsNullOrEmpty(cliente.documento) ||
                string.IsNullOrEmpty(cliente.nombre) || string.IsNullOrEmpty(cliente.telefono) || string.IsNullOrEmpty(cliente.fecha_nacimiento))
            {
                respuesta = "DEBE LLENAR TODOS LOS DATOS";
            }
            else
            {

                if (registro.control_CLiente(cliente.documento))
                {
                    respuesta = "EL USUARIO YA EXISTE";
                }
                else
                {
                     registro.Registrar_Cliente(cliente);
                }
            }
            return respuesta;
        }
        public string control_Registro_Veterinario(Veterinario veterinario)
        {

            string respuesta = "";

            if (string.IsNullOrEmpty(veterinario.documento) || string.IsNullOrEmpty(veterinario.apellido) ||
                string.IsNullOrEmpty(veterinario.tipo_documento) || string.IsNullOrEmpty(veterinario.sexo) ||
                string.IsNullOrEmpty(veterinario.nombre) || string.IsNullOrEmpty(veterinario.telefono) || string.IsNullOrEmpty(veterinario.fecha_nacimiento) ||
                string.IsNullOrEmpty(veterinario.fecha_contrato))
            {
                respuesta = "DEBE LLENAR TODOS LOS DATOS";
            }
            else
            {

                if (registro.control_Veterinario(veterinario.documento))
                {
                    respuesta = "EL USUARIO YA EXISTE";
                }
                else
                {
                    registro.Registrar_Veterinario(veterinario);
                }
            }
            return respuesta;
        }
        public string control_Registro_Mascota(Mascota mascota)
        {

            string respuesta = "";

            if (string.IsNullOrEmpty(mascota.nombre_mascota) || string.IsNullOrEmpty(mascota.sexo) ||
                string.IsNullOrEmpty(mascota.especie) || string.IsNullOrEmpty(mascota.raza))
            {
                respuesta = "DEBE LLENAR TODOS LOS DATOS";
            }
            else
            {
                if (!registro.control_CLiente(mascota.cliente_documento))
                {
                    respuesta = "EL USUARIO NO EXISTE";
                }
                else
                {
                    registro.Registrar_Mascota(mascota);
                }
                
            }
            return respuesta;
        }
        public string control_Login(string usuario, string password)
        {
            Registrar_Datos registro_datos = new Registrar_Datos();
            string respuesta = "";
            Usuarios Datousuario = null;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                respuesta = "DEBE LLENAR TODOS LOS DATOS";
            }
            else
            {
                Datousuario = registro_datos.ConsultaUsuario(usuario);

                if (Datousuario == null)
                {
                    respuesta = "EL USUARIO NO EXISTE";
                }
                else
                {
                    if (Datousuario.Contraseña != generarSHA1(password))
                    {
                        respuesta = "EL USUARIO O LA CONTRASEÑA NO COINCIDEN";
                    }
                }
            }
            return respuesta;
        }
        private string generarSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] < 16)
                {
                    sb.Append('0');
                }
                sb.Append(result[i].ToString("x"));
            }
            return sb.ToString();
        }
        
    }
}
