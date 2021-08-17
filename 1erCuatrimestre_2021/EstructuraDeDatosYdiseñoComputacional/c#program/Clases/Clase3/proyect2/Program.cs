using System;

namespace proyect2
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            Console.Clear();
            string oracion="1101 0011 1010 1100 1001 0001 1000 1000 1100 0011 1100 0011 1100";
            int contador1=0;
            int contador2=0;
            

            for(int y=0;y<oracion.Length;y++)
            {
               if(oracion[y]=='0')
               {
                   contador1++;
               }
               if(oracion[y]=='1')
               {
                   contador2++;
               }               
            }
            Console.WriteLine("Contador de 0:"+contador1);
            Console.WriteLine("Contador de 1:"+contador2);
            */
                
            Console.Clear();
            int[] valores=new int[20];
            Random nrd=new Random();


            for(int x=0;x<valores.Length;x++)
            {
               valores[x]=nrd.Next(100,200);
               Console.WriteLine("Pos. ["+x+"]:"+valores[x]);
            }    

            int maximo=0;

            for(int x=0;x<valores.Length;x++)
            {
                if(valores[x]>maximo)
                {
                    maximo=valores[x];
                }
            }
            Console.WriteLine("Maximo ="+maximo);


            int minimo=maximo;

            for(int x=0;x<valores.Length;x++)
            {
                if(valores[x]<minimo)
                {
                    minimo=valores[x];
                }
            }

            Console.WriteLine("Minimo ="+minimo);








        }
    }
}
