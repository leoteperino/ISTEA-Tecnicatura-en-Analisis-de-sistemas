using System;

namespace TareaNro7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            2-se deberá generar una aplicación consola que permita el ingreso por pantalla de 2 cadenas de texto, 
            luego se deberá generar una función que concatene las mismas y devuelva el resultado al main 
            para imprimirlo por pantalla.
            */
            string cadenaTexto1;
            string cadenaTexto2;

            cadenaTexto1 = pedirCadenaTexto();
            cadenaTexto2 = pedirCadenaTexto();
            concatenarDevolverCadenas(cadenaTexto1, cadenaTexto2);
        }

        static string pedirCadenaTexto(){
            Console.Clear();
            string ret = "";
            Console.WriteLine("Ingrese un cadena de texto: ");
            ret = Console.ReadLine();
            return ret;
        }

        static void concatenarDevolverCadenas(string cadena1, string cadena2){
            if(cadena1!=null && cadena2!=null){
                Console.WriteLine(cadena1+" "+cadena2);
            }
        }
    }
}
