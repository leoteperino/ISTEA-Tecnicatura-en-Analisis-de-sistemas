using System;
using System.Collections.Generic;


namespace Ejer1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear ();
            //Ejemplo basico DO
            Console.WriteLine("");
            Console.WriteLine("╔══╗");
            Console.WriteLine("║DO║");
            Console.WriteLine("╚══╝");  
            int x=0;
            do{
             Console.Write(x+" ");
             x++;             
            }while(x<35); 

            //Ejemplo basico FOR
            Console.WriteLine("");
            Console.WriteLine("╔═══╗");
            Console.WriteLine("║FOR║");
            Console.WriteLine("╚═══╝");  
            
            for(int y=0;y<35;y++)
            {
            Console.Write(y+" ");
            }

              //Ejemplo basico WHILE
            Console.WriteLine("");
            Console.WriteLine("╔═════╗");
            Console.WriteLine("║WHILE║");
            Console.WriteLine("╚═════╝");

            x=0;
            while(x<35)
            {
                Console.Write(x+" ");
                x++;
            }

            //Ejemplo basico FOREACH
            Console.WriteLine("");
            Console.WriteLine("╔═══════╗");
            Console.WriteLine("║FOREACH║");
            Console.WriteLine("╚═══════╝");

            var numeros=new List<int> {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,120,108,111};

            foreach(int numero in numeros)
            {
             Console.Write(numero+" ");   
            }
            Console.WriteLine("\n");
        }
    }
}
