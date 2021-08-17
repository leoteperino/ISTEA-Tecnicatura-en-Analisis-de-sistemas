using System;

namespace pract02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int opcion;
            Console.Write("Ingrese Opcion: ");
            opcion=Int32.Parse(Console.ReadLine());

            //switch

            switch(opcion)
            {
                case 1:
                Console.WriteLine("La opcion Ingresada es 1");
                break;

                case 2:
                Console.WriteLine("La opcion Ingresada es 2");
                break;

                case 3:
                Console.WriteLine("La opcion Ingresada es 3");
                break;

                default:
                Console.WriteLine("La opcion Ingresada no es valida");
                break;
            }






        }
    }
}
