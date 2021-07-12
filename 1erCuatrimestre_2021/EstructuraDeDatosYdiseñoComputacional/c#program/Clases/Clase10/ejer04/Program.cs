using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace ejer04
{
    class Program
    {
        static void Main(string[] args)
        {
         int opc;
         Dictionary<string, string> usuarios = new Dictionary<string, string>();    
         do{
         Console.Clear();
         opc=menu();
         
         switch(opc)
         {
             case 1:
                    ingresarUsuario(ref usuarios);
                    break;
            case 2:
                    ModificarContraseña(ref usuarios);
                    break;
            case 3:
                    verUsuarios(usuarios);
                    break;
         }
         
         }while(opc!=4); 
        }


        static int menu()
        {         
         int opcion=0;
         Console.WriteLine("1-Nuevo Usuario");
         Console.WriteLine("2-Modificar PassWord");
         Console.WriteLine("3-Ver usuarios");
         Console.WriteLine("4-Salir");
         Console.Write("\n\n ingrese opcion: ");
         opcion=Int32.Parse(Console.ReadLine());   
         return   opcion;
        }

        static void ingresarUsuario(ref Dictionary<string, string> usuarios)
        {
            Console.Clear();
            string usuario;
            string pass;
            bool valida;
            bool valida2;
            

            Console.Write("Ingrese Nombre de usuario:");
            usuario=Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Ingrese Contraseña:");
            pass=Console.ReadLine();
            
            //valido usuario
            if(usuarios.ContainsKey(usuario))
                valida2=false;               
            else
                valida2=true;
                
            //valido la contraseña
            valida=validarContraseña(pass);

            if(valida==true&&valida2==true)
                     usuarios.Add(usuario, pass);
            else    
            {      
            Console.WriteLine("El usuario ya existe o la contraseña no cumple los requisitos") ;  
            Console.ReadKey(); 
            }    

        }

        static bool validarContraseña(string pass)
        {
            string formato = "^([a-zA-Z0-9]{4,16})$";
            Regex r = new Regex(formato);
            if(r.IsMatch(pass)) {return true;}
            else { return false; }
        }

        static void verUsuarios (Dictionary<string, string> usuarios)
        {
            Console.Clear();

            foreach (KeyValuePair<string, string> usuario in usuarios)
            {
            Console.WriteLine("El usuario es: "+usuario.Key + " Contraseña: " + usuario.Value);
            }
            Console.ReadKey(); 
        }

        static void ModificarContraseña(ref Dictionary<string, string> usuarios)
        {
            Console.Clear();
            string usuario;
            string pass;
            bool valida;
            bool valida2;
            

            Console.Write("Ingrese Nombre de usuario:");
            usuario=Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Ingrese Contraseña:");
            pass=Console.ReadLine();
            
            //valido usuario
            if(usuarios.ContainsKey(usuario))
                valida2=false;               
            else
                valida2=true;
                
            //valido la contraseña
            valida=validarContraseña(pass);

            if(valida==true&&valida2==false) 
                    {                   
                     usuarios[usuario] = pass;
                     Console.WriteLine("Se modifico con exito la pass de usuario: "+usuario);
                     Console.ReadKey();
                    }
            else    
            {      
            Console.WriteLine("El usuario no existe o la contraseña no cumple los requisitos") ;  
            Console.ReadKey(); 
            } 
        }




    }
}
