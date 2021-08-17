using System;
using System.IO;
using System.Collections.Generic;




namespace ejer02
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader=new StreamReader(File.OpenRead("/home/leandro/Desktop/ISTEA/1erCuatrimestre_2021/ProgramacionLogica/c#Proyects/Clases/Clase11/ejer02/users.csv"));
            List<string> Usuarios=new List<string>();
            List<string> Pass=new List<string>();
            List<string> Tusuarios=new List<string>();

            Console.Clear();
            while(!reader.EndOfStream)
            {
                var linea = reader.ReadLine();
                var valor=linea.Split(';');
                Usuarios.Add(valor[0]);
                Pass.Add(valor[1]);
                Tusuarios.Add(valor[2]);
            }

            int cant=Usuarios.Count;

            for(int x =0;x<cant;x++)
            {
                Console.WriteLine(Usuarios[x]+"--"+Pass[x]+"--"+Tusuarios[x]);
            }

        }
    }
}
