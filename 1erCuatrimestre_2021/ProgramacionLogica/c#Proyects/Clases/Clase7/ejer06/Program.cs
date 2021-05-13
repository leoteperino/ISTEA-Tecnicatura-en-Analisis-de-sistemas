using System;

namespace ejer06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var resultado=metodoTupla();

            if(resultado.resultado)
                Console.WriteLine(resultado.valor);
        }


        static (bool resultado,int valor) metodoTupla()
        {
          int x=1;
            if(x==1)
                    return (true,10);
            else
                    return (false,0);      

        }



    }
}
