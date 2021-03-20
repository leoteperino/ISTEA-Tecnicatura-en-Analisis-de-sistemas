using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio6*/
            string oracion1="LA CASA EN EL BOSQUE ESTA HECHA";
            string oracion2="de madera de pino y nogal rojo";

            oracion1 = oracion1.ToLower();
            Console.WriteLine(oracion1);

            oracion2 = oracion2.ToUpper();
            Console.WriteLine(oracion2);

            int lenOracion1 = oracion1.Length;
            int lenOracion2 = oracion2.Length;

            Console.WriteLine("La cantidad de letras de la oracion 1 es: "+lenOracion1);
            Console.WriteLine("La cantidad de letras de la oracion 2 es: "+lenOracion2);
        }
    }
}
