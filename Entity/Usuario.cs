using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Usuario
    {
        public int id { get; set; }
        public int id_tipo { get; set; }
        public string password { get; set; }
        public string conpassword { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string Cedula { get; set; }
        public string tipo_documento { get; set; }
        public string sexo { get; set; }
        public string dia_nacimiento { get; set; }
        public string mes_nacimieto { get; set; }
        public string año_nacimiento { get; set; }
        public string fecha_nacimiento { get; set; }
    }
}
