using System;
using System.Collections;

/*
Generar una aplicacion consola que implemente una cola con llamados telefonicos en espera, se deberan como minimo 4 funciones
dibujar el menu, ingresar llamados, atender llamados, ver llamados en espera.

-aterder llamados debe contenplar que puede n haber datos en ela cola.
-ver llamados debe mostrar la cantidad de llamados en espera y el detalle de los mismos.
-atender llamados debe mostrar el llamado que de atendio y fue extraido de la cola.


*/


namespace ejer03
{
    class Program
    {
        static void Main(string[] args)
        {         
        Queue llamadosEnEspera = new Queue();

        int opc=0;
        do{
        opc=menu();  
        switch(opc)
        {
            case 1:
                   ingresarLlamado(ref llamadosEnEspera);
                   break; 
            case 2:
                   atenderLlamados(ref llamadosEnEspera);
                   break;
            case 3:
                    verLLamados(llamadosEnEspera);
                    break;
            case 4:
                Console.WriteLine("Gracias por utilizar la aplicacion de llamados....");
                Console.ReadKey();
                break;
        }   
        }while(opc!=4);


        }



        static int menu()
        {
            Console.Clear();
            int opcion=0;

                Console.WriteLine("1-Ingresar llamado");
                Console.WriteLine("2-Finalizar llamado");
                Console.WriteLine("3-Ver llamados en espera");
                Console.WriteLine("4-Salir");    
                Console.Write("\n Ingrese Una opcion: "); 
                opcion=Int32.Parse(Console.ReadLine());           

            return opcion;
        }


        static void ingresarLlamado(ref Queue llamadosEnEspera)
        {
            Console.Clear();
            string nombre;
            Console.Write("Ingrese nombre del cliente: ");
            nombre=Console.ReadLine();
            llamadosEnEspera.Enqueue(nombre);
            Console.WriteLine("\n Se ha ingresado al cliente:"+nombre);
            Console.ReadKey();
        }

        static void verLLamados(Queue llamadosEnEspera)
        {
            int aux=0;
            Console.Write("Listado de llmados en espera");
                        aux=llamadosEnEspera.Count;

            Console.WriteLine("");            

            if(aux==0)
            {
                Console.WriteLine("\n \n No hay llamados en espera\n\n");
            }
            else
            {
             int y=0;
             foreach(var x in llamadosEnEspera)
                    {
                    y++;    
                    Console.WriteLine(y+"-"+x); 
                    
                    } 
            Console.WriteLine("\n Al momento hay "+aux+" Llamados en espera");
            
            }
            Console.ReadKey();

        }

        static void atenderLlamados(ref Queue llamadosEnEspera)
        {
         Console.Clear();
            if(llamadosEnEspera.Count==0)
            {
                Console.WriteLine("No hay llamados en espera");
            }
            else
            {
                Console.WriteLine("\n Se atendia a:  '{0}'", llamadosEnEspera.Dequeue());                
            }
            Console.ReadKey();
        }


    }
}
