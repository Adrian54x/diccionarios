using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ciudades_por_código
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> ciudad = new Dictionary<int,string>();
            bool val1;
            do
            {
                Console.Clear();
                val1 = true;
                Console.WriteLine("1. Ingresar 5 ciudades");
                Console.WriteLine("2. Buscar ciudad");
                Console.WriteLine("3. Eliminar ciudades");
                Console.WriteLine("4. Salir");
                Console.Write("Elija una opcion:");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    val1 = false;
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    Thread.Sleep(500);
                    break;
                }
            } while (val1);
        }
    }
}
