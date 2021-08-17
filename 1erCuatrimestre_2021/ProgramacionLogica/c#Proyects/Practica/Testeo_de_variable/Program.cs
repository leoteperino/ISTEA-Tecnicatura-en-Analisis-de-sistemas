using System;

namespace Testeo_de_variable
{
    class Program
    {
        static void Main(string[] args)
        {
           double resultado = 0;
           double num1 = 5;
           double num2 = 5;
           double opcion = 1;

           switch(opcion){
               case 1:
                resultado = num1 + num2;
                break;
           }

           Console.WriteLine(resultado);
        }
    }
}
