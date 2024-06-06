using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Controladores
    {
        Registrar_Datos registro = new Registrar_Datos();
        public string Validacion_Usuario (Usuarios usuario)
        {
            Usuario_Repositorio usuario_repositorio = new Usuario_Repositorio();
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
                    if (usuario_repositorio.Existecia_Usuario(usuario.Nombre))
                    {
                        respuesta = "EL USUARIO YA EXISTE";
                    }
                    else
                    {
                        usuario.Contraseña = generarSHA1(usuario.Contraseña);
                        usuario_repositorio.Registrar_Usuario(usuario);
                    }
                }
                else
                {
                    respuesta = "LAS CONTRASEÑAS NO COINCIDE";
                }
            }
            return respuesta;
        }
        public string Validacion_Cliente(Cliente cliente)
        {
            Cliente_Repositorio cliente_repositorio = new Cliente_Repositorio();
            string respuesta = "";

            if (string.IsNullOrEmpty(cliente.documento) || string.IsNullOrEmpty(cliente.apellido) ||
                string.IsNullOrEmpty(cliente.tipo_documento) || string.IsNullOrEmpty(cliente.documento) ||
                string.IsNullOrEmpty(cliente.nombre) || string.IsNullOrEmpty(cliente.telefono) || string.IsNullOrEmpty(cliente.fecha_nacimiento))
            {
                respuesta = "DEBE LLENAR TODOS LOS DATOS";
            }
            else
            {

                if (cliente_repositorio.Existencia_CLiente(cliente.documento))
                {
                    respuesta = "EL CLIENTE YA EXISTE";
                }
                else
                {
                    cliente_repositorio.Registrar_Cliente(cliente);
                }
            }
            return respuesta;
        }
        public string Validacion_Veterinario(Veterinario veterinario)
        {
            Veterinario_Repositorio veterinario_repositorio = new Veterinario_Repositorio();
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

                if (veterinario_repositorio.Existencia_Veterinario(veterinario.documento))
                {
                    respuesta = "EL VETERINARIO YA EXISTE";
                }
                else
                {
                    veterinario_repositorio.Registrar_Veterinario(veterinario);
                }
            }
            return respuesta;
        }
        public string Validacion_Producto (Producto producto) {

            Producto_Repositorio producto_repositorio = new Producto_Repositorio();
            string respuesta = "";

            if (string.IsNullOrEmpty(producto.Descripcion) || string.IsNullOrEmpty(producto.Nombre) ||
                producto.Precio<0)
            {
                respuesta = "DEBE LLENAR TODOS LOS DATOS";
            }
            else
            {
            producto_repositorio.Registrar_Producto(producto);   
            }
            return respuesta;
        }
        public string Validacion_Mascota (Mascota mascota)
        {
            Mascota_Repositorio mascota_repositorio = new Mascota_Repositorio();
            Cliente_Repositorio cliente_repositorio = new Cliente_Repositorio();

            string respuesta = "";

            if (string.IsNullOrEmpty(mascota.nombre) || string.IsNullOrEmpty(mascota.sexo) ||
                string.IsNullOrEmpty(mascota.especie) || string.IsNullOrEmpty(mascota.raza))
            {
                respuesta = "DEBE LLENAR TODOS LOS DATOS";
            }
            else
            {
                if (!cliente_repositorio.Existencia_CLiente(mascota.cliente.documento))
                {
                    respuesta = "LA MASCOTA NO EXISTE";
                }
                else
                {
                    mascota_repositorio.Registrar_Mascota(mascota);
                }
                
            }
            return respuesta;
        }
        public string Validacion_Cita (Citas citas)
        {
            Cita_Repositorio cita_repositorio = new Cita_Repositorio();
            string respuesta = "";

            if (string.IsNullOrEmpty(citas.fecha_consulta) || string.IsNullOrEmpty(citas.descripcion) ||
                string.IsNullOrEmpty(citas.veterinario.documento) || citas.mascota.id <0)
            {
                respuesta = "DEBE LLENAR TODOS LOS DATOS";
            }
            else
            {

                cita_repositorio.Registrar_Cita(citas);
                
            }
            return respuesta;
        }
        public string control_Login(string usuario, string password)
        {
            Usuario_Repositorio usuario_repositorio = new Usuario_Repositorio();

            string respuesta = "";
            Usuarios Datousuario = new Usuarios();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                respuesta = "DEBE LLENAR TODOS LOS DATOS";
            }
            else
            {
                Datousuario = usuario_repositorio.ConsultaUsuario(usuario);

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
                    else
                    {
                        
                        Seccion.id = Datousuario.id;
                        Seccion.Nombre = usuario;
                        Seccion.Tipo_usuario = Datousuario.Tipo_usuario;
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
