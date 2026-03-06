using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace producto_por_nombre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> codigo = new Dictionary<int, string>();
            bool val1;
            do
            {
                val1 = true;
                Console.Clear();
                Console.WriteLine("1. Ingrese 3 productos");
                Console.WriteLine("2. Mostrar productos");
                Console.WriteLine("3. Limpiar lista de productos");
                Console.WriteLine("4. salir");
                Console.Write("Elija una opcion:");
                int opcion1 = int.Parse(Console.ReadLine());
                switch (opcion1)
                {
                    case 1:
                        Console.Clear();
                        if (codigo.Count == 0)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write($"Ingrese el producto {i + 1}:");
                                string producto = Console.ReadLine();
                                Console.Write($"Ingrese el codigo del producto {i + 1}:");
                                int codigo_x = int.Parse(Console.ReadLine());
                                codigo.Add(codigo_x, producto);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ya ingreso los 3 productos!");
                        }
                        break;

                    case 2:
                        Console.Clear();
                        int cont1 = 1;
                        foreach(var producto in codigo)
                        {
                            Console.WriteLine($"{cont1}. \nProducto:{producto.Value} \nCodigo:{producto.Key}");
                            cont1++;
                        }
                        Console.WriteLine("\nPrecione cualquier tecla para salir");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("¿Dese borrar los datos ingresados (Si/no)?");
                        string borrar = Console.ReadLine();
                        if (borrar.StartsWith("S")|| borrar.StartsWith("s"))
                        {
                            codigo.Clear();
                            Console.WriteLine("Se borro la lista");
                        }
                        Console.WriteLine("\nPrecione cualquier tecla para salir");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        val1 = false;
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion no valida");
                        Thread.Sleep(500);
                        break;
                }      
             }while (val1);
        }
    }
}
