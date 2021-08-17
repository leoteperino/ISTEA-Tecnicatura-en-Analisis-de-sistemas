using System;

namespace ejer05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string nombre;
            string apellido;
            int dni;
            int edad;
            string concatenado;

            Console.Write("Nombre:");
            nombre=Console.ReadLine();
            Console.Write("Apellido");
            apellido=Console.ReadLine();
            Console.Write("DNI:");
            dni=Int32.Parse(Console.ReadLine());
            Console.Write("Edad:");
            edad=Int32.Parse(Console.ReadLine());


            concatenado=concatenar(nombre,apellido,dni,edad);

            Console.WriteLine(concatenado);
        }

        static string concatenar(string n,string a,int doc,int ed)
        {
            string oracion="Nombre:"+n+"|Apellido:"+a+"|DNI:"+doc+"|Edad:"+ed;

            return oracion;
        }


    }
}
