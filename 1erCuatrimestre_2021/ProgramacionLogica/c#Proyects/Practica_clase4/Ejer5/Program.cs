using System;

namespace Ejer5
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass;
            string expresion="@_*?!+-N";
            int TieneEsp=0;
    do{
            Console.Clear();
            Console.Write("Ingrese pass: ");
            pass=Console.ReadLine();

            for(int x=0;x<pass.Length;x++)
            {
                 for(int y=0;y<expresion.Length;y++)
                 {
                     if(pass[x]==expresion[y])
                     {
                         TieneEsp=1;
                     }

                 }   
            }

            


            if(TieneEsp!=1 || pass.Length<8)
            {
                Console.WriteLine("Error");
                Console.ReadKey();
            }

    }while(TieneEsp!=1 || pass.Length<8);

    Console.WriteLine("Password Correcto");



                


        }
    }
}
