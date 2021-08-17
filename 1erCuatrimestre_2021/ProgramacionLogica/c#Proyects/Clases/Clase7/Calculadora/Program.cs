using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            Console.Write("Elija opcion\n"+"1-Suma\n"+"2-Resta\n");
            opcion = Convert.ToInt16(Console.ReadLine());

            switch(opcion){
                case 1:
                    Suma(5,5);
                    break;
                case 2:
                    Resta(20,10);
                    break;
            }
        }

        static void Suma(int a, int b){
            int sum = a + b;
            Console.WriteLine("La suma de {0} + {1} es {2}", a,b,sum);
        }

        static void Resta(int a, int b){
            int res = a - b;
            Console.WriteLine("La resta de {0} - {1} es {2}", a,b,res);
        }

    }
}
