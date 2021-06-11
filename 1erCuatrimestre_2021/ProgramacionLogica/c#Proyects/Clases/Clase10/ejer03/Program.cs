using System;

namespace ejer03
{
    class Program
    {
        static void Main(string[] args)
        {
                int[,] array1 = { { 1, 2 }, { 2, 3 }, { 3, 4 } };
                string cadena1="Los datos del array son:";  
                Imprimir(array1);
                //Imprimir(array1,cadena1);       
        }


        static void Imprimir(int[,] array1,string texto="Valores:")
        {
            Console.Clear();
            Console.WriteLine(texto);
                foreach(var x in array1)
                {


                    Console.WriteLine(x);
                }

        }


    }
}
