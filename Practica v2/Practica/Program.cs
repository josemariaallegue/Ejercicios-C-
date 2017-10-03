using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro auxiliar = new Perro("pepe", "pitbull",10, true);
            Perro auxiliar2 = new Perro("pepe", "afgano");
            if(auxiliar.Equals(auxiliar2))
            {
                Console.WriteLine("Iguales");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Distintos");
                Console.ReadKey();
            }

            int edad = (int)auxiliar;
            Console.WriteLine(edad);
            Console.ReadKey();

        }
    }
}
