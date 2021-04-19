using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio4*/
            int valor10;
            Console.WriteLine("Ingrese valor 1: ");
            valor10 = int.Parse(Console.ReadLine());
            valor10++;
            Console.WriteLine("El incremento del valor es: "+valor10);
            valor10--;
            Console.WriteLine("El decremento del valor es: "+valor10);
        }
    }
}
