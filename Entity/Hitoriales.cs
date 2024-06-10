using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Hitoriales
    {
        public int id { get; set; }
        public Mascota mascota { get; set; }
        public string fecha_consulta { get; set; }
        public Anamnesis anamnesis { get; set; }
    }
}
