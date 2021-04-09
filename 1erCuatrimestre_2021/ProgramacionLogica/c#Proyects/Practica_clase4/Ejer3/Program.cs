using System;

namespace Ejer3
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcion;
            bool EsChar;

            do{
                do{
                    Console.Clear();
                    Console.Write("A- Altas B-Bajas C-Control S-Salir: ");
                    EsChar=Char.TryParse(Console.ReadLine(),out opcion);
                }while(!EsChar);

                opcion=char.ToUpper(opcion);

                if(opcion!='A' && opcion!='B' && opcion!='C' && opcion!='S')
                {
                    Console.Write("La Opcion no es valida");
                    Console.ReadKey();
                }
            }while(opcion!='S');





            





        }
    }
}
