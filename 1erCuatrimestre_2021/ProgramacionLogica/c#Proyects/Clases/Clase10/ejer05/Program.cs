using System;

namespace ejer05
{
    class Program
    {
        static void Main(string[] args)
        {
        /*
        realizar una aplicacion consola que pemita el ingreso por pantall el nombre, apellido , edad de una alumno, y que
        a partir de una funcion "sorteo" defina que dia de la semana debera rendir el examen final de la 
        materia corresondiente.
        La Aplicacion debera termnar con el nombre "SALIR"
        Se debera utilizar un enumerador para  determinar los dias de examen.
        */
        string nombre="";
        string apellido="";
        int edad=0;
        string dia;

        do{
            Console.Clear();
            Console.Write("Nombre: ");
            nombre=Console.ReadLine();
            if(nombre!="SALIR")
            {
            Console.Write("Apellido: ");
            apellido=Console.ReadLine();
            Console.Write("Edad: ");
            edad=Convert.ToInt32(Console.ReadLine());
            }
            dia=sorteo();

            Console.Write("Nombre: {0}, Apellido:{1}, Edad:{2}, Fecha Examen:{3}",nombre,apellido,edad,dia);
            Console.ReadKey();
        }while(nombre!="SALIR");


        }

        static string sorteo()
        {
            Random rd = new Random();
            int rand_num = rd.Next(1,7);
            string dia="";
            switch(rand_num)
            {
                case 0:
                dia=DiasSemana.Domingo.ToString();
                break;
                case 1:
                dia=DiasSemana.Sabado.ToString();
                break;
                case 2:
                dia=DiasSemana.Lunes.ToString();
                break;
                case 3:
                dia=DiasSemana.Martes.ToString();
                break;
                case 4:
                dia=DiasSemana.Miercoles.ToString();
                break;
                case 5:
                dia=DiasSemana.Jueves.ToString();
                break;
                case 6:
                dia=DiasSemana.Viernes.ToString();
                break;
            }
            return dia;
        }

        enum DiasSemana
        {
            Domingo=0,
            Lunes=1,
            Martes=2,
            Miercoles=3,
            Jueves=4,
            Viernes=5,
            Sabado=6
        }
    }
}
