using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Dada el siguiente array bidimensional , mostrar por pantalla los valores y las posiciones en que están cargados
                también resaltar en color rojo el valor y posición del numero 27.

                Array Bidireccional:

                int[,] array_2d_int=new int[5,3] {{10,21,77} ,{55,42,12},{11,67,101},{23,27,120},{15,45,100}};           

                Instrucción para aplicar color al texto:
                Console.ForegroundColor = ConsoleColor.Red;
            */
            Console.Clear();
            int[,] array_2d_int=new int[5,3] {{10,21,77} ,{55,42,12},{11,67,101},{23,27,120},{15,45,100}};
            
            for(int x=0; x<array_2d_int.GetLength(0); x++){
                //Console.Write("Pos:"+x);
                for(int y=0; y<array_2d_int.GetLength(1); y++){
                    if(array_2d_int[x,y]==27){
                       Console.ForegroundColor = ConsoleColor.Red;
                       Console.Write("Pos:["+x+","+y+"]"+"="+array_2d_int[x,y]+"\t"); 
                    }else{
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Pos:["+x+","+y+"]"+"=");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(array_2d_int[x,y]+"\t");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
