using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 2*/
            //Declaracion de Variables
            int num1;
            int num2;
            int resultado;

            //Pedir datos por pantalla y guardar lo ingresado en una variable
            Console.WriteLine("Ingrese numero 1: ");
            num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2: ");
            num2 = Convert.ToInt16(Console.ReadLine());

            //Efectuar la suma y Mostrar el resultado por pantalla
            resultado=num1+num2;
            Console.WriteLine("La suma de "+num1+" + "+num2+" es: "+resultado);
        }
    }
}
