using System;

namespace ejer02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            try{
                int [] numero={1,4,7};
                Console.WriteLine(numero[8]);
               }
            catch (Exception e)
              {
                  Console.WriteLine(e.Message);
              }
            */
            /*
            try{
                int x=32;
                x=x/0;
                Console.WriteLine(x);
            }
            
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Intento de division por Cero");
            }
            
            finally
            {
            Console.WriteLine("Vuelva a intentar la division");  
            }
            */
            bool cont;

            do{ 
                try{
                    cont=false;
                    Console.WriteLine("Ingrese valor:");
                    string linea=Console.ReadLine();
                    var num=int.Parse(linea);
                    var cuadrado=num*num;
                    Console.WriteLine("El cuadrado de numero es"+num);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Debe Ingresar un valor entero");
                    cont=true;
                }
          }while(cont);
          Console.ReadKey();



            
        }
    }
}
