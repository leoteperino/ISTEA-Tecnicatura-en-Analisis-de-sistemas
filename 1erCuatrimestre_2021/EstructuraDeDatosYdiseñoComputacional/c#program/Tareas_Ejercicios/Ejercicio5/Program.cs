using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
                Utilizando como base el Ejercicio Nro.4, recorrer todo el array y mostrar por pantalla, 
                pintado de color rojo, los numero pares y blancos los impares.
           */ 

           Console.Clear();
            int[,] array_2d_int=new int[5,3] {{10,21,77} ,{55,42,12},{11,67,101},{23,27,120},{15,45,100}};
            
            for(int x=0; x<array_2d_int.GetLength(0); x++){
                //Console.Write("Pos:"+x);
                for(int y=0; y<array_2d_int.GetLength(1); y++){
                    if(array_2d_int[x,y]%2==0){
                       Console.ForegroundColor = ConsoleColor.Red;
                       Console.Write(array_2d_int[x,y]+"\t"); 
                    }else{
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(array_2d_int[x,y]+"\t");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
