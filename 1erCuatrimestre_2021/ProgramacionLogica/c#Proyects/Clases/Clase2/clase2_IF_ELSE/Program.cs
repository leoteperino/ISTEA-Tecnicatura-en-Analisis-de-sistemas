using System;

namespace proyect16
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario="admin";
            string pass="123456";
            if(usuario=="admin")
            {
                if(pass=="123456")
                {
                Console.WriteLine("Usuario y Pass Correcto");
                }
                else
                {
                Console.WriteLine("Pass Incorrecto");   
                }
            }
            else
            {
               Console.WriteLine("Usuario Incorrecto"); 
            }




            





        }
    }
}
