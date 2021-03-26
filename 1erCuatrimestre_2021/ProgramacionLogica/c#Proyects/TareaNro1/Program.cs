using System;

namespace TareaNro1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Se requiere armar una aplicación consola que dados 2 valores del tipo del tipo decimal ingresados por el 
            usuario genere las 4 operaciones básicas, que deberán también solicitarse por pantalla,
            S – Suma, R – Resta, D – División y M – Multiplicación.
            EL resultado deberá mostrarse con su respectiva leyenda.
            */

            //Declaracion de variables
            double numero1;
            double numero2;
            double resultado;
            char opcionMenu;

            //Menu de pantalla
            Console.WriteLine("---Ingrese la opcion deseada---\nS-Suma\nR-Resta\nD-Division\nM-Multiplicacion");
            opcionMenu = Convert.ToChar(Console.ReadLine());
            
            //Operaciones
            if(opcionMenu=='S' || opcionMenu=='s'){
                Console.WriteLine("**Suma**");
                Console.WriteLine("Ingrese el primer numero: ");
                numero1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero: ");
                numero2 = Convert.ToDouble(Console.ReadLine());
                resultado = numero1 + numero2;
                Console.WriteLine("El resultado de "+numero1+" + "+numero2+" es: "+resultado);
            }

            if(opcionMenu=='R' || opcionMenu=='r'){
                Console.WriteLine("**Resta**");
                Console.WriteLine("Ingrese el primer numero: ");
                numero1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero: ");
                numero2 = Convert.ToDouble(Console.ReadLine());
                resultado = numero1 - numero2;
                Console.WriteLine("El resultado de "+numero1+" - "+numero2+" es: "+resultado);
            }

            if(opcionMenu=='D' || opcionMenu=='d'){
                Console.WriteLine("**Suma**");
                Console.WriteLine("Ingrese el primer numero: ");
                numero1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero: ");
                numero2 = Convert.ToDouble(Console.ReadLine());
                if(numero1==0){
                    Console.WriteLine("Ningun numero es divisible por cero");
                }else{
                    resultado = numero1 / numero2;
                    Console.WriteLine("El resultado de "+numero1+" / "+numero2+" es: "+resultado);
                }
            }

            if(opcionMenu=='M' || opcionMenu=='m'){
                Console.WriteLine("**Multiplicacion**");
                Console.WriteLine("Ingrese el primer numero: ");
                numero1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero: ");
                numero2 = Convert.ToDouble(Console.ReadLine());
                resultado = numero1 * numero2;
                Console.WriteLine("El resultado de "+numero1+" * "+numero2+" es: "+resultado);
            }
        }
    }
}
