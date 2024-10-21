using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimerProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //suma de dos numeros, introducidos por el usuario
            Console.Write("Num 1: ");
            int num1 = Int16.Parse(Console.ReadLine()); // "5" -> 5

            Console.Write("Num 2: ");
            int num2 = Int16.Parse(Console.ReadLine());

            int suma = num1 + num2;
            Console.WriteLine("La suma es: {0}", suma);


            Console.WriteLine(); //para que no se cierre la consola
        }
    }
}
