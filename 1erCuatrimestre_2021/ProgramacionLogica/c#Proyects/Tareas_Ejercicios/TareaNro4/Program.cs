using System;

namespace TareaNro4
{
    class Program
    {
        const int ARRAY_LEN = 45;
        static void Main(string[] args)
        {
            /*
            Dados 45 empleados de una empresa, ingresar legajo, sueldo y sexo (1=femenino y 2=masculino) mostrar cuantos 
            empleados ganan mas de $70.000, mostrar cantidad de mujeres y hombres y el sueldo promedio por cada genero.
            */
            int optionMenu = 0;
            int legajo = 0;
            int sexo = 0;
            char auxSexo;
            double sueldo = 0;
            bool esInt = true;
            double promedio = 0;
            int contadorSueldos = 0;
            int contadorHombres = 0;
            int contadorMujeres = 0;
            int[] arrayLegajos = new int[ARRAY_LEN];
            double[] arraySueldos = new double[ARRAY_LEN];
            char[] arraySexo = new char[ARRAY_LEN]; 

            Console.Clear();
            Console.WriteLine("******************************");

            /*-*-*-*-*-*-*-*Carga y validacion de Legajos-*-*-*-*-*-*-**/
            do{
                for(int i=0; i<arrayLegajos.Length; i++){
                    Console.Write("Ingresar legajo[0-45]Pos[{0}]: ",i+1);
                    esInt = int.TryParse(Console.ReadLine(), out legajo);
                    if(esInt){
                        if(legajo>45){
                            Console.ForegroundColor=ConsoleColor.DarkRed;
                            Console.WriteLine( "[ERROR]-Ingreso un numero fuera de rango\nIngrese un numero no mayor a 45\n");
                            Console.ForegroundColor=ConsoleColor.White;
                            esInt=false;
                            break;
                        }else{
                            arrayLegajos[i]=legajo;        
                        }         
                    }else{
                        Console.ForegroundColor=ConsoleColor.DarkRed;
                        Console.WriteLine( "[ERROR]-No ingreso una opcion valida\n");
                        Console.ForegroundColor=ConsoleColor.White;
                        break;
                    }  
                }
            }while(!esInt);
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("\nLegajos cargados con exito!!");
            Console.WriteLine("Lista de Legajos cargados:");
            for(int i = 0; i<arrayLegajos.Length; i++){
                Console.WriteLine("Pos[{0}]-Legajo[{1}]", i, arrayLegajos[i]);
            }
            Console.ForegroundColor=ConsoleColor.White;
            Console.WriteLine("******************************\n");

             /*-*-*-*-*-*-*-*Carga y validacion de Sueldos-*-*-*-*-*-*-**/
            do{
                for(int i=0; i<arraySueldos.Length; i++){
                    Console.Write("Ingresar Sueldo[Mayor a $10000]Pos[{0}]:$",i+1);
                    esInt = double.TryParse(Console.ReadLine(), out sueldo);
                    if(esInt){
                        if(sueldo==0 || sueldo < 10000){
                            Console.ForegroundColor=ConsoleColor.DarkRed;
                            Console.WriteLine( "[ERROR]-Ingreso un sueldo fuera de rango\nIngrese un sueldo mayor a $10.000\n");
                            Console.ForegroundColor=ConsoleColor.White;
                            esInt=false;
                            break;
                        }else{
                            arraySueldos[i]=sueldo;      
                        }               
                    }else{
                        Console.ForegroundColor=ConsoleColor.DarkRed;
                        Console.WriteLine( "[ERROR]-No ingreso una opcion valida\n");
                        Console.ForegroundColor=ConsoleColor.White;
                        break;
                    }
                }
            }while(!esInt);
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("\nSueldos cargados con exito!!");
            Console.WriteLine("Lista de Sueldos cargados:");
            for(int i = 0; i<arraySueldos.Length; i++){
                Console.WriteLine("Pos[{0}]-Sueldo[${1}]", i, arraySueldos[i]);
            }
            Console.ForegroundColor=ConsoleColor.White;
            Console.WriteLine("******************************\n");

             /*-*-*-*-*-*-*-*Carga y validacion de Sexo-*-*-*-*-*-*-**/
            do{
                for(int i=0; i<arraySexo.Length; i++){
                    Console.Write("Ingresar Sexo[1:Femenino-2:Masculino]Pos[{0}]: ",i+1);
                    esInt = int.TryParse(Console.ReadLine(), out sexo);
                    if(esInt){
                        if(sexo<=0 || sexo>=3){
                            Console.ForegroundColor=ConsoleColor.DarkRed;
                            Console.WriteLine( "[ERROR]-Ingreso una opcion fuera de rango\nIngrese 1 para Femenino y 2 para Masculino\n");
                            Console.ForegroundColor=ConsoleColor.White;
                            esInt=false;
                            break;
                        }else{
                            if(sexo==1){
                                auxSexo='f';
                            }else{
                                auxSexo='m';
                            }
                            arraySexo[i]=auxSexo;      
                        }               
                    }else{
                        Console.ForegroundColor=ConsoleColor.DarkRed;
                        Console.WriteLine( "[ERROR]-No ingreso una opcion valida\n");
                        Console.ForegroundColor=ConsoleColor.White;
                        break;
                    }
                }
            }while(!esInt);
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("\nDatos cargados con exito!!");
            Console.WriteLine("Lista de Sexo cargada:");
            for(int i = 0; i<arraySexo.Length; i++){
                Console.WriteLine("Pos[{0}]-Sexo[{1}]", i, arraySexo[i]);
            }
            Console.ForegroundColor=ConsoleColor.White;
            Console.WriteLine("******************************\n");

             /*-*-*-*-*-*-*-*Genearcion de Menu y muestra de resultados-*-*-*-*-*-*-**/
            do{
                Console.Write("\n******Generar reportes******\n"+
                                  "1-Mostrar cuantos empleados ganan mas de $70000\n"+
                                  "2-Cantidad de Mujeres\n"+
                                  "3-Cantidad de Hombres\n"+
                                  "4-Sueldo promedio de los hombres\n"+
                                  "5-Sueldo promedio de las mujeres\n"+
                                  "6-Salir del Programa\n"+
                                  "Opcion deseada: ");

                esInt = int.TryParse(Console.ReadLine(), out optionMenu);
                
                if(esInt){
                    switch(optionMenu){
                        case 1:
                            Console.Clear();
                            Console.WriteLine("******************************");
                            for(int i=0; i<arraySueldos.Length; i++){
                                if(arraySueldos[i]>70000){
                                    contadorSueldos++;
                                }
                            }
                            Console.ForegroundColor=ConsoleColor.Green;
                            Console.WriteLine("Los empleados que ganan mas de $70000 son: "+contadorSueldos);
                            Console.ForegroundColor=ConsoleColor.White;
                            Console.WriteLine("******************************");
                            Console.Write("Ingrese una tecla para volver al Menu.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("******************************");
                            for(int i=0; i<arraySexo.Length; i++){
                                if(arraySexo[i]=='f'){
                                    contadorMujeres++;
                                }
                            }
                            Console.ForegroundColor=ConsoleColor.Green;
                            Console.WriteLine("Los cantidad de Mujeres empleadas son: "+contadorMujeres);
                            Console.ForegroundColor=ConsoleColor.White;
                            Console.WriteLine("******************************");
                            Console.Write("Ingrese una tecla para volver al Menu.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("******************************");
                            for(int i=0; i<arraySexo.Length; i++){
                                if(arraySexo[i]=='m'){
                                    contadorHombres++;
                                }
                            }
                            Console.ForegroundColor=ConsoleColor.Green;
                            Console.WriteLine("Los cantidad de Hombres empleados son: "+contadorHombres);
                            Console.ForegroundColor=ConsoleColor.White;
                            Console.WriteLine("******************************");
                            Console.Write("Ingrese una tecla para volver al Menu.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("******************************");
                            Console.WriteLine("Promedio de Sueldos de las Hombres:");
                            int auxPosSexoHombre = 0;
                            double acumSueldosHombre = 0;
                            double contadorHombresProm = 0;
                            for(int i = 0; i<arraySexo.Length; i++){
                                if(arraySexo[i]=='m'){
                                    auxPosSexoHombre = i;
                                    for(int j=0; j<arraySueldos.Length;){
                                        Console.WriteLine("Pos[{0}] - sueldo[{1}]",i,arraySueldos[auxPosSexoHombre]);
                                        acumSueldosHombre+=arraySueldos[auxPosSexoHombre];
                                        contadorHombresProm++;
                                        break;
                                    }
                                }
                            }
                            String acumSueldosHombresFM = acumSueldosHombre.ToString("C");
                            Console.WriteLine("Suma de todos los sueldos: "+acumSueldosHombresFM);
                            Console.WriteLine("Cantidad de hombres que trabajan: "+contadorHombresProm);
                            promedio = acumSueldosHombre/contadorHombresProm;
                            String promedioFormatoMonedaHombre = promedio.ToString("C");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("El promedio es: "+promedioFormatoMonedaHombre);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("******************************");
                            Console.Write("Ingrese una tecla para volver al Menu.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("******************************");
                            Console.WriteLine("Promedio de Sueldos de las mujeres:");
                            int auxPosSexo = 0;
                            double acumSueldosMujeres = 0;
                            double contadorMujeresProm = 0;
                            for(int i = 0; i<arraySexo.Length; i++){
                                if(arraySexo[i]=='f'){
                                    auxPosSexo = i;
                                    for(int j=0; j<arraySueldos.Length;){
                                        Console.WriteLine("Pos[{0}] - sueldo[{1}]",i,arraySueldos[auxPosSexo]);
                                        acumSueldosMujeres+=arraySueldos[auxPosSexo];
                                        contadorMujeresProm++;
                                        break;
                                    }
                                }
                            }
                            String acumSueldosMujeresFM = acumSueldosMujeres.ToString("C");
                            Console.WriteLine("Suma de todos los sueldos: "+acumSueldosMujeresFM);
                            Console.WriteLine("Cantidad de mujeres que trabajan: "+contadorMujeresProm);
                            promedio = acumSueldosMujeres/contadorMujeresProm;
                            String promedioFormatoMoneda = promedio.ToString("C");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("El promedio es: "+promedioFormatoMoneda);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("******************************");
                            Console.Write("Ingrese una tecla para volver al Menu.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 6:
                            Console.WriteLine("******************************");
                            Console.WriteLine("Gracias por usar el programa");
                            Console.WriteLine("******************************\n");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("******************************\n"+
                                               "[ERROR]-No ingreso una opcion valida\n"+
                                               "******************************\n");
                            Console.ForegroundColor = ConsoleColor.White; 
                            break;  
                    }
                }else{
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("******************************\n"+
                                      "[ERROR]-No ingreso una opcion valida\n"+
                                      "******************************\n");
                    Console.ForegroundColor = ConsoleColor.White;        
                }
            }while(optionMenu!=6);
        } 
    }
}
