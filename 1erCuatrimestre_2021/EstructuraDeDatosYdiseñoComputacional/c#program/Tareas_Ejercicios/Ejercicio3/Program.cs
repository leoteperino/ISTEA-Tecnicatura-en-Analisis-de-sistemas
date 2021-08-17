using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Desarrollar una aplicación consola que implemente un array de enteros de al menos
                200 posiciones con valores aleatorios y que devuelva por pantalla impresos todos
                los valores, el máximo y el mínimo.
            */
            Console.Clear();
            Random number = new Random(); //Instancio la clase Random
            int[] arrayNumber = new int[200]; //Genero el array de 200 posiciones

            //Asignacion de valores random al array
            for(int i=0;i<arrayNumber.Length;i++){
                arrayNumber[i] = number.Next(0,1000);
            }

            //Tomo como maximo y minimo el primer numero ingresado en el Array 
            int maximo = arrayNumber[0];
            int minimo = arrayNumber[0];
           
           //Muestro los valores del Array y calculo max y min
           for(int i = 0;i<arrayNumber.Length;i++){
                Console.WriteLine("Posicion: "+i+" -- Valor: "+arrayNumber[i]); //Muestro Array
                if(maximo < arrayNumber[i]){ //Calculo Maximo
                    maximo = arrayNumber[i];
                }
                if(minimo > arrayNumber[i]){ //Calculo Minimo
                    minimo = arrayNumber[i];
                } 
           } 

            //Mostrar los maximos y los minimos
            Console.WriteLine("El numero maximo es: "+maximo);
            Console.WriteLine("El numero minimo es: "+minimo);
            Console.ReadKey();
        }
    }
}
