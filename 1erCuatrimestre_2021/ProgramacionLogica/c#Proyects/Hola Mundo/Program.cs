using System;

namespace Hola_Mundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Presiona una tecla para salir");
            Console.ReadKey();

            int a = 5;
            int b = 5;
            int c = a + b;
            Console.WriteLine("El resultado de "+a+" + "+b+" es: "+c);
            Console.Read(); 
        }
    }
}