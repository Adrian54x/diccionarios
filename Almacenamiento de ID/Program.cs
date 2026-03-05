using System;
using System.Collections.Concurrent;
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
            bool val1, val2;
            do
            {
                val1 = true;
                Console.Clear();
                Console.WriteLine("1. Ingreso de 3 estudiantes:");
                Console.WriteLine("2. buscar los nombres de los estudiantes");
                Console.WriteLine("3. Limpiar lista de estudiantes");
                Console.WriteLine("4. salir");
                Console.Write("Elija una opcion:");
                int opcion1 = int.Parse(Console.ReadLine());
                switch (opcion1)
                {
                    case 1:
                        Console.Clear();
                        if(id.Count == 0)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write($"Ingrese ID del estudiante {i+1}:");
                                int id_estudiante = int.Parse(Console.ReadLine());
                                Console.Write($"Ingrese el Nombre del estudiante {i+1}:");
                                string nombre = Console.ReadLine();
                                id.Add(id_estudiante, nombre);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ya ingreso los 3 estudiantes");
                        }
                        Console.WriteLine("\nPrecione cualquier tecla para salir");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        if(id.Count != 0)
                        {
                            Console.Write("Ingrese el ID del estudante que busca:");
                            int buscar = int.Parse(Console.ReadLine());
                            val2 = true;
                            foreach (var estudiante in id)
                            {
                                val2 = true;
                                if (buscar == estudiante.Key)
                                {
                                    Console.WriteLine($"Se encontro el estudiante, Nombre:{estudiante.Value}");
                                }
                                else
                                {
                                    val2 = false;
                                }
                            }
                            if(val2 == false)
                            {
                                Console.WriteLine("No se encontro el estudiante!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No a ingresado los 3 estudiantes!");
                        }
                        Console.WriteLine("\nPrecione cualquier tecla para salir");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        if (id.Count != 0)
                        {
                            Console.Write("¿Quiere eliminar los datos ingresados(Si/No)?");
                            string eliminar = Console.ReadLine();
                            if(eliminar == "Si")
                            {
                                id.Clear();
                                Console.WriteLine("Se elimino la renta");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No a ingresado los 3 estudiantes!");
                        }
                        Console.WriteLine("\nPrecione cualquier tecla para salir");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Saliendo..");
                        val1 = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion no valida!");
                        Thread.Sleep(500);
                        break;
                }
            }while (val1);
        }
    }
}
