using System;
using System.IO;
using System.Collections.Generic;

namespace ejer03
{
    class Program
    {
        static void Main(string[] args)
        {        
            List<string> Usuarios=new List<string>();
            List<string> Pass=new List<string>();
            List<string> Tusuarios=new List<string>();
            string usuario;
            string pass;
            string tusuario;
            CargarUsuarios(ref Usuarios,ref Pass,ref Tusuarios);

            Console.Write("Ingrese Usuario: ");
            usuario=Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Ingrese Password");
            pass=Console.ReadLine();

            tusuario=validarUsuario(usuario,pass,ref Usuarios,ref Pass,ref Tusuarios);

            Console.Clear();
            if(tusuario=="NoUser"){
                Console.WriteLine("El usuario No existe");
            }else{
                Console.WriteLine("USUARIO: "+usuario+" Pass:"+pass+" Tipo Usuario:"+tusuario);
            }
        }

        static void CargarUsuarios(ref List<string> Usuarios,ref List<string> Pass,ref List<string> Tusuarios )
            {
                var reader=new StreamReader(File.OpenRead("/home/leandro/Desktop/ISTEA/1erCuatrimestre_2021/ProgramacionLogica/c#Proyects/Clases/Clase11/ejer03/users.csv"));
                Console.Clear();
                while(!reader.EndOfStream)
                {
                    var linea=reader.ReadLine();
                    var valor=linea.Split(';');
                    Usuarios.Add(valor[0]);
                    Pass.Add(valor[1]);
                    Tusuarios.Add(valor[2]);
                }
            }

        static string validarUsuario(string usuario,string pass,ref List<string> Usuarios,ref List<string> Pass,ref List<string> Tusuarios)
        {
            string tusuario="NoUser";
            for(int x=0;x<Usuarios.Count;x++)
            {
                if(usuario==Usuarios[x] & pass==Pass[x] ){
                        tusuario=Tusuarios[x];
                }
            }
            return tusuario;
        }
    }
}

