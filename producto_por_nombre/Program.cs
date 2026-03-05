using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace producto_por_nombre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> codigo = new Dictionary<int, string>();
            bool val1, val2;
            do
            {
                val1 = true;
                Console.Clear();
                Console.WriteLine("1. Ingrese 3 productos");
                Console.WriteLine("2. Mostrar los nombres de los estudiantes");
                Console.WriteLine("3. Limpiar lista de productos");
                Console.WriteLine("4. salir");
                Console.Write("Elija una opcion:");
                int opcion1 = int.Parse(Console.ReadLine());
                switch (opcion1)
            }while (val1);
        }
    }
}
