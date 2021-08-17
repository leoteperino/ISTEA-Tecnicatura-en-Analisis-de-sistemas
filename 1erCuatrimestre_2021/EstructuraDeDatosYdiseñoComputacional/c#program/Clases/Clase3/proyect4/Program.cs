using System;

namespace proyect4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros={120,50,12,15,21,1,5,88}; 
            Comparison<int> comparador =new Comparison<int> ((numero1,numero2) =>numero1.CompareTo(numero2));
            //Comparison<int> comparador =new Comparison<int> ((numero1,numero2) =>numero2.CompareTo(numero1));

            Array.Sort<int>(numeros,comparador);

            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            /*
            string[] palabras={"Perro","Gato","Jirafa","Elefante"};
            Comparison<string> comparador1 =new Comparison<string> ((cadena1,cadena2) =>cadena1.CompareTo(cadena2));

            Array.Sort<string>(palabras,comparador1);

            foreach(string palabra in palabras)
            {
                Console.WriteLine(palabra);
            }
            */




        }
    }
}
