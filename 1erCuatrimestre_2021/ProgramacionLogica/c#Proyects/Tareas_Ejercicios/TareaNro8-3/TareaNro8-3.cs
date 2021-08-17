using System;

namespace TareaNro8_3
{
    class Program
    {
        const int ARRAY_LEN = 5;
        static void Main(string[] args)
        {
            /*Cree una función que devuelva el máximo de un array.*/
            int maximo = 0;
            int[] arrayEnteros = new int[ARRAY_LEN];
            llenarArray(arrayEnteros);
            mostrarArray(arrayEnteros);
            maximo = maximoArray(arrayEnteros);
            Console.WriteLine("El numero maximo del array es: {0}",maximo);
           
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

        static int maximoArray(int[] array){
            int max = array[0];
            for(int i=0;i<array.Length;i++){
                if(max<array[i]){
                    max = array[i];
                }
            }
            return max;
        }
    }
}
