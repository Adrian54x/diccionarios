using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificacion_de_estudiante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> nota_estudiante = new Dictionary<string, int>();
            bool val1;
            do
            {
                Console.Clear();
                val1 = true;
                Console.WriteLine("1. Ingreso de notas y estudiante");
                Console.WriteLine("2. Buscar notas de estudiante");
                Console.WriteLine("3. Eliminar estudiante");
                Console.WriteLine("4. Salir");
                Console.Write("Elija una opcion:");
                int opcion = int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    default:
                        break;
                       
                }
            }while (val1);
        }
    }
}
