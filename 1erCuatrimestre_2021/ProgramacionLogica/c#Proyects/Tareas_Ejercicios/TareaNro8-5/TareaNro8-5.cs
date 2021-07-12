using System;

namespace TareaNro8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*enviar a una función un array bidimencional y un numero entero y 
            la función deberá devolver  "Dato Encontrado" si el dato esta dentro del array.*/
            int [,] arrayBi = {{1,2},{3,4},{5,6}};
            int numeroEntero = 6;
            string respuesta = "";
            respuesta=buscarNumero(arrayBi,numeroEntero);
            Console.WriteLine(respuesta);
        }

        static string buscarNumero(int [,] array, int numero){
            string res = "Dato no encontrado";
            for(int x=0;x<array.GetLength(0);x++){
                for(int y=0;y<array.GetLength(1);y++){
                    if(array[x,y].Equals(numero)){
                        res="Dato encontrado";
                    }
                }      
            }
            return res;
        }
    }
}
