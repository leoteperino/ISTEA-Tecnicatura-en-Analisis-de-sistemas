using System;

namespace pract01
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            double valor2;
            float valor3;
            char str1;
            string str2;
            Console.Clear();
            //ingreso la variable enteros.
            Console.Write("Ingrese Valor Entero: ");
            valor1=Int32.Parse(Console.ReadLine());
            //ingreso el valor double
            Console.Write("Ingrese Valor Doble: ");
            valor2=Double.Parse(Console.ReadLine());
            //ingreso valor real
            Console.Write("Ingrese Valor Real: ");
            valor3=float.Parse(Console.ReadLine());
            //ingreso valor Char
            Console.Write("Ingrese Valor char: ");
            str1=char.Parse(Console.ReadLine());
            //ingreso sting
            //ingreso valor Char
            Console.Write("Ingrese Valor String: ");
            str2=Console.ReadLine();

            Console.Clear();
            //Muestro Valores
            Console.WriteLine("------------------");
            Console.WriteLine("Entero   :"+valor1);
            Console.WriteLine("Double   :"+valor2);
            Console.WriteLine("Real     :"+valor3);
            Console.WriteLine("Char     :"+str1);
            Console.WriteLine("String   :"+str2);
            Console.WriteLine("------------------");










        }
    }
}
