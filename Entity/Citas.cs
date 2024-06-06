using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Citas
    {
        public int id { get; set; }
        public string fecha_consulta { get; set; }
        public string descripcion { get; set; }
        public Veterinario veterinario { get; set; }
        public Mascota mascota { get; set; }


        //public class Mascota
        //{
        //    public int Id { get; set; }
        //    public string Nombre { get; set; }
        //    public string Especie { get; set; }
        //    public string Raza { get; set; }
        //}

        //public class Veterinario
        //{
        //    public string Nombre { get; set; }
        //    public string Documento { get; set; }
        //}
    }
}
