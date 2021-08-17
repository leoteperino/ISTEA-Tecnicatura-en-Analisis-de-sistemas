using System;

namespace ejer03
{
    class Program
    {
        static void Main(string[] args)
        {
        int num;
        Console.WriteLine("Introduzca un dato:");
        num=Int32.Parse(Console.ReadLine());
        Console.WriteLine("EL factorial {0}",factorial(num));
        }

        static long factorial(int numero)
        {
            if(numero==1)
                return 1;
            return numero * factorial(numero-1);
        }





    }
}
