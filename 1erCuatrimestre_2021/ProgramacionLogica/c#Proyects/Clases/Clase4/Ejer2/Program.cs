using System;

namespace Ejer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int valor=0;
            do{
                  if(valor%2==0)
                  {
                    Console.ForegroundColor=ConsoleColor.Blue;
                    Console.Write(valor);
                    Console.ForegroundColor=ConsoleColor.White;
                    Console.Write("-");                    
                  }  
                  else
                  {
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.Write(valor);
                    Console.ForegroundColor=ConsoleColor.White;
                    Console.Write("-");  
                  }
                   valor++; 
            }while(valor<5100);
            Console.WriteLine("\n");    
        }
    }
}
