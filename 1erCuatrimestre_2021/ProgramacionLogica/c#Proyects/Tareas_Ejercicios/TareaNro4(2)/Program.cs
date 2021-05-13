using System;

namespace TareaNro4_2_
{
    class Program
    {
        const int ARRAY_LEN = 5;
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

            do{
                for(int i=0; i<ARRAY_LEN; i++){
                    Console.Write("Ingresar legajo [{0}]: ",i+1);
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
                    Console.WriteLine("Legajos cargado con exito!!");  
                }
            }while(!esInt);   
        }
    }
}
