using System;

namespace ejer05
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAMAÑO_DE_ARRAY = 2;   

            string[] nombres = new string[TAMAÑO_DE_ARRAY];
            string[] apellidos = new string[TAMAÑO_DE_ARRAY];
            int[]    edades = new int[TAMAÑO_DE_ARRAY];
            char[]   generos = new char[TAMAÑO_DE_ARRAY];  

            cargarString(ref nombres, nameof(nombres));
            cargarString(ref apellidos,nameof(apellidos));
            cargarEdades(ref edades,nameof(edades));
            cargarGenero(ref generos,nameof(generos));           
        }

        public static void cargarString(ref string[] array, string nombreDeArray)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Ingrese el elemento {0} del array de {1} ", i, nombreDeArray);
                array[i] = Console.ReadLine();
            }
        }

        public static void cargarEdades(ref int[] array, string nombreDeArray)
        {
            for(int i = 0; i < array.Length; i++)
            {
                int aux;
                Console.WriteLine("Ingrese el elemento {0} del array de {1}", i, nombreDeArray);
                do{
                    if(int.TryParse(Console.ReadLine(), out aux) && aux > 0 && aux < 100)
                    {
                        array[i] = aux;
                    }
                    else
                    {
                        Console.WriteLine("Ingreso incorrecto. Ingrese otra vez el número");
                    }
                }while(array[i] != aux);
            }
        }
              
        public static void cargarGenero(ref char[] array, string nombreDeArray)
        {
            for(int i = 0; i < array.Length; i++)
            {
                char aux;
                Console.WriteLine("Ingrese el elemento {0} del array de {1}", i, nombreDeArray);
                do{
                    if(Char.TryParse(Console.ReadLine(), out aux) && (aux =='M' || aux =='F'))
                    {
                        array[i] = aux;
                    }
                    else
                    {
                        Console.WriteLine("Ingreso incorrecto. Ingrese otra vez el Caracter");
                    }
                } while(array[i] != aux);
            }
        }
    }
}
