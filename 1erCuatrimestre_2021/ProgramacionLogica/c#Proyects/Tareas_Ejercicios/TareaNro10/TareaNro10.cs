using System;

namespace TareaNro10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se deberá generar una aplicación consola que instacie 4 arrays unidimencionales 
            en donde se cargue de manera aleatoria las notas del 1er. cuatrimestre, 2do. cuatrimestre, 
            nota final y estado de la cursada
            1-4 desaprobada.
            4-8 aprobado
            >8 promocionado
            La aplicación debe ser dinámica y como mínimo 30 notas, que se deben mostrar por pantalla cada 10 alumnos.
            el array se debe cargar en una función y mostrar en otra.*/

            double[] primerCuatrimestre=new double[30];
            double[] segundoCuatrimestre=new double[30];
            double[] notaFinal=new double[30];
            string[] estado=new string[30];

            cargarNotasPrimerCuatrimestre(primerCuatrimestre);
            cargarNotasSegundoCuatrimestre(segundoCuatrimestre);
            mostrarNotas(ref primerCuatrimestre,ref segundoCuatrimestre,ref notaFinal,ref estado); 
        }

        static void cargarNotasPrimerCuatrimestre(double[] array){
            Random number = new Random();
            for(int i = 0; i<array.Length; i++){
                array[i] = number.Next(1,10);     
            }
        }

        static void cargarNotasSegundoCuatrimestre(double[] array){
            Random number = new Random();
            for(int i = 0; i<array.Length; i++){
                array[i] = number.Next(1,10);     
            }
        }

        static void mostrarNotas (  ref double[] primerCuatrimestre,
                                    ref double[] segundoCuatrimestre,
                                    ref double[] notaFinal,
                                    ref string[] estado){                            
            for(int i=0;i<estado.Length;i++){
                notaFinal[i] = primerCuatrimestre[i]/segundoCuatrimestre[i];
                if(notaFinal[i]<=4){
                    estado[i] = "Desaprobada";
                }else if(notaFinal[i]>=5 && notaFinal[i]<=8){
                    estado[i] = "Aprobada";
                }else{
                    estado[i] = "Promocionado";
                }
                Console.WriteLine("1C-Nota: {0}--2C-Nota: {1}--Nota Final: {2}--Estado: {3}",
                                   primerCuatrimestre[i],
                                   segundoCuatrimestre[i],
                                   notaFinal[i],
                                   estado[i]);

                if(i==9){
                    Console.WriteLine("Presione una tecla para continuar.....");
                    Console.ReadKey();
                }else if(i==19){
                    Console.WriteLine("Presione una tecla para continuar.....");
                    Console.ReadKey();
                }                   
            }                            
        }
    }
}
