using System;
/*
dado un estado de cuanta de n cantidad de dinero, realizar una aplicacion consoles en donde
se pueda ingresar y retirar dinero validando que la misma no se quede sin fondos.
para finalizar la apliacion se debera ingresar la tecla S
*/
namespace Ejer05
{
    class Program
    {
        static void Main(string[] args)
        {
            double estado_cuenta=80000;
            double debito;
            double credito=0;
            char opcion;

            do{
                Console.Write("Ingrese D-Debito C-Credito S-Salir :");
                opcion=char.Parse(Console.ReadLine());
                opcion=Char.ToUpper(opcion);
                    if(opcion=='C')
                    {
                        Console.Write("Ingreso de Dinero:");
                        credito=Convert.ToDouble(Console.ReadLine());
                        estado_cuenta=estado_cuenta+credito;
                        Console.Clear();
                        Console.WriteLine("Ingreso de dinero exitoso");
                        Console.WriteLine("Estado de cuenta Actual:"+estado_cuenta);
                    }

                    if(opcion=='D')
                    {
                        Console.Write("Retirar Dinero:");
                        debito=Convert.ToDouble(Console.ReadLine());
                        if((estado_cuenta-debito)<0)
                        {
                            Console.WriteLine("No se puede realizar la operacion");
                            Console.ReadKey();
                        }
                        else
                        {
                           estado_cuenta=estado_cuenta-debito;
                           Console.WriteLine("Retro de dinero exitoso");
                           Console.ReadKey();
                        }                        
                        Console.Clear();
                        
                        Console.WriteLine("Estado de cuenta Actual:"+estado_cuenta);
                    }







            }while(opcion!='S');
            



        }
    }
}
