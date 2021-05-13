using System;

namespace ejer01
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime[] ultimoPago = new DateTime[]
            {
            new DateTime(2021, 1, 14),
            new DateTime(2021, 4, 18),
            new DateTime(2021, 4, 18),
            new DateTime(2021, 3, 23),
            new DateTime(2021, 2, 12),
            new DateTime(2021, 1, 11),
            new DateTime(2021, 2, 8),
            new DateTime(2021, 3, 23),
            new DateTime(2021, 1, 23),
            new DateTime(2021, 3, 23),
            new DateTime(2021, 4, 18),
            new DateTime(2021, 12, 18),
            new DateTime(2020, 11, 18),
            new DateTime(2020, 10, 18),
            new DateTime(2021, 4, 18),
            new DateTime(2021, 4, 18)    
            };  
        TimeSpan diferencia;
        int dias;

        Console.Clear();

            for(int x=0;x<ultimoPago.Length;x++)
            {
                diferencia=DateTime.Today-ultimoPago[x];
                dias=diferencia.Days;

                if(dias>60)
                    Console.WriteLine("El Socio Nro: "+x+" Tiene la Matricula Vencida");

            }



        }
    }
}
