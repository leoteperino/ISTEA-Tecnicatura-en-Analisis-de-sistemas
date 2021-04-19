using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Dada la siguiente cadena de caracteres devolver la cantidad de 0 y 1 por pantalla.
                string Oracion ="1101 0011 1010 1100 1001 0001 1000 1000 1100 0011 1100 0011 1100";
            */

            string oracion ="1101 0011 1010 1100 1001 0001 1000 1000 1100 0011 1100 0011 1100";

            int i;
            int cont_0 = 0;
            int cont_1 = 0;

            Console.Clear();
            for(i=0; i<oracion.Length; i++){
                if(oracion[i]=='0'){
                    cont_0++;
                }else if(oracion[i]=='1'){
                    cont_1++;
                }
            }
            Console.WriteLine("El String tiene "+cont_0+" ceros y "+cont_1+" unos");
            Console.ReadKey();
        }
    }
}
