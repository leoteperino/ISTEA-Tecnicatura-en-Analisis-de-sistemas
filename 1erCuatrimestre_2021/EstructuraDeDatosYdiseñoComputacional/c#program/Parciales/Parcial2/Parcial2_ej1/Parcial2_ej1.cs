using System;

namespace Parcial2_ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            long numeroBase;
            long numeroExponente;

            Console.Clear();
            Console.WriteLine("========Calcular la Potencia de un Numero========");
            numeroBase = pedirNumeros("Ingrese número base: ");
            numeroExponente = pedirNumeros("Ingrese número exponente: ");
            Console.WriteLine("la potencia calculada de forma recursiva es: " + calcularPotenciaRecursiva(numeroBase,numeroExponente));
            Console.WriteLine("la potencia calculada con un while es: " + calcularPotenciaWhile(numeroBase,numeroExponente));
        }

        /*
        //Funcion pedirNumero
        //Funcion que pide un numero por consola y valida que sea correcto lo ingresado
        //Devuelve un long que es el Numero ingresado si este se valida correctamente, sino devuelde un error
        y pide el Numero nuevamente.
        //Tiene como parametro de entrada un String que es el mensaje a mostrar.  
        */
         static long pedirNumeros(string mensaje){
            bool esValido = true;
            long ret = 0;
            long numero = 0;
            do{
                try{
                    Console.Write(mensaje);
                    numero = int.Parse(Console.ReadLine());
                    esValido = true;
                    ret = numero;    
                }catch(Exception){
                    esValido = false;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("[ERROR]-Ingreso letras, puntos o comas");
                    Console.WriteLine("Pulse una tecla para continuar...");
                    Console.ReadKey(); 
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }while(!esValido);
                return ret;
        }

        /*
        //Funcion calcularPotenciaRecursiva
        //Funcion que calcula la potencia de un numero dado.
        //Devuelve un long que es el resultado de la potencia
        //Tiene como parametro de entrada un long que es el numero base y otro numero long que es la potencia  
        */
        static long calcularPotenciaRecursiva(long numeroBase, long numeroExponente){
            long ret;
            if(numeroExponente <= 0){
                ret = 1; 
            }else{
                ret = numeroBase*calcularPotenciaRecursiva(numeroBase, numeroExponente-1); 
            } 
            return ret;
        }

        /*
        //Funcion calcularPotenciaWhile
        //Funcion que calcula la potencia de un numero dado.
        //Devuelve un long que es el resultado de la potencia
        //Tiene como parametro de entrada un long que es el numero base y otro numero long que es la potencia  
        */
        static long calcularPotenciaWhile(long numeroBase, long numeroExponente){
            long ret=numeroBase;
            while(numeroExponente>1){
                ret = ret * numeroBase;
                numeroExponente--;
            }
            return ret;
        }
    }
}
