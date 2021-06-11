using System;

namespace TareaNro7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            3-Crear una aplicación consola con un array de enteros de al menos 40 elementos, 
            los mismos se deberán cargar a partir de una función que devuelve el valor a cargar dentro del array.
            */
            int[] array_enteros=new int[40];
            cargarArrayEnteros(array_enteros);
            mostrarArrayEnteros(array_enteros);

        }

        static void cargarArrayEnteros(int[] array){
            Random number = new Random();
            for(int i = 0; i<array.Length; i++){
                array[i] = number.Next(1,100);     
            }
        }

        static void mostrarArrayEnteros(int[] array){
            Console.Clear();
            Console.WriteLine("Array cargado:");
            foreach(int e in array){
                Console.WriteLine(e);
            }
        }
    }
}
