using System;

namespace Ejer04
{
    class Program
    {
        static void Main(string[] args)
        { 
            int dias=365;
            double promedio=0;
            double[] ventas = new double[dias];
            Random rnd = new Random();

            //Asigno valores aleatorios y los muestro
           for(int x=0;x<ventas.Length;x++)
            {
                ventas[x]=rnd.Next(1000,9999);
                Console.Write("Dia ["+x+"]:");
                Console.Write(String.Format ("Importe = {0:c}",ventas[x]));    
                Console.WriteLine("");
                promedio=promedio+ventas[x];
            }

            promedio=promedio/dias;
            Console.Write(String.Format ("Promedio de Ventas = {0:c}",promedio));    
            Console.ReadKey();




            
        }
    }
}
