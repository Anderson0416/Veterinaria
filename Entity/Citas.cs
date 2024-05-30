using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Citas
    {
        public string fecha_cita { get; set; }
        public string descripcion { get; set; }
        public string documento_veterinario { get; set; }
        public int id_mascota { get; set; }
    }
}
