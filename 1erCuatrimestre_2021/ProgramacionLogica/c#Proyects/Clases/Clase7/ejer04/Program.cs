using System;

namespace ejer04
{
    class Program
    {
        static void Main(string[] args)
        {
            int op1=50;
            int op2=100;
            int res=0;


            res=Calcular(op1,op2);

            Console.Clear();
            Console.WriteLine("El valor de la Multiplicion es:"+res);
        }


        static int Calcular(int x,int y)
        {
            int aux;
            aux=x*y;
            return aux;
        }


    }
}
