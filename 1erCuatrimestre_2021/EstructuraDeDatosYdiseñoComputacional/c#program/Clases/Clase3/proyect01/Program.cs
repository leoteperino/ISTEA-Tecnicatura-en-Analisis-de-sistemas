using System;

namespace proyect01
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Clear();
        Console.WriteLine("FOR");
       
        string[] nombres={"Juan","Pedro","Alberto"};


        for(int x=0;x<12;x++)
        {
            Console.WriteLine("Elemento:"+array1[x]+" POS:["+x+"]");
        }
        Console.ReadKey();

        Console.Clear();
        Console.WriteLine("FOREACH");       

        foreach (var numero in array1)
        {
            Console.WriteLine("Elemento="+numero);
        }

      
        for(int x=0;x<3;x++)
        {
            Console.WriteLine("Elemento:"+nombres[x]);
        }


        }
    }
}
