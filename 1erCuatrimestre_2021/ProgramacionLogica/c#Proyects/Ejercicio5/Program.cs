using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio5*/
            int valor1 = 20;
            double valor2;
            valor1++;
            valor1=valor1*2;
            Console.WriteLine("El valor de la variable es: "+valor1);
            valor1=(valor1/2)-1;
            Console.WriteLine("El valor de la variable es: "+valor1);
            valor1=50;
            valor1/=3;
            Console.WriteLine("El valor de la variable es: "+valor1.ToString());
            valor2=50;
            valor2/=3;
            Console.WriteLine("El valor de la variable es: "+valor2.ToString());
        }
    }
}
