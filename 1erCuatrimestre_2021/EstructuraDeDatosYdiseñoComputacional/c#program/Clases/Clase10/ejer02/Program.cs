using System;
using System.Collections.Generic;

namespace ejer02
{
    class Program
    {
        static void Main(string[] args)
        {

        Dictionary<string, int> usuarios = new Dictionary<string, int>();  
        usuarios.Add("nfernandez", 42122);  
        usuarios.Add("sjuarez", 38212);  
        usuarios.Add("jhernandez", 121212);  
        usuarios.Add("sperez", 12212);

        string nuevoUsuario = "hquiroga";
        if(usuarios.ContainsKey(nuevoUsuario))
                Console.WriteLine("EL usuario no Existe");
        else
                Console.WriteLine("EL usuario no Existe");



        foreach (KeyValuePair<string, int> usuario in usuarios)
            {
            Console.WriteLine("El usuario es: "+usuario.Key + " Contraseña: " + usuario.Value);
            }


        }
    }
}
