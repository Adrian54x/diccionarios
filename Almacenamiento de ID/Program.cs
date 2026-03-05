using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Almacenamiento_de_ID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> id = new Dictionary<int, string>();
            bool val1;
            do
            {
                val1 = true;
                Console.WriteLine("1. Ingreso de 3 estudiantes:");
                Console.WriteLine("2. Mostrar los nombres de los estudiantes");
                Console.WriteLine("3. Limpiar lista de estudiantes");
                Console.WriteLine("4. salir");
                Console.Write("Elija una opcion:");
                int opcion1 = int.Parse(Console.ReadLine());
                switch (opcion1)
                {
                    case 1:
                        if(id.Count != 0)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write("Ingrese ID del estudiante:");
                                int id_estudiante = int.Parse(Console.ReadLine());
                                Console.Write("Ingrese el Nombre del estudiante:");
                                string nombre = Console.ReadLine();
                                id.Add(id_estudiante, nombre);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ya ingreso los 3 estudiantes");
                        }
                        break;
                    case 2:
                        break;
                    case 3:
                    case 4:
                        Console.WriteLine("Saliendo..");
                        val1 = false;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida!");
                        Thread.Sleep(5000);
                        break;
                }
            }while (val1);
        }
    }
}
