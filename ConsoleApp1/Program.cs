using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Veterinario_Repositorio veterinario_Repositorio = new Veterinario_Repositorio();
            Veterinario veterinario1 = new Veterinario();
            List<Veterinario> veterinarios = veterinario_Repositorio.ObtenerVeterinarios();

            foreach (var veterinario in veterinarios)
            {
                Console.WriteLine($"Nombre: {veterinario.nombre}, Apellido: {veterinario.apellido}, Documento: {veterinario.documento}");
            }
            Console.WriteLine("Presiona Enter para salir...");
            Console.ReadLine();
        }
    }
}
