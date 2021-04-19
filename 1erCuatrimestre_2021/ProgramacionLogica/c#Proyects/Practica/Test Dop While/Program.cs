using System;

namespace Test_Dop_While
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcionMenu;
            double numero1;
            double numero2;
            double resultado;

            do{
                Console.WriteLine("---Ingrese la opcion deseada---\nS-Suma\nR-Resta\nD-Division\nM-Multiplicacion\nE-Salir");
                opcionMenu = Convert.ToChar(Console.ReadLine());
                opcionMenu = Char.ToLower(opcionMenu);
                //Validacio de solo letras
                if(opcionMenu < 'a' || opcionMenu > 'z'){
                    Console.WriteLine("ERROR - No ingreso una letra");
                }

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
                    break;
                case 'd':
                    Console.WriteLine("**Suma**");
                    Console.WriteLine("Ingrese el primer numero: ");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero: ");
                    numero2 = Convert.ToDouble(Console.ReadLine());
                    if(numero2==0){
                        Console.WriteLine("Ningun numero es divisible por cero");
                    }else{
                        resultado = numero1 / numero2;
                        Console.WriteLine("El resultado de "+numero1+" / "+numero2+" es: "+resultado);
                    }
                    break;
                default:
                    Console.WriteLine("Usted no han ingresado una opcion valida.");
                    break;
                }
            }while(opcionMenu!='e');

            Console.Write("Presiones cualquier letra para salir");
            Console.ReadKey();
        }
    }
}
