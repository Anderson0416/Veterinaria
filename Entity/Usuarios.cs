using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Usuarios
    {
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string Confirmar_Contraseña { get; set; }
    }
}
