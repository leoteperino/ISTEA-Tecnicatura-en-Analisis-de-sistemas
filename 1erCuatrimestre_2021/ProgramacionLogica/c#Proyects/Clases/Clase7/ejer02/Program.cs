using System;

namespace ejer02
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] legajo=new int[45];
            int [] sexo=new int[45];
            double[] sueldo=new double[45];
            Random rnd=new Random();
            int cant_v=0;
            int cant_m=0;
            int sueldos_70=0;
            double promedio_v=0;
            double promedio_m=0;

            for(int x=0;x<legajo.Length;x++)
            {
                legajo[x]=rnd.Next(1,100);
                sexo[x]=rnd.Next(1,3);
                sueldo[x]=rnd.Next(25000,120000);
                if(sexo[x]==1){promedio_m=promedio_m+sueldo[x];cant_m++;}
                if(sexo[x]==2){promedio_v=promedio_v+sueldo[x];cant_v++;}
                if(sueldo[x]>70000){sueldos_70++;}
                Console.WriteLine("Legajo: {0} ,Sexo{1} , Sueldo:{2:c}",legajo[x],sexo[x],sueldo[x]);
              
            }

        Console.WriteLine("Cant. Empleados Mujeres: {0} , sueldo promedio {1:c}",cant_m,(promedio_m/cant_m));
        //Console.WriteLine("Cant. Empleados Mujeres: {0} , sueldo promedio {1:c}",cant_m,(promedio_m/cant_m)     );
        Console.WriteLine("Sueldos > 70.000: {0}",sueldos_70);





        }
    }
}
