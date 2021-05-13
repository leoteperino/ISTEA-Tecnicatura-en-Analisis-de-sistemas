using System;

namespace Parcial1_Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion e inicializacion de variables
            Random number = new Random();
            int[,] array_bingo=new int[3,9];
            int numero_cargado1 = 0;
            int numero_cargado2 = 0;
            bool esNum;
            int numero_carton = 1;
            bool esNumero1_bingo = false;
            bool esNumero2_bingo = false;

            do{
                Console.Clear();
                Console.WriteLine(  "====================Bienvenidos al BINGO==========================\n"+
                                    "=======================CARTON NRO {0}===============================\n",
                                    numero_carton++);

                //cargo array con Numeros Random
                for(int x=0; x<array_bingo.GetLength(0); x++){
                    for(int y=0; y<array_bingo.GetLength(1); y++){
                        array_bingo[x,y]=number.Next(1,11);
                    }
                }
                
                //Muestro datos del array
                for(int x=0; x<array_bingo.GetLength(0); x++){
                    for(int y=0; y<array_bingo.GetLength(1); y++){
                        Console.Write(array_bingo[x,y]+"\t");
                    }
                    Console.WriteLine("");
                }

                do{
                    //Pido el numero 1
                    Console.Write("\n======================================\n"+
                                "[Ingrese 0 para salir del Programa]\n"+
                                "Ingrese el 1er Numero(del 1 al 10): ");
                    esNum=int.TryParse(Console.ReadLine(), out numero_cargado1);
                    if(esNum){
                    //Valido que el numero ingresado este dentro del rango del 1 al 10
                        if(numero_cargado1>10){
                            esNum = false;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("--------------------------------------------------\n"+
                                        "[ERROR]-Usted ingreso numeros fuera del rango del 1 al 10\n"+
                                        "Ingrese numeros solo del 1 al 10.\n"+
                                        "--------------------------------------------------\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Presione cualquier tecla para volver a intentarlo");
                            Console.ReadKey();
                        }else if(numero_cargado1 == 0){
                            //Si el numero cargado es igual a 0, salgo del programa 
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("--------------------------------------------------\n"+
                                        "Saliendo....................\n"+ 
                                        "--------------------------------------------------\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Environment.Exit(-1);
                        }
                    }else{
                        //Si no ingresa un numero se muestra un error
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("--------------------------------------------------\n"+
                                    "[ERROR]-Usted Ingreso letras-solo se pueden ingresar numeros del 1 al 10\n"+
                                    "--------------------------------------------------\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Presione cualquier tecla para volver a intentarlo");
                        Console.ReadKey();
                    }   
                }while(!esNum);

                do{
                    //Si esta validado el ingreso del primer numero, pido el segundo numero
                    Console.Write("\n======================================\n"+
                                    "[Ingrese 0 para salir del Programa]\n"+
                                    "Ingrese el 2do Numero(del 1 al 10): ");
                    esNum=int.TryParse(Console.ReadLine(), out numero_cargado2);
                    if(esNum){
                        //Valido que el numero ingresado este dentro del rango
                        if(numero_cargado2>10){
                            esNum = false;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("--------------------------------------------------\n"+
                                        "[ERROR]-Usted ingreso numeros fuera del rango del 1 al 10\n"+
                                        "Ingrese numeros solo del 1 al 10.\n"+
                                        "--------------------------------------------------\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Presione cualquier tecla para volver a intentarlo");
                            Console.ReadKey();
                        }else if(numero_cargado2 == numero_cargado1){
                            //Si los nuemros cargados se repiten, muestro error
                            esNum = false;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("--------------------------------------------------\n"+
                                        "[ERROR]-Los numeros cargados no pueden ser iguales.\n"+
                                        "--------------------------------------------------\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Presione cualquier tecla para volver a intentarlo");
                            Console.ReadKey();
                        }else if(numero_cargado2 == 0){
                            //Si el numero cargado es igual a 0, salgo del programa 
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("--------------------------------------------------\n"+
                                        "Saliendo....................\n"+ 
                                        "--------------------------------------------------\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Environment.Exit(-1);
                        } 
                    }else{
                        //Si no ingresa un numero se muestra un error
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("--------------------------------------------------\n"+
                                    "[ERROR]-Usted Ingreso letras-solo se pueden ingresar numeros del 1 al 10\n"+
                                    "--------------------------------------------------\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Presione cualquier tecla para volver a intentarlo");
                        Console.ReadKey();
                    }
                }while(!esNum);

                //Aca ya tengo los dos numeros cargados
                //Cominezo a procesar los datos y a mostrar resultados
                //Muestro los numeros elegidos    
                Console.Clear();
                Console.WriteLine("\n==========Buscando Coincidencias==========\n\n"+
                                    "**Numeros Cargados: {0} y {1}", 
                                    numero_cargado1,
                                    numero_cargado2);

                /*Aca realizo la logica para saber si el numero elegido esta dentro del array de numeros
                Si alguno de los numeros esta cargado, cargo una variable booleana en true*/
                for(int x=0; x<array_bingo.GetLength(0); x++){
                    for(int y=0; y<array_bingo.GetLength(1); y++){
                        if(array_bingo[x,y]==numero_cargado1){
                            esNumero1_bingo=true;
                        } 
                        if(array_bingo[x,y]==numero_cargado2){
                            esNumero2_bingo=true;
                        }
                    }
                }

                //Muestro datos del array cragado previamente
                Console.WriteLine("\n=======================CARTON JUGADO===============================\n");
                for(int x=0; x<array_bingo.GetLength(0); x++){
                    for(int y=0; y<array_bingo.GetLength(1); y++){
                        Console.Write(array_bingo[x,y]+"\t");
                    }
                    Console.WriteLine("");
                }

                //Si ambas variables booleanas estan en true, es porque hay coincidencia
                //Recorro el Array nuevamente y pinto de color rojo los numeros que coinciden
                //Lo muestro por pantalla si es Bingo, sino aviso que no hay coincidencia
                if(esNumero1_bingo && esNumero2_bingo){
                    Console.WriteLine("\n=======================CARTON GANADOR===============================\n");

                    for(int x=0; x<array_bingo.GetLength(0); x++){
                        for(int y=0; y<array_bingo.GetLength(1); y++){
                            if(array_bingo[x,y]==numero_cargado1 || array_bingo[x,y]==numero_cargado2){
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(array_bingo[x,y]+"\t");
                            }else{
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write(array_bingo[x,y]+"\t");
                            }
                        }
                        Console.WriteLine("");
                    }
                    
                    Console.ForegroundColor=ConsoleColor.White;    
                    Console.WriteLine("\nEs Bingo, ambos numeros estan en la grilla!!!\n"+
                                      "Presione cualquier tecla para jugar de nuevo");
                    Console.ReadKey();
                }else{
                    Console.WriteLine("\nNo hay coincidencias.\nPresione cualquier tecla para volver a intentar");
                    Console.ReadKey();
                }

                //Vuelvo las variable booleanes a false, porque sino quedan siempre en true
                esNumero1_bingo = false;
                esNumero2_bingo = false;
            }while(numero_cargado1!=0 || numero_cargado2!=0);
        }
    }
}
