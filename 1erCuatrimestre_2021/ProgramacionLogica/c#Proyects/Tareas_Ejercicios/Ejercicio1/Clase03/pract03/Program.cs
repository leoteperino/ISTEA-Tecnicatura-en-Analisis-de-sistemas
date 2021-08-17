using System;

namespace pract03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            char opcion;
            Console.Write("Ingresar Opcion :");
            opcion=Char.Parse(Console.ReadLine());
            opcion = Char.ToUpper(opcion);

            switch(opcion)
            {
                case 'A':
                Console.Write("LA opcion es A");
                break;

                case 'B':
                Console.Write("LA opcion es B");
                break;

                case 'C':
                Console.Write("LA opcion es C");
                break;

                default:
                Console.Write("Opcion Incorrecta");
                break;



            }







        }
    }
}
