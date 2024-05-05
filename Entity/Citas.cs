using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Citas
    {
        Cliente cliente { get; set; }
        Mascota Mascota { get; set; }
        Veterinario Veterinario { get; set; }
        public string fecha_cita { get; set; }
        public string Descripcion { get; set; }

    }
}
