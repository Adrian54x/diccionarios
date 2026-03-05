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
                Console.WriteLine("1. Ingreso de 3 estudiantes:");
                Console.WriteLine("2. Mostrar los nombres de los estudiantes");
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
                                val2 = false;
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
                        if(id.Count != 0)
                        {
                            int cont1 = 1;
                            foreach(var estudiante in id)
                            {
                                Console.WriteLine($"{cont1}. ID: {estudiante} \n Nombre:{estudiante}");
                                cont1++;
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
                        if(id.Count != 0)
                        { }
                        else
                        {
                            Console.WriteLine("No a ingresado los 3 estudiantes!");
                        }
                        Console.WriteLine("\nPrecione cualquier tecla para salir");
                        Console.ReadKey();
                        break;
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
