using System;
using System.IO;


namespace ejer01
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta="/home/leandro/Desktop/ISTEA/1erCuatrimestre_2021/ProgramacionLogica/c#Proyects/Clases/Clase11/ejer01/log.txt";

            string contenido=DateTime.Now+" Inicio Aplicacion";
            EscribirLog(contenido,ruta);

            int valor1=0;
            int valor2=0;
            int res=0;


            try
            {
                Console.Write("Ingrese Valor 1:");
                valor1=Int32.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.Write("Ingrese Valor 2:");
                valor2=Int32.Parse(Console.ReadLine());

                res=valor1/valor2;
                Console.WriteLine("TOTAL:"+res);
            }

            catch(FormatException)
            {
                Console.WriteLine("Se ha ingresado un dato no Valido");
                Console.ReadLine();
                contenido=DateTime.Now + "Se ha ingresado un dato no Valido";
                EscribirLog(contenido,ruta);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Error de divicion por cero");
                Console.ReadLine();
                contenido=DateTime.Now + "Error de divicion por cero";
                EscribirLog(contenido,ruta);
            }
            catch(Exception)
            {
                Console.WriteLine("Se ha producido un error");
                Console.ReadLine();
                contenido=DateTime.Now + "Se ha producido un error";
                EscribirLog(contenido,ruta);
            }
            finally
            {
            contenido=DateTime.Now+" Fin Aplicacion";
            Console.ReadLine();
            EscribirLog(contenido,ruta);
            }
        }


        static void EscribirLog(string contenido,string ruta)
        {
            File.AppendAllLines(ruta,new String[]{contenido});
        }

    }
}
