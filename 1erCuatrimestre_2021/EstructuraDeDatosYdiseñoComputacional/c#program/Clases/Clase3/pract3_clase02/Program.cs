using System;

/*
Desarrollar una aplicacion consola que implemente un array de enteros de al menos
200 posiciones con valores aleatorios y que devuelva por pantalla impresos todos
los valores , el maximo  el minimo.

*/



namespace pract3_clase02
{
    class Program
    {
        static void Main(string[] args)
        {
        int[] valores = new int[200];
        Random rnd = new Random();
   
            //Asigno valores aleatorios y los muestro
            for(int x=0;x<valores.Length;x++)
            {
                valores[x]=rnd.Next(100,1000);
                Console.WriteLine("Valor ["+x+"]:"+valores[x]);
            }

            int maximo=0;

            for(int x=0;x<valores.Length;x++)
            {
                 if(valores[x]>maximo)
                 {
                     maximo=valores[x];
                 }
             }
            Console.WriteLine("Valor Maximo:"+maximo);


           int minimo=maximo;

             for(int x=0;x<valores.Length;x++)
            {
                 if(valores[x]<minimo)
                 {
                     minimo=valores[x];
                 }
             }
            Console.WriteLine("Valor Maximo:"+minimo);









        }
    }
}
