using System;

namespace proyect3
{
    class Program
    {
        static void Main(string[] args)
        {

        //Definicion de un array Bidimensional [,] -> new int[4,2] -> 4 son las filas y 2 son las columnas   
        int[,] array_2d_int=new int[4,2] {{1,2} ,{3,4},{5,6},{7,8}};
        Console.Clear();
    
        for(int x=0;x<array_2d_int.GetLength(0);x++)
        {
            for(int y=0;y<array_2d_int.GetLength(1);y++)
            {
                Console.Write(array_2d_int[x,y]+"\t");
            } 
                Console.WriteLine("");   
        }
        

        //recorriendo un Array Bidimensional  
        // for(int x=0;x<4;x++)
        // {
        //     for(int y=0;y<2;y++)
        //     {
        //     Console.Write(array_2d_int[x,y]+"\t");
        //     } 
        //  Console.WriteLine("");   
        // }


        // string[,] array_2d_str = new string[3,2] { {"uno","dos"} , {"tres","cuatro"},{"Cinco","Seis"}                 };

        // for(int x=0;x<3;x++)
        // {
        //     for(int y=0;y<2;y++)
        //     {
        //         Console.Write(array_2d_str[x,y]+"  ");
        //     }
        //     Console.WriteLine("");
        // }












        }
    }
}
