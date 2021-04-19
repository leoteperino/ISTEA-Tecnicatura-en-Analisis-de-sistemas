using System;

namespace Ejer02
{
    class Program
    {
        static void Main(string[] args)
        {
        int[] notas = new int[45];
        Random rnd = new Random();
        int alumno_des=0;
        int alumno_apro=0;
        int alumno_reg=0;
        Console.Clear();
        //Asigno valores aleatorios y los muestro
            for(int x=0;x<notas.Length;x++)
            {
                notas[x]=rnd.Next(1,10);
                Console.WriteLine("Alumno ["+x+"]:"+notas[x]);
            }

        for(int x=0;x<notas.Length;x++)
        {

                if (notas[x]>8)
                            alumno_reg++;
                if (notas[x]<4)
                            alumno_des++;
                else
                            alumno_apro++;   
        
        }
        
        Console.WriteLine("Regulares:"+alumno_reg);
        Console.WriteLine("Aprobados:"+alumno_apro);
        Console.WriteLine("Desaprobados:"+alumno_des);

        }
    }
}
