using System;

namespace Ejer4
{
    class Program
    {
        static void Main(string[] args)
        {
           string pass;
           char esp1='?';
           char esp2='*';
           char esp3='!';
           int TieneEsp=0;
             
        do{
            Console.Clear();
            Console.Write("Ingrese Password: ");
            pass=Console.ReadLine();
           
            for(int x=0;x<pass.Length;x++)
            {
               if(pass[x]==esp1 || pass[x]==esp2 || pass[x]==esp3  )  
               {
                   TieneEsp=1;
               }   

            }

            if(TieneEsp!=1 || pass.Length<8)
            {
                Console.WriteLine("EL password No Cumple con la seguridad");
                Console.ReadKey();
            }
        }while(TieneEsp!=1 || pass.Length<8);
             
             Console.WriteLine("EL password con seguridad");
                   






        }
    }
}
