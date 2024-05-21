using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cliente : Persona
    {
      public List<Mascota> lista_mascotas {get; set;}
       
        public Cliente()
        {
            lista_mascotas = new List<Mascota>();
        }

        public void Agragar_Mascota (Mascota mascota)
        {
            lista_mascotas.Add(mascota);
        }
    }
}
