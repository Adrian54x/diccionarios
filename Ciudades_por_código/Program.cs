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
            bool val1,val2;
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
                        Console.WriteLine("Ingrese 5 ciudades");
                        for(int i = 1; i <= 5; i++)
                        {
                            Console.WriteLine($"\n{i}.");
                            Console.Write("Ciudad:");
                            string ciudad_x = Console.ReadLine();
                            Console.Write("Codigo:");
                            int codigo = int.Parse(Console.ReadLine());
                            ciudad.Add(codigo, ciudad_x);
                        }
                        break;
                    case 2:
                    case 3:
                        do
                        {
                            val2 = true;
                            Console.Clear();
                            Console.Write("¿Desea borrar las ciudades ingresadas (Si/No)?:");
                            string eliminar = Console.ReadLine();
                            if (eliminar.StartsWith("S") || eliminar.StartsWith("s"))
                            {
                                ciudad.Clear();
                                Console.WriteLine("Se elimino las ciudades");
                                val2 = false;
                            }
                            else if (eliminar.StartsWith("N") || eliminar.StartsWith("n"))
                            {
                                Console.WriteLine("Regresando...");
                                Thread.Sleep(500);
                                val2 = false;
                            }
                            else
                            {
                                Console.WriteLine("Opcion no valida!");
                            }
                        }while (val2);
                        break;

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
