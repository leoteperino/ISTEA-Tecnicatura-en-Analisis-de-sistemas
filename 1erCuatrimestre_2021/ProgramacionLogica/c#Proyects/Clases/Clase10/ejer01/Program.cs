using System;

namespace ejer01
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena="Error de base de datos";
            mensajeError(cadena);
            mensajeError();            
        }

        static void mensajeError(string cadena="Errod Desconocido")
        {
            Console.WriteLine(cadena);
        }

    }
}
