using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Segun un ciclo de iteracion FOR imprimir por pantalla los valores del indice
            multiplos de 3*/
            Console.Clear();
            int[] arrayNumeros = new int[100];
            Random numeros = new Random();

            for(int i=0; i<arrayNumeros.Length; i++){
                arrayNumeros[i]=numeros.Next(1,100);
                if(arrayNumeros[i]%3==0){
                    Console.WriteLine("Numero Multiplo de tres: "+arrayNumeros[i]);
                }
            }
        }
    }
}
