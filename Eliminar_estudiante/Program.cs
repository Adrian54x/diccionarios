using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eliminar_estudiante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> estudoiantes = new Dictionary<int, string>();
            bool val1, val2;
            do
            {
                Console.Clear();
                val1 = true;
                Console.WriteLine("1. Ingresar 3 estudiantes");
                Console.WriteLine("2. Eliminar estudiantes");
                Console.WriteLine("3. Salir");
                Console.Write("Elija una opcion:");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese 3 estudiantes");
                        for (int i = 1; i <= 3; i++)
                        {
                            Console.WriteLine($"\n{i}.");
                            Console.Write("Estudiantes:");
                            string estudiante = Console.ReadLine();
                            Console.Write("Codigo:");
                            int codigo = int.Parse(Console.ReadLine());
                            estudoiantes.Add(codigo, estudiante);
                        }
                        break;

                    case 2:
                        if (estudoiantes.Count > 0)
                        {
                            int eliminar = 0;
                            Console.Write("Ingrese el nombre del estudiante que quiera eliminar:");
                            string buscar = Console.ReadLine();
                            val2 = false;
                            foreach (var estudiante_x in estudoiantes)
                            {
                                if (buscar == estudiante_x.Value)
                                {
                                    eliminar = estudiante_x.Key;
                                    val2 = true;
                                }
                            }
                            if (val2)
                            {
                                Console.WriteLine($"Estudiante {buscar} a sido eliminado");
                                estudoiantes.Remove(eliminar);
                            }
                            else
                            {
                                Console.WriteLine("No se encontro al estudiante!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No ahi aun ningun estudiante!");
                        }
                        Console.WriteLine("\nPrecione cualquier tecla para regresar");
                        Console.ReadKey();
                        break;

                    case 3:
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
