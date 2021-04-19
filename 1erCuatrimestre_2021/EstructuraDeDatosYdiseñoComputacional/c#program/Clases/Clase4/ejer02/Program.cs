using System;

namespace ejer02
{
    class Program
    {
        static void Main(string[] args)
        {
        int[,] array_2d_int=new int[5,3] {{10,21,77} ,{55,42,12},{11,67,101},{23,27,120},{15,45,100}};          
         Console.Clear();

        for(int i=0;i<array_2d_int.GetLenght(0);i++)
        {
            for(int j=0;j<array_2d_int.GetLenght(1);j++)
            {
                if(array_2d_int[i,j]%2==0)
                {
                 Console.ForegroundColor=ConsoleColor.Red;
                 Console.Write("[{0},{1}] ={2}"+i,j,array_2d_int[i,j]+"\t");
                 Console.ResetColor();  
                }
                else
                {
                Console.Write("[{0},{1}] ={2}"+i,j,array_2d_int[i,j]+"\t");    
                }
            }   
            Console.WriteLine();
        }


        }
    }
}
