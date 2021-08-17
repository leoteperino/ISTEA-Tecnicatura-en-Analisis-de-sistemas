using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 3*/
            //Declaracion de variables
            int num1;
            int num2;
            int suma;
            int resta;
            int division;
            int multiplicacion;

            //Pedir datos y guardarlos en las variables
            Console.WriteLine("Ingrese el numero 1: ");
            num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2: ");
            num2 = Convert.ToInt16(Console.ReadLine());

            //Operaciones
            suma=num1+num2;
            resta=num1-num2;
            multiplicacion=num1*num2;
            division=num1/num2;

            //Mostrar resultados
            Console.WriteLine("La suma de los numeros es: "+suma);
            Console.WriteLine("La resta de los numeros es: "+resta);
            Console.WriteLine("La multiplicacion de los numeros es: "+multiplicacion);
            Console.WriteLine("La division de los numeros es: "+division);
        }
    }
}
