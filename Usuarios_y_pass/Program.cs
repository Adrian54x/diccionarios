using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Usuarios_y_pass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ciudad = new Dictionary<int, string>();
            bool val1, val2;
            do
            {
                Console.Clear();
                val1 = true;
                Console.WriteLine("1. Usuario");
                Console.WriteLine("2. Buscar usuario");
                Console.WriteLine("3. Salir");
                Console.Write("Elija una opcion:");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese su su usuario");
                        string user = Console.ReadLine();
                        Console.Write("Ingrese su contraseña:");
                        string pass = Console.ReadLine();
                        Console.WriteLine("\nUsuario ingresado correctamente");
                        Thread.Sleep(500);
                        break;

                    case 2:
                        Console.Write("Ingrese el usuario que desea buscar");
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
