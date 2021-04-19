using System;

namespace ejer03
{
    class Program
    {
        static void Main(string[] args)
        {
         int[,] notas1=new int[3,3];
         
         notas1[0,0]=1;
         notas1[0,1]=3;
         notas1[0,2]=45;

         notas1[1,0]=66;
         notas1[1,1]=8;
         notas1[1,2]=14;

         notas1[2,0]=16;
         notas1[2,1]=17;
         notas1[2,2]=18;   

         Console.Clear();

         /*   
         for(int i=0;i<notas1.GetLength(0);i++)
         {
            for(int j=0;j<3;j++)
            {
             Console.WriteLine("Valor: "+notas1[i,j]);
            }    
         }
        */

        foreach(int i in notas1)
                    Console.WriteLine("Valor: "+i);
        




        }
    }
}
