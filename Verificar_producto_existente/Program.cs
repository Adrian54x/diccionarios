using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Verificar_producto_existente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> productos = new Dictionary<string,int>();
            bool val1, val2;
            int cont1;
            do
            {
                Console.Clear();
                val1 = true;
                Console.WriteLine("1. Ingresar productos");
                Console.WriteLine("2. Vista de productos");
                Console.WriteLine("3. Salir");
                Console.Write("Elija una opcion:");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Precione dos veces enter para salir");
                        Console.WriteLine("\nIngrese productos");
                        cont1 = 1;
                        do
                        {
                            string producto;
                            val1 = true;
                            do
                            {
                                val2 = true;
                                Console.Write($"\n{cont1}. Producto:");
                                producto = Console.ReadLine();
                                if (productos.ContainsKey(producto))
                                {
                                    Console.WriteLine("ya esta en la lista ingrese otro!");
                                }
                            } while ();
                            if(producto == "")
                            {
                                Console.WriteLine("Regresando...");
                                Thread.Sleep(500);
                                break;
                            }
                            Console.Write("  Codigo:");
                            int codigo = int.Parse(Console.ReadLine());
                            productos.Add(producto, codigo);
                            cont1++;  
                        } while (val1);
                        break;
                    case 2:
                        cont1 = 1;
                        foreach(var producto_x in productos)
                        {
                            Console.WriteLine($"{cont1}. Producto:{producto_x.Key} \n Codigo:{producto_x.Value}");
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
            }while (val1);
        }
    }
}
