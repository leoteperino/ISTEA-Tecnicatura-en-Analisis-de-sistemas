using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear una aplicación que permita el ingreso por pantalla de un numero de hasta 4 cifras
            y devuelve si es par o impar, el proceso se debe repetir hasta que se ingrese el valor 0.*/

            //Declaracion de variables
            int numeroIngresado; 
            bool esNumerico;

            Console.Clear();
            Console.WriteLine("***Par o Impar***");     
            do{ 
                //Pido numero   
                Console.Write("Ingrese un numero entero de hasta 4 cifras o el 0 para Salir: ");
                //Parseo el dato ingresado a numerico
                esNumerico = int.TryParse(Console.ReadLine(), out numeroIngresado);

                //validacion y logica del dato Ingresado
                if(esNumerico){
                    //Valido que no tenga mas de 4 cifras
                    string num = numeroIngresado.ToString(); //leo el numeroIngresado como String
                    int cant = num.Length; //Leo la cantidad de digitos que contiene 
                    if(cant > 4){ //Valido que no sean mas de 4
                        Console.WriteLine("-ERROR-Solo ingrese numeros de hasta 4 cifras");
                    }else if(numeroIngresado == 0){ //Comportamiento si el numero es 0
                        Console.WriteLine("Gracias por usar el programa.");
                    }else{ //Verifico si el numero es par o impar
                       if(numeroIngresado%2 == 0){ 
                          Console.WriteLine("El numero ingresado es par");  
                       }else{
                           Console.WriteLine("El numero ingresado es impar");
                       }       
                    }        
                }else{
                    Console.WriteLine("-ERROR-No ha ingresado un numero");
                }
            }while(numeroIngresado!=0 || !esNumerico);
            Console.ReadKey(); 
        }
    }
}
