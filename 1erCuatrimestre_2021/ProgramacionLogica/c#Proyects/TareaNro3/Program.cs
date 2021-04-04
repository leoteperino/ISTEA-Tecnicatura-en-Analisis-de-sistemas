using System;
/*
Desarrolle una aplicacion consola que permita el ingreso por pantalla de una orientacion,
nombre y edad de los alumnos, como salida debe mostrar el curso al cual es asignado el alumno
junto con sus datos.

1-Orientacion Contable
Curso 1A=Alumnos de 14 años 
Curso 2A=Alumnos de 15 años
Curso 3A=Alumnos de 16 años
Curso 4A=Alumnos de 17 años
Curso 5A=Alumnos de 18 años

2-Orientacion Sistemas
Curso 1B=Alumnos de 14 años 
Curso 2B=Alumnos de 15 años
Curso 3B=Alumnos de 16 años
Curso 4B=Alumnos de 17 años
Curso 5B=Alumnos de 18 años

-Validar el ingreso datos en orientacion y edad.
*/
namespace TareaNro3
{
    class Program
    {
        static void Main(string[] args)
        {
            string orientacion = "";
            int opcionMenu;
            int edad;
            string nombre;
            bool esInt;
            string curso = "";

            Console.Clear();
            do{
                Console.WriteLine("\n******Menu******");
                Console.WriteLine("Ingrese la orientacion: "+
                                  "\n1-Orientacion Contable"+
                                  "\n2-Orientacion Sistemas"+
                                  "\n3-Salir del Programa");
                esInt = int.TryParse(Console.ReadLine(), out opcionMenu);
                if(esInt){
                    switch(opcionMenu){
                        case 1:
                        case 2:
                            Console.WriteLine("Ingrese su nombre: ");
                            nombre = Console.ReadLine();
                            do{
                                Console.WriteLine("Ingrese su edad: ");
                                esInt = int.TryParse(Console.ReadLine(), out edad);
                                if(esInt){
                                    if(edad < 14 || edad > 18){
                                        Console.WriteLine("---------------------------------------");
                                        Console.WriteLine("[ERROR]-Edad fuera de rango.\nPresione una letra para continuar");
                                        Console.WriteLine("---------------------------------------");
                                        Console.ReadKey();
                                        Console.Clear();
                                        esInt = false;    
                                    }else{
                                        if(opcionMenu==1){
                                            orientacion="Orientacion Contable";
                                            switch(edad){
                                                case 14:
                                                    curso = "1A";
                                                break;
                                                case 15:
                                                    curso = "2A";
                                                break;
                                                case 16:
                                                    curso = "3A";
                                                break;
                                                case 17:
                                                    curso = "4A";
                                                break;
                                                case 18:
                                                    curso = "5A";
                                                break;
                                            }        
                                        }
                                        if(opcionMenu==2){
                                            orientacion="Orientacion Sistemas";
                                            switch(edad){
                                                case 14:
                                                    curso = "1B";
                                                break;
                                                case 15:
                                                    curso = "2B";
                                                break;
                                                case 16:
                                                    curso = "3B";
                                                break;
                                                case 17:
                                                    curso = "4B";
                                                break;
                                                case 18:
                                                    curso = "5B";
                                                break;
                                            }        
                                        }
                                        Console.Clear();
                                        Console.WriteLine("---------------------------------------");
                                        Console.WriteLine("******Datos del Alumno******");
                                        Console.WriteLine("NOMBRE: "+nombre+
                                                          "\nEDAD: "+edad+
                                                          "\nORIENTACION: "+orientacion+
                                                          "\nCURSO: "+curso);
                                        Console.WriteLine("---------------------------------------");
                                        Console.WriteLine("Presione cualquier tecla para continuar con el Programa");
                                        Console.ReadKey();
                                    }
                                }else{
                                    Console.WriteLine("---------------------------------------");
                                    Console.WriteLine("[ERROR]-No ingreso una opcion valida.\nPresione una letra para continuar");
                                    Console.WriteLine("---------------------------------------");
                                    Console.ReadKey();
                                    Console.Clear();                
                                }
                            }while(!esInt);
                            break;
                        case 3:
                            Console.WriteLine("---------------------------------------");
                            Console.WriteLine("Gracias por usar el programa!\nPresione una letra para continuar");
                            Console.WriteLine("---------------------------------------");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("---------------------------------------");
                            Console.WriteLine("[ERROR]-No ingreso una opcion valida.\nPresione una letra para continuar");
                            Console.WriteLine("---------------------------------------");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }else{
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("[ERROR]-No ingreso una opcion valida.\nPresione una letra para continuar");
                    Console.WriteLine("---------------------------------------");
                    Console.ReadKey();
                    Console.Clear();
                }
            }while(opcionMenu!=3); 
        }
    }
}
