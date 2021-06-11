using System;

namespace ejer04
{
    class Program
    {
        static void Main(string[] args)
        {
        dias dia=dias.Lunes;
        int i=(int) dias.Lunes;
        Console.WriteLine(dia);
        Console.WriteLine(i);
        }


        public enum dias
        {
            Domingo=0,
            Lunes=1,
            martes=2,
            Miercoles=3,
            Jueves=4,
            Viernes=5,
            Sabado=6
        }


    }
}
