using System;

namespace TareaNro7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            4-Se deberá ingresar por pantalla Nombre, Apellido, dni y Edad de un alumno, 
            se deberá concatenar toda la información junto con las etiquetas correspondientes y devolver el resultado al main 
            para mostrarlo en otra función.
            */
            string nombre;
            string apellido;
            int dni;
            int edad;

            nombre = pedirNombre();
            apellido = pedirApellido();
            dni = pedirDNI();
            edad = pedirEdad();
            concatenarMostrarDatosAlumnos(nombre, apellido, dni, edad);
        }

        static string pedirNombre(){
            bool esValido;
            string ret = "";
            do{
                Console.Clear();
                esValido=true;
                Console.WriteLine("Ingrese nombre del alumno: ");
                ret = Console.ReadLine();
                if(!validacionNombreApellido(ret)){
                    esValido=false;
                    Console.WriteLine("[ERROR]-No ingreso un nombre");
                    Console.WriteLine("Pulse cualquier tecla para continuar....");
                    Console.ReadKey();
                }
            }while(!esValido);
            return ret;
        }

        static string pedirApellido(){
            bool esValido;
            string ret = "";
            do{
                Console.Clear();
                esValido=true;
                Console.WriteLine("Ingrese apellido del alumno: ");
                ret = Console.ReadLine();
                if(!validacionNombreApellido(ret)){
                    esValido=false;
                    Console.WriteLine("[ERROR]-No ingreso un apellido valido");
                    Console.WriteLine("Pulse cualquier tecla para continuar....");
                    Console.ReadKey();
                }
            }while(!esValido);
            return ret;
        }

        static int pedirDNI(){
            Console.Clear();
            bool esValido = true;
            int ret = 0;
            int numero = 0;
            do{
                try{
                    Console.Clear();
                    Console.WriteLine("Ingrese DNI: ");
                    numero = int.Parse(Console.ReadLine());
                    if(!validacionDni(numero)){
                        esValido=false;
                        Console.WriteLine("[ERROR]-No ingreso un DNI valido");
                        Console.WriteLine("Pulse cualquier tecla para continuar....");
                        Console.ReadKey();
                    }else{
                        esValido = true;
                        ret = numero;
                    }
                }catch(Exception){
                    esValido = false;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("[ERROR]-Ingreso letras o un numero decimal.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Pulse una tecla para continuar...");
                    Console.ReadKey(); 
                }
            }while(!esValido);
                return ret;
        }

        static int pedirEdad(){
            Console.Clear();
            bool esValido = true;
            int ret = 0;
            int numero = 0;
            do{
                try{
                    Console.Clear();
                    Console.WriteLine("Ingrese edad: ");
                    numero = int.Parse(Console.ReadLine());
                    if(!validacionEdad(numero)){
                        esValido=false;
                        Console.WriteLine("[ERROR]-No ingreso una edad valida");
                        Console.WriteLine("Pulse cualquier tecla para continuar....");
                        Console.ReadKey();
                    }else{
                        esValido = true;
                        ret = numero;
                    }
                }catch(Exception){
                    esValido = false;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("[ERROR]-Ingreso letras o un numero decimal.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Pulse una tecla para continuar...");
                    Console.ReadKey(); 
                }
            }while(!esValido);
                return ret;
        }


        static void concatenarMostrarDatosAlumnos(string nombre, string apellido, int dni, int edad){
            Console.Clear();
            Console.WriteLine("Los datos del alumno ingreados son:\n"+
                              "Nombre: {0}\n"+
                              "Apellido: {1}\n"+
                              "Edad: {2}\n"+
                              "DNI: {3}",
                              nombre, 
                              apellido,
                              edad,
                              dni);
        }

        static bool validacionNombreApellido(string nombreApellido){
            bool ret = true;
            for(int i=0; i<nombreApellido.Length; i++){
                if(Char.IsNumber(nombreApellido[i])){
                    ret = false;
                    break;
                }
            }
            if(nombreApellido.Length==0){
                ret=false;
            }
            return ret;
        }

        static bool validacionDni(int dni){
            bool ret = true;
            if(dni>99999999 || dni < 1000000){
                ret = false;
            }
            return ret;
        }

        static bool validacionEdad(int edad){
            bool ret = true;
            if(edad>100 || edad<=0){
                ret = false;
            }
            return ret;
        }
    }
}
