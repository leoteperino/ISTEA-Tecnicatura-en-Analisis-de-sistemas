using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero_cargado;
            int numero_cargado2;
            bool esNumero;
            bool esNumero2;

            do{
                Console.Clear();
                Console.WriteLine("Mostrar el carton");
                Console.WriteLine("Mostrar el menu");

                do{
                    Console.WriteLine("Numero1: ");
                    esNumero = int.TryParse(Console.ReadLine(), out numero_cargado);
                    //Validamos que el numero cargado sea numero
                    if(esNumero == true){
                        //continuamos
                        Console.WriteLine("Es NUmero!!!");
                        if(numero_cargado>10){
                            esNumero=false;
                            Console.WriteLine("ERROR - Mayor a 10");     
                        }
                        //Si es cero sale del programe
                        if(numero_cargado==0){
                            Console.WriteLine("Saliendo del programa....");
                            Environment.Exit(-1);
                        }
                        Console.ReadKey();
                        //Ahora que sabemos que numero esta cargado, pedimos por numero dos
                        do{
                            Console.WriteLine("Numero2: ");
                            esNumero2 = int.TryParse(Console.ReadLine(), out numero_cargado2);
                            if(esNumero2 == true){
                                //continuamos
                                Console.WriteLine("Es NUmero2!!!");
                                //Si es cero sale del programe
                                if(numero_cargado2==0){
                                    Console.WriteLine("Saliendo del programa....");
                                    Environment.Exit(-1);
                                }
                                if(numero_cargado2 == numero_cargado){
                                    esNumero2=false;
                                    Console.WriteLine("No pueden ser repetido, vualva a ingresar");
                                }else{
                                    Console.WriteLine(numero_cargado+"--"+numero_cargado2);
                                    Console.WriteLine("Procesamos los datos y mostramos resultados");
                                    Console.WriteLine("Presione tecla y continue jugando....");
                                    Console.ReadKey();
                                }
                            }else{
                                //No es numero2, cargas el Error
                                Console.WriteLine("ERROR");
                            }
                        }while(!esNumero2);
                    }else{
                        //No es numero1, cargas el Error
                        Console.WriteLine("ERROR");
                    }
                }while(!esNumero);

            }while(numero_cargado!=0);
        }
    }
}
