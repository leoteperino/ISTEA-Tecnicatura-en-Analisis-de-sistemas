using System;

namespace ejer04
{
    class Program
    {
        static void Main(string[] args)
        {
            char [,] array_2d_char=new char [5,3]{{'N','i','c'},{'o','l','a'},{'s',' ',' '},{'M','a','n'},{'u','e','l'}};
            string nombre="Nicolas Manuel";

            foreach(var x in array_2d_char)
                Console.Write(x);

            //Console.WriteLine(nombre);    


        }
    }
}
