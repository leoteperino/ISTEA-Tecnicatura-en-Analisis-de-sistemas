using System;

namespace TareaNro7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1-Realizar una aplicación consola que permita el ingreso por pantalla de 2 números enteros y devuelva 
            la multiplicación de los mismo, luego se deberá pasar ese valor a otra función que imprima por pantalla el resultado.
            */
            int numero1Ingresado;
            int numero2Ingresado;
            int multiplicacion;

            numero1Ingresado = pedirNumerosEnteros();
            numero2Ingresado = pedirNumerosEnteros();
            multiplicacion = hacerMultiplicacion(numero1Ingresado, numero2Ingresado);
            mostrarResultadoMultiplicacion(multiplicacion);
        }

        static int pedirNumerosEnteros(){
            bool esValido = true;
            int ret = 0;
            int numero = 0;
            do{
                try{
                    Console.Clear();
                    Console.WriteLine("Ingrese un numero: ");
                    numero = int.Parse(Console.ReadLine());
                    esValido = true;
                    ret = numero;
                }catch(Exception){
                    esValido = false;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("[ERROR]-Ingreso letras o un numero decimal.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Pulse una tecla para continuar...");
                    Console.ReadKey(); 
                }
            }while(!esValido);
                return ret;
        }

        static int hacerMultiplicacion(int numero1, int numero2){
            int ret = 0;
            ret = numero1 * numero2;
            return ret;
        }

        static void mostrarResultadoMultiplicacion(int resultado){
            Console.WriteLine("El resultado de la multiplicacion es: "+ resultado);
        }
    }
}
