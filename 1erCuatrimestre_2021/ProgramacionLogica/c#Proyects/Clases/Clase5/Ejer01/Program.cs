using System;

namespace Ejer01
{
    class Program
    {
        static void Main(string[] args)
        {
        //Acumulador basico
        double importe=100;
        double importe2=100;
        int dias=15;
        Console.Clear();
                
        for(int x=0;x<dias;x++)
        {
            
            importe=importe+x;
            importe2=importe+dias;
        }

        Console.WriteLine("Importe 1:"+importe);
        Console.WriteLine("Importe 2:"+importe2);


        }
    }
}
