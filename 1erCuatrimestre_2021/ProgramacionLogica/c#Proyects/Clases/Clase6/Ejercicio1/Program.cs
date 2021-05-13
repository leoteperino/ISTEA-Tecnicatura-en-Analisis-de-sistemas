using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Segun un ciclo de iteración FOR imprimir por pantalla los valores 
           del índice entre el 40 y 45, ciclo del 1 al 100*/

           Console.Clear();
           for(int i=0; i<100; i++){
               if(i>=40 && i<= 45){
                   Console.WriteLine(i);
               }
           }  
        }
    }
}
