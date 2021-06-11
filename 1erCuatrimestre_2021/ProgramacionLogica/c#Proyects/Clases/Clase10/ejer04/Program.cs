using System;
using System.Collections; 
using System.Collections.Generic;


namespace ejer04
{
    class Program
    {
        static void Main(string[] args)
        {
            int idEstadoCivil=(int) EstadoCivil.Soltero;
            string nombreEstadoCivil=EstadoCivil.Soltero.ToString();            
            Console.WriteLine(idEstadoCivil +" "+nombreEstadoCivil);            
        }
        enum EstadoCivil
            {
            Soltero = 1,
            Casado = 2,
            Divorciado = 3,
            Viudo=4
            }
        enum Sexo
            {
            Masculino = 1,
            Femenino = 2            
            }
        
    }
}
