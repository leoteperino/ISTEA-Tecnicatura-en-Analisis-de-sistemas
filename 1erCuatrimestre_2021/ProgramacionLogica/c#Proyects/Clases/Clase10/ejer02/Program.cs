using System;

namespace ejer02
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoError=1;
            mensajeError(codigoError);
            //mensajeError();
        }
        static void mensajeError(int error)
        {
            Console.Clear();
            if(error==0) 
                    Console.WriteLine("Error 0");
            else
                    Console.WriteLine("Error 1");

        }


    }
}
