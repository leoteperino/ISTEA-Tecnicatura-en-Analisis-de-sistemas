using System;
using System.Collections.Generic;

namespace ejer01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> openWith = new Dictionary<string, string>();
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            try
            {
            openWith.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {
            Console.WriteLine("Ya existe un elemento con la clase solicitada");
            }

            Console.WriteLine("For key = \"rtf\", value = {0}.",openWith["rtf"]);


            //el id se puede usar para cambiar el value.
            openWith["rtf"] = "winword.exe";
            Console.WriteLine("For key = \"rtf\", value = {0}.",openWith["rtf"]);

            //si el id no existe se agrega como nuevo par
            openWith["doc"] = "winword.exe";


            //si el id no funciona se lanza una exepcion.
            try
            {
             Console.WriteLine("For key = \"tif\", value = {0}.",openWith["tif"]);
            }
            catch (KeyNotFoundException)
            {
            Console.WriteLine("Key = \"tif\" is not found.");
            }

            //se puede utilizar un containsKey para verificar si existe
            if (!openWith.ContainsKey("ht"))
            {
            openWith.Add("ht", "hypertrm.exe");
            Console.WriteLine("Value added for key = \"ht\": {0}",
            openWith["ht"]);
            }


            //imprimir diccionario
            Console.WriteLine();
            foreach( KeyValuePair<string, string> kvp in openWith )
            {
                Console.WriteLine("Key = {0}, Value = {1}",kvp.Key, kvp.Value);
            }

        }
    }
}
