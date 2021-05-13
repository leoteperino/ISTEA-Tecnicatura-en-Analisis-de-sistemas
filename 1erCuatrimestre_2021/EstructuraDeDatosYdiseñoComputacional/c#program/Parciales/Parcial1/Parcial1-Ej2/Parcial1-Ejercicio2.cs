using System;

namespace Parcial1_Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion e inicializacion de variables
            Random number = new Random();
            int filas;
            int columnas;
            int suma=1;
            int resta = 2;
            int multiplicacion = 3;
            int division = 4;
            float max = 0;
            float min = 0;
            int contador = 0;
            float acumulador = 0;
            float acumuladorMultiplicacion = 0;
            float minimoSuma = 0;
            float maximoRestas = 0;
            bool esInt;

            //Pido el ingreso de las filas y las columnas del Array para que el mismo sea dinamico
            do{
                Console.Clear();
                Console.Write("====================Bienvenido====================\n"+
                              "Ingrese el numero de filas del Array: ");
                esInt = int.TryParse(Console.ReadLine(), out filas);
                //Valido que se ingrese un numero
                if(esInt){
                    //Valido que el numero de filas cargadas no sea menor a cuatro
                    if(filas<4){
                        esInt = false;
                        Console.Write("\n=====================================================\n"+
                                      "El numero de filas cargadas no debe ser menor a 4\n"+
                                      "Presione cualquier tecla y vuelva a intentarlo\n"+
                                      "=====================================================\n");
                        Console.ReadKey();
                    }else{
                        Console.WriteLine("Filas cargadas con exito!!\n"+
                                      "Presione cualquier tecla para continuar");
                        Console.ReadKey();
                    }
                }else{
                    Console.ForegroundColor=ConsoleColor.DarkRed;
                    Console.Write("\n=====================================================\n"+
                                  "[ERROR]-Ingrese solo numeros\n"+
                                  "Presione cualquier tecla y vuelva a intentarlo\n"+
                                  "=====================================================\n");
                    Console.ForegroundColor=ConsoleColor.White;
                    Console.ReadKey();
                }
            }while(!esInt);

            //Pido las columnas
            do{
                Console.Clear();
                Console.Write("Ingrese el numero de columnas del Array: ");
                esInt = int.TryParse(Console.ReadLine(), out columnas);
                //Valido que se ingrese un numero
                if(esInt){
                    if(columnas==0){
                        esInt = false;
                        Console.Write("\n=====================================================\n"+
                                      "El numero de columanas cargadas no puede ser 0\n"+
                                      "Presione cualquier tecla y vuelva a intentarlo\n"+
                                      "=====================================================\n");
                        Console.ReadKey();
                    }else{
                        Console.WriteLine("Columnas cargadas con exito!!\n"+
                                      "Presione cualquier tecla para continuar");
                        Console.ReadKey();
                    }
                }else{
                    Console.ForegroundColor=ConsoleColor.DarkRed;
                    Console.Write("\n=====================================================\n"+
                                  "[ERROR]-Ingrese solo numeros\n"+
                                  "Presione cualquier tecla y vuelva a intentarlo\n"+
                                  "=====================================================\n");
                    Console.ForegroundColor=ConsoleColor.White;
                    Console.ReadKey();
                }
            }while(!esInt);

            //Creo el Array que se utiliza
            float[,] array_numeros=new float[filas,columnas];

            //Cargo el array con los valores pedidos
            for(int x=0; x<array_numeros.GetLength(0); x++){
                for(int y=0; y<array_numeros.GetLength(1); y++){
                    //Lleno la fila 1 y la fila 3
                    if(x==0 || x==2){
                        array_numeros[x,y] = number.Next(100,1000);
                    }
                    //Leeno la fila 2
                    if(x==1){
                        array_numeros[x,y] = number.Next(1,5);
                    }
                }
            }

            //Recorro el array cargado y realizo las operaciones pedidas y cargo la fila de resultados
            for(int x=0; x<array_numeros.GetLength(0); x++){
                for(int y=0; y<array_numeros.GetLength(1); y++){
                    if(array_numeros[x,y]==suma){
                        array_numeros[3,y]=array_numeros[0,y]+array_numeros[2,y];
                    }
                    if(array_numeros[x,y]==resta){
                       array_numeros[3,y]=array_numeros[0,y]-array_numeros[2,y];
                    }
                    if(array_numeros[x,y]==multiplicacion){
                        array_numeros[3,y]=array_numeros[0,y]*array_numeros[2,y];
                    }
                    if(array_numeros[x,y]==division){
                        array_numeros[3,y]=array_numeros[0,y]/array_numeros[2,y];
                    }
                }
            }
            
            //Imprimo el Array y le doy los colores que necesita en cada fila y columna
            Console.Clear();
            Console.Write("===Array Cargado===\n");
            for(int x=0; x<array_numeros.GetLength(0); x++){
                for(int y=0; y<array_numeros.GetLength(1); y++){
                    if(x==3){
                        if(array_numeros[1,y]==suma){
                                Console.ForegroundColor=ConsoleColor.DarkRed;
                                Console.Write(array_numeros[x,y]+"\t");
                                Console.ForegroundColor=ConsoleColor.White;
                        }else if(array_numeros[1,y]==resta){
                                Console.ForegroundColor=ConsoleColor.DarkBlue;
                                Console.Write(array_numeros[x,y]+"\t");
                                Console.ForegroundColor=ConsoleColor.White;
                        }else if(array_numeros[1,y]==multiplicacion){
                                Console.ForegroundColor=ConsoleColor.DarkYellow;
                                Console.Write(array_numeros[x,y]+"\t");
                                Console.ForegroundColor=ConsoleColor.White;
                        }else if(array_numeros[1,y]==division){
                                Console.ForegroundColor=ConsoleColor.DarkGreen;
                                Console.Write(Math.Round(array_numeros[x,y],2)+"\t");
                                Console.ForegroundColor=ConsoleColor.White;
                        }
                    }else{
                        Console.Write(array_numeros[x,y]+"\t");
                    }
                }
                Console.WriteLine("");
            }

            //Recorro todos los resultados para obtener el maximo y minimo
            //Genero dos variables Maximo y Minimo 
            //Cargo estas variables con el primer valor cargado en los resultados
            Console.Write("\n===Resultados===\n");
            max=array_numeros[3,0];
            min=array_numeros[3,0];
            for(int x=0; x<array_numeros.GetLength(0); x++){
                for(int y=0; y<array_numeros.GetLength(1); y++){
                    if(x==3){
                        if(array_numeros[x,y]>max){
                            max = array_numeros[x,y];

                        }
                        if(array_numeros[x,y]<min){
                            min = array_numeros[x,y];
                        }
                    }
                }
            }
            Console.WriteLine("El numero Maximo de todos los resultados es: {0}\n"+
                              "El numero Minimo de todos los resultados es: {1}"
                              ,Math.Round(max,2),Math.Round(min,2));

            //Promedio de las divisiones
           for(int x=0; x<array_numeros.GetLength(0); x++){
                for(int y=0; y<array_numeros.GetLength(1); y++){
                    if(x==3){
                       if(array_numeros[1,y]==division){
                            acumulador+=array_numeros[x,y];
                            contador++;
                       }
                    }
                }
            }
            float promedio = acumulador/contador;
            if(float.IsNaN(promedio)){
                Console.WriteLine("Promedio de las Divisiones es: No hay divisiones.");
            }else{
                Console.WriteLine("Promedio de las Divisiones es: {0}",Math.Round(promedio,2));
            }

            //Suma de las multiplicaciones
            for(int x=0; x<array_numeros.GetLength(0); x++){
                for(int y=0; y<array_numeros.GetLength(1); y++){
                    if(x==3){
                       if(array_numeros[1,y]==multiplicacion){
                            acumuladorMultiplicacion+=array_numeros[x,y];
                       }
                    }
                }
            }
            if(acumuladorMultiplicacion==0){
                Console.WriteLine("La suma de todas las Multiplicaciones es: No hay Multiplicaciones.");
            }else{
                Console.WriteLine("La suma de todas las Multiplicaciones es: {0}",Math.Round(acumuladorMultiplicacion,2));    
            }

            //Recorro todos los resultados de suma para obtener el minimo
            //Me guardo en una variable minimo con el maximo valor que puede haber
            minimoSuma = int.MaxValue; 
            for(int x=0; x<array_numeros.GetLength(0); x++){
                for(int y=0; y<array_numeros.GetLength(1); y++){
                    if(x==3){
                       if(array_numeros[1,y]==suma){
                            if(array_numeros[x,y]< minimoSuma){
                                minimoSuma = array_numeros[x,y];
                            }
                       }
                    }
                }
            }
            if(minimoSuma == int.MaxValue){
                Console.WriteLine("El Minimo de las sumas es: No hay Sumas.");
            }else{
                Console.WriteLine("El Minimo de las sumas es: {0}",Math.Round(minimoSuma,2));
            }

            //Recorro todos los resultados de resta para obtener el minimo
            //Me guardo una variable maximo con el minimo valor esperado
            maximoRestas = int.MinValue;
            for(int x=0; x<array_numeros.GetLength(0); x++){
                for(int y=0; y<array_numeros.GetLength(1); y++){
                    if(x==3){
                       if(array_numeros[1,y]==resta){
                            if(array_numeros[x,y]> maximoRestas){
                                maximoRestas = array_numeros[x,y];
                            }
                       }
                    }
                }
            }
            if(maximoRestas == int.MinValue){
                Console.WriteLine("El Maximo de las restas es: No hay Restas.");
            }else{
                Console.WriteLine("El Maximo de las restas es: {0}",Math.Round(maximoRestas,2));
            }
        }
    }
}
