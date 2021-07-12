using System;

namespace TareaNro8_2
{
    class Program
    {
        const int ARRAY_LEN = 5;
        static void Main(string[] args)
        {
            /*Cree una aplicación consola que devuelva el valor de la media 
            de una array enviado por argumento.*/
            int media;
            int[] arrayEnteros = new int[ARRAY_LEN];
            llenarArray(arrayEnteros);
            mostrarArray(arrayEnteros);
            media = mediaArray(arrayEnteros);
            Console.WriteLine("La media del array es: {0}",media);
        }

        static void llenarArray(int[] array){
            Random number = new Random();
            for(int i = 0; i<array.Length; i++){
                array[i] = number.Next(1,10);     
            }
        }

        static void mostrarArray(int[] array){
            Console.Clear();
            Console.WriteLine("Array cargado con exito:");
            for(int i=0;i<array.Length;i++){
                Console.Write("-"+array[i]);
            }
            Console.Write("\n");
        }

        static int mediaArray(int[] array){
            int acum = 0;
            for(int i=0;i<array.Length;i++){
                acum += array[i];
            }
            return acum/2;
        }
    }
}
