using System;

namespace Ejer03
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] deudores = new double[45];
            Random rnd = new Random();
            double deuda_inc=0;

             //Asigno valores aleatorios y los muestro
            for(int x=0;x<deudores.Length;x++)
            {
                deudores[x]=rnd.Next(1000,9999);
                Console.Write("Deuda Cliente["+x+"]:");
                Console.Write(String.Format ("Importe = {0:c}",deudores[x]));    
                Console.WriteLine("");   
            }

            //hago las consultas
            for(int x=0;x<deudores.Length;x++)
            {
                if(deudores[x]>5000)
                {
                    deuda_inc=deuda_inc+deudores[x];
                }  
            }
            
           
            Console.Write(String.Format ("Deuda Incobrable: = {0:c}",deuda_inc));    
            Console.WriteLine(""); 





        }
    }
}
