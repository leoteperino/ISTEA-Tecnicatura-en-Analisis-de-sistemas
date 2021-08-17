using System;

namespace Parcial1_Ejercicio2
{
    class Program
    {
        const double PI = 3.14;
        static void Main(string[] args)
        {
            //Declaracion e Inicializacion de variables
            int opcionMenu;
            bool esNum = true;
            bool esDouble = true;
            double superficie = 0;
            double altura = 0;
            double var_base = 0;
            double radio = 0;
            string figura_geometrica = "";
            string formula_superficie = "";

            //Menu de ingreso
            Console.Clear();
            do{
                Console.Clear();
                Console.Write("----------Calculador de Superficies----------\n"+
                              "1- Triangulo\n"+
                              "2- Rectangulo\n"+
                              "3- Cuadrado\n"+
                              "4- Circulo\n"+
                              "5- Salir\n"+
                              "----------------------------------------------\n"+
                              "Ingrese la opcion deseada: ");
                //Validamos que el dato ingresado sea el esperado
                esNum = int.TryParse(Console.ReadLine(), out opcionMenu);
                if(esNum){
                    //Procesamos los datos Ingresados en el Menu
                    switch(opcionMenu){
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                            //Me guardo en la variable que figura selecciono
                            switch(opcionMenu){
                                case 1:
                                    figura_geometrica = "Triangulo";
                                    formula_superficie = "(Base x Altura)/2";
                                    break;
                                case 2:
                                    figura_geometrica = "Rectangulo";
                                    formula_superficie = "Base x Altura";
                                    break;
                                case 3:
                                    figura_geometrica = "Cuadrado";
                                    formula_superficie = "Base x Base";
                                    break;
                                case 4:
                                    figura_geometrica = "circulo";
                                    formula_superficie = "PI x (Radio x Radio)";
                                    break;    
                            }
                            //Pido los datos necesarios para los calculos
                            do{
                                Console.Clear();
                                if(opcionMenu!=4){
                                    Console.Write("\n----------------------------------------------\n"+
                                                "Usted selecciono: **"+figura_geometrica+"**\n"+
                                                "Ingrese 0 si desea salir del programa\n"+
                                                "Ingrese la base: ");
                                    //Valido que el dato ingresado sea el esperado
                                    esDouble = double.TryParse(Console.ReadLine(), out var_base);
                                    if(esDouble){
                                        if(var_base==0){
                                            Console.ForegroundColor=ConsoleColor.DarkBlue;
                                            Console.Write("\n----------------------------------------------\n"+
                                                        "Saliendo.......\n"+
                                                        "----------------------------------------------\n");
                                            Console.ForegroundColor=ConsoleColor.White;
                                            Environment.Exit(-1);
                                        }
                                        //Si no es un cuadrado, pido la altura
                                        if(opcionMenu==1 || opcionMenu==2){
                                            do{
                                                Console.Clear();
                                                Console.Write("\n----------------------------------------------\n"+
                                                            "Usted selecciono: **"+figura_geometrica+"**\n"+
                                                            "La base ingresada es: **"+var_base+"**\n"+
                                                            "Ingrese 0 si desea salir del programa\n"+
                                                            "Ingrese la altura: ");
                                                //valido que el dato ingresado sea el correcto
                                                esDouble = double.TryParse(Console.ReadLine(), out altura);
                                                if(esDouble){
                                                    if(altura==0){
                                                        Console.ForegroundColor=ConsoleColor.DarkBlue;
                                                        Console.Write("\n----------------------------------------------\n"+
                                                                    "Saliendo.......\n"+
                                                                    "----------------------------------------------\n");
                                                        Console.ForegroundColor=ConsoleColor.White;
                                                        Environment.Exit(-1);
                                                    }
                                                    //Hago los calculos para triangulo y rectangulo
                                                    if(opcionMenu==1){
                                                        superficie = (var_base * altura) / 2;
                                                    }else{
                                                        superficie = var_base * altura;
                                                    }
                                                }else{
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.Write("\n----------------------------------------------\n"+
                                                    "[ERROR]-No puede ingresar letras.\n"+
                                                    "Solo puede ingresar numeros.\n"+
                                                    "Presione cualquier tecla para volver a intentarlo\n"+
                                                    "----------------------------------------------\n");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.ReadKey();
                                                }
                                            }while(!esDouble);
                                        }else if(opcionMenu == 3){
                                            //Calculos para el cuadrado
                                            superficie = var_base * var_base;
                                        }
                                    }else{
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.Write("\n----------------------------------------------\n"+
                                                    "[ERROR]-No puede ingresar letras.\n"+
                                                    "Solo puede ingresar numeros.\n"+
                                                    "Presione cualquier tecla para volver a intentarlo\n"+
                                                    "----------------------------------------------\n");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.ReadKey();  
                                    }
                                }else{
                                    //Es un circulo, pregunto por el radio
                                    Console.Clear();
                                    Console.Write("\n----------------------------------------------\n"+
                                                "Usted selecciono: **"+figura_geometrica+"**\n"+
                                                "Ingrese el Radio o 0 para Salir\n");
                                    esDouble = double.TryParse(Console.ReadLine(), out radio);
                                    if(esDouble){
                                        if(radio==0){
                                            Environment.Exit(-1);
                                        }else{
                                            superficie = PI * (radio*radio);
                                        }
                                    }else{
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.Write("\n----------------------------------------------\n"+
                                                    "[ERROR]-No puede ingresar letras.\n"+
                                                    "Solo puede ingresar numeros.\n"+
                                                    "Presione cualquier tecla para volver al Menu\n"+
                                                    "----------------------------------------------\n");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.ReadKey(); 
                                    }            
                                }
                            }while(!esDouble);
                            //Muestro los resultados
                            Console.ForegroundColor = ConsoleColor.DarkGreen;                            
                            Console.Write("\n----------------------------------------------\n"+
                                          "Figura Geometrica: **{0}**\n"+
                                          "Formula aplicada: {1}\n"+  
                                          "La superficie del {2} es: {3}\n"+
                                          "----------------------------------------------\n",
                                          figura_geometrica,
                                          formula_superficie,
                                          figura_geometrica,
                                          superficie);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Presione cualquier tecla para volver al Menu.");
                            Console.ReadKey();
                            break; 
                        case 5:
                            Console.ForegroundColor=ConsoleColor.DarkBlue;
                            Console.Write("\n----------------------------------------------\n"+
                                          "Saliendo.......\n"+
                                          "----------------------------------------------\n");
                            Console.ForegroundColor=ConsoleColor.White;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("\n----------------------------------------------\n"+
                                  "[ERROR]-Ingreso una opcion de Menu no valida.\n"+
                                  "Solo puede ingresar numeros del 1 al 5.\n"+
                                  "Presione cualquier tecla para volver al Menu\n"+
                                  "----------------------------------------------\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey();
                            break;
                    }
                }else{
                    //Si no ingresa numeros en la opcion Menu, se muestra este error
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("\n----------------------------------------------\n"+
                                  "[ERROR]-No puede ingresar letras.\n"+
                                  "Solo puede ingresar numeros del 1 al 5.\n"+
                                  "Presione cualquier tecla para volver al Menu\n"+
                                  "----------------------------------------------\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                }
            }while(opcionMenu!=5);

        }
    }
}
