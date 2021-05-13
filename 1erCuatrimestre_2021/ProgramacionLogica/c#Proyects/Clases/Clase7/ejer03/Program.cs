using System;

namespace ejer03
{
    class Program
    {
        static void Main(string[] args)
        {
        /*Procedimientos*/
        ImprimirEncabezado();
        //calcular();


        string clase="Operadores Logicos";
        int nroClase=5;
        ImprimirEncabezadoConDatos(clase,nroClase);

        }


        static void ImprimirEncabezadoConDatos(string c,int n)
        {
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth-c.Length)/2,Console.CursorTop);
            Console.WriteLine(c);
            Console.WriteLine("Nro. Clase es:"+n);
            Console.ReadKey();
        }



















        static void calcular()
        {
        Console.WriteLine("----------");
        int aux,y,x;
        x=30;
        Console.Write("Ingrese valor y:");
        y=Int32.Parse(Console.ReadLine());
        aux=x*y;
        Console.WriteLine("El calculo es:"+aux);
        Console.ReadKey();
        }




        static void ImprimirEncabezado()
        {
            Console.Clear();
            Console.WriteLine("Programacion Logica");
            Console.WriteLine("-------------------");
            
        }


        static void error()
        {
            //Console.Clear();
            Console.WriteLine("Alguno de los datos ingresado no es valido");
        }


    }
}
