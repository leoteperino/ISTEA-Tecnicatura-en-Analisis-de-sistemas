using System;

namespace proyect12
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha;
            //fecha=DateTime.Today;
            fecha=DateTime.Now;
            Console.WriteLine("Fecha y Hora:"+fecha);            
            Console.WriteLine("Fecha Corta:"+fecha.ToShortDateString());
            Console.WriteLine("Fecha Dias:"+fecha.ToString("dd"));
            Console.WriteLine("Fecha Meses:"+fecha.ToString("MMMM"));
            Console.WriteLine("Fecha Meses:"+fecha.ToString("MM"));
            Console.WriteLine("Fecha Años:"+fecha.ToString("yyyy"));
            Console.WriteLine("Fecha Larga Completa:"+fecha.ToString("D"));
            Console.WriteLine("Fecha Larga Completa:"+fecha.ToString("F"));
            Console.WriteLine("Fecha Corta Completa:"+fecha.ToString("G"));
            Console.WriteLine("Fecha mes y año:"+fecha.ToString("y"));

            int cant_meses;
            int cant_anios;
            DateTime fecha_pago=new DateTime(2019,2,19);
            //aux=(DateTime.Today-fecha_pago);

            //opcion --> muestro cantidad de dias.
            Console.WriteLine("Diferencia en dias:"+(DateTime.Today-fecha_pago).Days);

            //opcion 2
            cant_meses=DateTime.Today.Month-fecha_pago.Month;
            cant_anios=DateTime.Today.Year-fecha_pago.Year;

            Console.WriteLine("Cant. de meses: "+cant_meses);
            Console.WriteLine("Cant. de Años: "+cant_anios);
            

            //sumar dias.
            DateTime fecha2;
            fecha2=DateTime.Today;
            fecha2=fecha2.AddDays(365);
            Console.WriteLine("Fecha Nueva: "+fecha2);

            DateTime fecha5=new DateTime(2019,3,1,8,0,15);
            DateTime fecha6=DateTime.Now;
            TimeSpan inter=fecha6-fecha5;

            Console.WriteLine("Cant. Dias: "+inter.Days);
            Console.WriteLine("Cant. Meses: "+inter.Days/30);
            Console.WriteLine("Cant. Año: "+inter.Days/365);

        }
    }
}
