using System;

namespace TareaNro5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Dado un array de fechas de pagos de cuotas de un gimnasio calcular los días entre el pago de la ultima si 
            son mayores de 60 días el socio deberá abonar nuevamente la matricula por lo cual se deberá mostrar por pantalla 
            la cantidad de socios que deben abonar. 
            */

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

            Console.Clear();
            int diasVencimiento;
            int contadorSocios = 0;
    
            Console.WriteLine("Lista de Socios con vencimientos mayores a 60 dias: ");
            for(int i=0; i<ultimoPago.Length; i++){
                diasVencimiento = (DateTime.Today-ultimoPago[i]).Days;
                if(diasVencimiento>30){
                    contadorSocios++;
                    Console.WriteLine("Socio:[{0}]\t-Ultimo Pago:[{1}]\t-Atraso:[{2}]dias",i, ultimoPago[i], diasVencimiento);
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("la cantidad de socios que deberan abonar son: "+contadorSocios);
        }
    }
}
