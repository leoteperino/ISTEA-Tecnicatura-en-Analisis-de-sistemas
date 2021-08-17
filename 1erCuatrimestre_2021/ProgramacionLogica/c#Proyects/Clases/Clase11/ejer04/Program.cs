using System;

namespace ejer04
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro=0;
            do{
                Console.Clear();
                Console.WriteLine("Ingrese un numero decimal:");
                nro=Int32.Parse(Console.ReadLine());
                calcular(nro);
            }while(nro!=0);
        }


        static void calcular(int numero)
        {
        int aux;
        string binary=string.Empty;


        while(numero>0)
        {
            aux=numero%2;
            numero/=2;
            binary=aux.ToString()+binary;
        }

        Console.WriteLine("El numero en Binario es:"+binary);
        Console.ReadLine();
        }


    }
}
