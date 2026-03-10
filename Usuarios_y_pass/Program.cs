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
            Dictionary<string, string> usuarios = new Dictionary<string, string>();
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
                        Console.Write("Ingrese su su usuario:");
                        string user = Console.ReadLine();
                        Console.Write("Ingrese su contraseña:");
                        string pass = Console.ReadLine();
                        Console.WriteLine("\nUsuario ingresado correctamente");
                        usuarios.Add(user, pass);
                        Thread.Sleep(500);
                        break;

                    case 2:
                        if (usuarios.Count > 0)
                        {
                            val2 = true;
                            Console.Write("Ingrese el usuario que desea buscar:");
                            string buscar = Console.ReadLine();
                            foreach (var usuario in usuarios)
                            {
                                if (buscar == usuario.Key)
                                {
                                    Console.WriteLine($"Contraseña:{usuario.Value}");
                                    val2 = false;
                                }
                            }
                            if(val2)
                            {
                                Console.WriteLine("Usuario no encontrado!");
                            }
                        }
                        else 
                        {
                            Console.WriteLine("Aun no ahi usuarios!");
                        }
                        Console.WriteLine("\nPrecione cualquier tecla para salir");
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
