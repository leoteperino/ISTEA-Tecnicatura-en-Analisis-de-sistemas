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

            do{
                //Menu de pantalla
                Console.WriteLine("---Ingrese la opcion deseada---\nS-Suma\nR-Resta\nD-Division\nM-Multiplicacion\nE-Salir");
                opcionMenu = Convert.ToChar(Console.ReadLine());
                opcionMenu = Char.ToLower(opcionMenu);
                //Validacion de solo letras
                if(opcionMenu < 'a' || opcionMenu > 'z'){
                    Console.WriteLine("ERROR - No ingreso una letra");
                }

                //Operaciones
                switch(opcionMenu){
                    case 's':
                        Console.WriteLine("**Suma**");
                        Console.WriteLine("Ingrese el primer numero: ");
                        numero1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero: ");
                        numero2 = Convert.ToDouble(Console.ReadLine());
                        resultado = numero1 + numero2;                        
                        Console.WriteLine("El resultado de "+numero1+" + "+numero2+" es: "+resultado);
                        break;
                    case 'r':
                        Console.WriteLine("**Resta**");
                        Console.WriteLine("Ingrese el primer numero: ");
                        numero1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero: ");
                        numero2 = Convert.ToDouble(Console.ReadLine());
                        resultado = numero1 - numero2;                        
                        Console.WriteLine("El resultado de "+numero1+" - "+numero2+" es: "+resultado);
                        break;
                    case 'm':
                        Console.WriteLine("**Multiplicacion**");
                        Console.WriteLine("Ingrese el primer numero: ");
                        numero1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero: ");
                        numero2 = Convert.ToDouble(Console.ReadLine());
                        resultado = numero1 * numero2;
                        Console.WriteLine("El resultado de "+numero1+" * "+numero2+" es: "+resultado);
                        Console.WriteLine("//////////////////////////////////////////////////////////");
                        break;
                    case 'd':
                        Console.WriteLine("**Suma**");
                        Console.WriteLine("Ingrese el primer numero: ");
                        numero1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero: ");
                        numero2 = Convert.ToDouble(Console.ReadLine());
                        if(numero2==0){
                            Console.WriteLine("Ningun numero es divisible por cero");
                            Console.WriteLine("//////////////////////////////////////////////////////////");
                        }else{
                            resultado = numero1 / numero2;
                            Console.WriteLine("El resultado de "+numero1+" / "+numero2+" es: "+resultado);
                            Console.WriteLine("//////////////////////////////////////////////////////////");
                        }
                        break;
                    case 'e':
                        Console.WriteLine("Gracias por usar la calculadora");
                        break;
                    default:
                        Console.WriteLine("Usted no han ingresado una opcion valida.");
                        Console.WriteLine("//////////////////////////////////////////////////////////");
                        break;
                }     
            }while(opcionMenu != 'e');
        }
    }
}
