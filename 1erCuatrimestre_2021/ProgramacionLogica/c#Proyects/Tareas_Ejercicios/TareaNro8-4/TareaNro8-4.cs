using System;

namespace TareaNro8_4
{
     class Program
    {
        const int ARRAY_LEN = 5;
        static void Main(string[] args)
        {
            /*Cree una función que devuelva el minimo de un array.*/
            int minimo = 0;
            int[] arrayEnteros = new int[ARRAY_LEN];
            llenarArray(arrayEnteros);
            mostrarArray(arrayEnteros);
            minimo = minimoArray(arrayEnteros);
            Console.WriteLine("El numero minimo del array es: {0}",minimo);
           
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

        static int minimoArray(int[] array){
            int min = array[0];
            for(int i=0;i<array.Length;i++){
                if(min>array[i]){
                    min = array[i];
                }
            }
            return min;
        }
    }
}
