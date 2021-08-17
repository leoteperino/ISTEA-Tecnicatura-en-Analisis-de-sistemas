using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ingresar por pantalla Nombre ,sexo y fecha de nacimiento de un alumno
            Imprimir por pantalla sus datos y la edad del mismo.
            */

            string nombre;
            char sexo;
            DateTime fecha;
            bool esChar;
            bool esFecha;

            Console.Clear();
            Console.Write("Ingrese su Nombre: ");
            nombre = Console.ReadLine();

            do{
                Console.Write("Ingrese su sexo: ");
                esChar = char.TryParse(Console.ReadLine(), out sexo);
                sexo = char.ToLower(sexo);
                if(esChar){
                    if(sexo != 'f' && sexo != 'm'){
                        Console.WriteLine("[ERROR]-Ingrese F o M");
                        esChar=false;
                    }
                }else{
                    Console.WriteLine("[ERROR]-No ingreso una opcion valida");
                }
            }while(!esChar);

            do{
                Console.Write("Ingrese fecha de nacimiento[xx/xx/xxx]:");
                esFecha = DateTime.TryParse(Console.ReadLine(), out fecha);
                if(!esFecha){
                    Console.WriteLine("[ERROR]-No ingreso una opcion valida");
                }
            }while(!esFecha);

            int dias = (DateTime.Today - fecha).Days;
            int anios =  dias/360;
            Console.WriteLine("Nombre: {0}\nSexo {1}\nEdad: {2}",nombre,sexo,anios);
        }
    }
}
