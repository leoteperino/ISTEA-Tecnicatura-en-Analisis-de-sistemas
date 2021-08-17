using System;

namespace Clase1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int? a=null;        
            if(a!=null) 
            {
                Console.WriteLine("Es igual a null");
            }
            else
            {
                Console.WriteLine("No es igual a null");
            }

            string texto1="Nicolas";
            string texto2="Nicolas";
            bool result=texto1.Equals(texto2);
            if (result==true)
            {
                Console.WriteLine("Ambas cadenas son iguales");
            }
            else
            {
                Console.WriteLine("Ambas cadenas no son iguales");
            }

            int b=17;
            switch(b)
            {
                case 15:
                    Console.WriteLine("El valor es 15");
                    break; 
                case 16:
                    Console.WriteLine("El valor es 16");
                    break;     
                case 17:
                    Console.WriteLine("El valor es 17");
                break; 
            }
        }
    }
}
