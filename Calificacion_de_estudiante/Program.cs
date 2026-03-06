using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calificacion_de_estudiante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> nota_estudiante = new Dictionary<string, double>();
            bool val1,val2;
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
                Console.Clear();
                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("precione doble enter para salir!");
                        do
                        {
                            val2 = true;
                            Console.WriteLine($"\nEstudiante {nota_estudiante.Count+1}:");
                            Console.Write("Nombre:");
                            string nombre = Console.ReadLine();
                            if(nombre == "")
                            {
                                Console.WriteLine("Regresando a menu principal...");
                                Thread.Sleep(500);
                                break; 
                            }
                            Console.Write("Nota:");
                            double nota = double.Parse(Console.ReadLine());
                            nota_estudiante.Add(nombre, nota);
                        }while (val2);
                        break;

                    case 2:
                        Console.Write("Escriba el nombre del estudiante que busca:");
                        string estudiante = Console.ReadLine();
                        foreach(var estudiante_n in nota_estudiante)
                        {
                            val2 = false;
                            if(estudiante == estudiante_n.Key)
                            {
                                Console.WriteLine($"Su nota es: {estudiante_n.Value}");
                            }
                        }
                        break;

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
            }while (val1);
        }
    }
}
