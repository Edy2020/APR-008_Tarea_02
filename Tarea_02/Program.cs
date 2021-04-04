using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escriba un numero para saber si es Par o impar");

            int numero = Convert.ToInt32(Console.ReadLine());
            
            if ((numero % 2) == 0)
            {

                Console.WriteLine("==============================");
                Console.WriteLine("     Tu numero es par");
                Console.WriteLine("==============================");
            }
            else
            {
                Console.WriteLine("==============================");
                Console.WriteLine("     Tu numero es impar");
                Console.WriteLine("==============================");
            }

            Console.ReadKey();
        }
    }
}
