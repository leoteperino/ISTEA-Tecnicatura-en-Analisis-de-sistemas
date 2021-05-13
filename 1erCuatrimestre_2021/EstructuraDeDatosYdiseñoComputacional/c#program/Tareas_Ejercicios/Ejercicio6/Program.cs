using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            crear un array bidimencional de 2 filas y 30 columnas con valores aleatorios entre 0 y 1, }
            también crear 2 variables candidato 1 y candidato 2, suponiendo que son votos los  datos del array, 
            contar los valores y declarar 1 ganador imprimiendo por pantalla el nombre de la variable con mas votos y 
            la cantidad de votos.
            metodo a utilizar para imprimir nombre de la variable
            NameOf(....)
            */

            Console.Clear();
            Random number = new Random();
            int[,] array_votos=new int[2,30];
            int candidato_1 = 0;
            int candidato_2 = 0;

            for(int x=0; x<array_votos.GetLength(0); x++){
                for(int y=0; y<array_votos.GetLength(1); y++){
                    array_votos[x,y]=number.Next(0,2);
                }
            }

            for(int x=0; x<array_votos.GetLength(0); x++){
                for(int y=0; y<array_votos.GetLength(1); y++){
                    if(array_votos[x,y]==1){
                        candidato_1++;
                    }else{
                        candidato_2++;
                    }
                }
                Console.WriteLine("");
            }

            if(candidato_1>candidato_2){
                Console.WriteLine("El gandor es el {0} con {1} votos\nEl {2} obtuvo {3} votos\nLa cantidad total de votos es {4}",
                                  nameof(candidato_1),candidato_1,nameof(candidato_2),candidato_2,(candidato_1+candidato_2));
            }else{
                Console.WriteLine("El gandor es el {0} con {1} votos\nEl {2} obtuvo {3} votos\nLa cantidad total de votos es {4}",
                                  nameof(candidato_2),candidato_2,nameof(candidato_1),candidato_1,(candidato_1+candidato_2));
            }
        }
    }
}
