using System;

namespace TareaNro6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Tomando como base el ejercicio realizado anteriormente(Calculadora) se deberá refactorizar 
            utilizando funciones para optimizar el código.
            */
            string operacionElegida;
            double numero1;
            double numero2;
            double resultado;

            operacionElegida = ImprimirMenu();
            numero1 = pedirNumeros();
            numero2 = pedirNumeros();
            resultado = calcularOperaciones(numero1, numero2, operacionElegida);
            
            Console.WriteLine("La operacion elegida es: {0}\n"+ 
                              "El primer numero ingresado es: {1}\n"+
                              "El segundo numero ingresado es: {2}\n"+
                              "El resultado es: {3}",
                              operacionElegida,
                              numero1,
                              numero2,
                              resultado);            
        }

        /*
        Imprimir menu muestra el menu y devuelve el dato ingresado ya validado
        No recibe ningun parametro
        Devuelve un string que es la operacion elegida
        Devuelve error si el dato ingresado no es el valido
        */
        static string ImprimirMenu(){
            bool esValido = true;
            string ret = "";
            do{
                try{
                    Console.Clear();
                    esValido = true;
                    char opcionMenu;
                    Console.WriteLine("---Ingrese la opcion deseada---\n"+
                                        "S-Suma\n"+
                                        "R-Resta\n"+
                                        "D-Division\n"+
                                        "M-Multiplicacion\n"+
                                        "E-Salir");
                    opcionMenu = char.Parse(Console.ReadLine());
                    opcionMenu = Char.ToLower(opcionMenu);
                    if(validarCharMenu(opcionMenu)==1){
                        string operacion;
                        operacion = devolverStringOpcionIngresada(opcionMenu);
                        ret = operacion;
                    }else if(validarCharMenu(opcionMenu)==0){
                        Environment.Exit(-1);
                    }else if(validarCharMenu(opcionMenu)==-1){
                        esValido = false;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("[ERROR]-Eligio una opcion que no esta en el menu.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Pulse una tecla para continuar...");
                        Console.ReadKey();
                    }
                }catch(Exception){
                    esValido = false;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("[ERROR]-Ingreso numeros o mas de una letra");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Pulse una tecla para continuar...");
                    Console.ReadKey();
                }
            }while(!esValido);
            return ret;  
        }

        //ValidarCharMenu valida la opcion de menu ingresada para cada caso
        //Recibe un char que es la opcion de Menu que se ingreso
        //Devielve un int // 1 si el dato es correcto // 0 si es salir // -1 si es incorrecto
        static int validarCharMenu(char opcionMenu){
            int ret = 0;
            switch(opcionMenu){
                case 's':
                case 'r':
                case 'd':
                case 'm':
                    ret = 1;
                    break;
                case 'e':
                    ret = 0;
                    break;
                default:
                    ret = -1;
                    break;
            }
            return ret;
        }

        //Mertodo que devuelve la operacion ingresada
        //Recibe un char que es la opcion de Menu ingresada
        //Devuelve el string que es el nombre de la operacion ingresada
        static string devolverStringOpcionIngresada(char opcionMenu){
            string respuesta = "";
            switch(opcionMenu){
                case 's':
                    respuesta = "Suma";
                    break;
                case 'r':
                    respuesta = "Resta";
                    break;
                case 'm':
                    respuesta = "Multiplicacion";
                    break;
                case 'd':
                    respuesta = "Division";
                    break; 
            }
            return respuesta;
        }

        //Metodo pedirNumeros pide un numero, lo valida y lo devuelve
        //No recibe parametros de entrada
        //Devuelve un double que es el numero ingresado
        static double pedirNumeros(){
            bool esValido = true;
            double ret = 0;
            double numero = 0;
            do{
                try{
                    Console.Clear();
                    Console.WriteLine("Ingrese un numero: ");
                    numero = double.Parse(Console.ReadLine());
                    esValido = true;
                    ret = numero;
                }catch(Exception){
                    esValido = false;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("[ERROR]-Ingreso letras");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Pulse una tecla para continuar...");
                    Console.ReadKey(); 
                }
            }while(!esValido);
            return ret;
        }

        //El metodo calcularOperaciones devuelve el resultado de las operaciones basicas
        //Recibe como parametros de entrada dos double que son los numeros ingresados para operar
        //y un String que es la operacion deseada a realizar
        //Devuelve un Double que es el resultado de dicha operacion
        static double calcularOperaciones(double numero1, double numero2, string operacionElegida){
            double ret = 0;
            if(operacionElegida!=null){
                switch(operacionElegida){
                    case "Suma":
                        ret = numero1 + numero2;
                        break;
                    case "Resta":
                        ret = numero1 - numero2;
                        break;
                    case "Division":
                        if(numero2==0){
                            Console.WriteLine("No es posible Dividir por 0!!");
                            Environment.Exit(-1);
                        }else{
                            ret = numero1/numero2;
                        }
                        break;
                    case "Multiplicacion":
                        ret = numero1 * numero2;
                        break;
                }
            }
            return ret;
        }
    } 
}
