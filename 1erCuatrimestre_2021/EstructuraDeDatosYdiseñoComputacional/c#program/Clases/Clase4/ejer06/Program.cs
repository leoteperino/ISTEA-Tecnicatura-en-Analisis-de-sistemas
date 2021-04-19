using System;
using System.Collections.Generic;

namespace ejer06
{
    class Program
    {
        static void Main(string[] args)
        {
        List<string> ListaDeNombres= new List<string>()
         {
          "Cecilia",   
          "Pedro",   
          "Juan",   
          "Nicolas"
         };          
         Console.Clear();
         
         foreach(var x in ListaDeNombres)
                Console.WriteLine("Nombre= "+x); 
        
        
        //Metodo Agregar
         ListaDeNombres.Add("Juana");
         ListaDeNombres.Add("Ezequiel");

         foreach(var x in ListaDeNombres)
                Console.WriteLine("Nombre= "+x); 
         
         //Metodo Agregar varios
            Console.WriteLine("Metodo Agregar varios");
         ListaDeNombres.AddRange(new string[]
         {
          "Javier",
          "Pablo",
          "Hector"   
         }       
         );
         foreach(var x in ListaDeNombres)
                Console.WriteLine("Nombre= "+x); 
         
        //Eliminar Dato
        Console.Clear();
        ListaDeNombres.Remove("Javier");
        foreach(var x in ListaDeNombres)
                Console.WriteLine("Nombre= "+x);  


        //Eliminar Dato por posicion
        Console.Clear();
        ListaDeNombres.RemoveAt(1);
        foreach(var x in ListaDeNombres)
                Console.WriteLine("Nombre= "+x); 


        Console.Clear();
        ListaDeNombres.RemoveAt(ListaDeNombres.Count-1);
        foreach(var x in ListaDeNombres)
                Console.WriteLine("Nombre= "+x); 

        Console.WriteLine("El Nombre Juana esta en la Pos.: {0}",ListaDeNombres.IndexOf("Juana"));

        Console.Clear();
        ListaDeNombres.Add("Ariel");
        ListaDeNombres.Sort();
        foreach(var x in ListaDeNombres)
                Console.WriteLine("Nombre= "+x); 



        Console.WriteLine();
        ListaDeNombres.Reverse();
        foreach(var x in ListaDeNombres)
                Console.WriteLine("Nombre= "+x); 

        


        Console.WriteLine();
        ListaDeNombres.Clear();
        foreach(var x in ListaDeNombres)
                Console.WriteLine("Nombre= "+x);          
         
         }
    }
}
