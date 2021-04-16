using System;

namespace EjercicioClase5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Idem Ejercicio antes, utilizar un array tipo double para ventas diarias 
            y una variaable promedio , generar por pantalla el promedio de venta diario y 
            los valores del double (array) se deben asignar aleatoriamente*/

            Console.Clear();
            Random number = new Random(); 
            double[] arrayNumber = new double[365];

            for(int i=0;i<arrayNumber.Length;i++){
                arrayNumber[i] = number.Next(0,10000);
            }

            double promedio;
            double acum = 0;

            for(int x=0;x<arrayNumber.Length;x++){
                acum = acum + arrayNumber[x];
            }

            promedio = acum / arrayNumber.Length;

            Console.WriteLine(promedio);
        }
    }
}
