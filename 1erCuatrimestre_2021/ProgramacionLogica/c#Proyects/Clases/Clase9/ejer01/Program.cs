using System;

namespace ejer01
{
    class Program
    {
        static void Main(string[] args)
        {
            int NroEjercicio=1;
            int opc=0;
            int valor1=50,valor2=0;
            ImprimirTitulo(NroEjercicio);
            opc=ImprimirMenu();
            CalcularyMostrar(valor1,valor2,opc);
        }

        static void ImprimirTitulo(int Nro)
        {
            Console.Clear();
            Console.WriteLine("Clase Nro 9 Ejercicio Nro:"+Nro);
            Console.WriteLine("**************************");
            Console.ReadKey();
        }

        static  int ImprimirMenu()
        {
            int opcion=0;
            Console.WriteLine("1-Suma:");
            Console.WriteLine("2-Resta:");
            Console.WriteLine("3-Multiplicacion:");
            Console.WriteLine("4-Division:");
            opcion=Int32.Parse(Console.ReadLine());
            return opcion;
        }

        static void CalcularyMostrar(int numero1,int numero2, int opcion)
        {
            switch(opcion)
            {
                case 1:
                        Console.WriteLine("Sumo");
                        break;
                case 2:
                        Console.WriteLine("Resta");
                        break;
                case 3:
                        Console.WriteLine("Multiplicacion");
                        break;
                case 4:
                        Console.WriteLine("Division:"+(numero1/numero2));
                        break;
                default:
                        Console.WriteLine("Otro");
                        break;
            }

        }

    }
}
