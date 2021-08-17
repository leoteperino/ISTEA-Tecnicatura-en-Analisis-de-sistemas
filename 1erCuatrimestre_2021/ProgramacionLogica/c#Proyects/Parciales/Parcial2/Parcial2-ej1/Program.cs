using System;

namespace Parcial2_ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha;
            string ingreso;

            Console.Clear();
            Console.WriteLine("****Benvenido****");
            pedirNombre();
            pedirApellido();
            pedirDNI();
            fecha = pedirFecha();
            ingreso = calcularEdad(fecha);
            Console.WriteLine(ingreso);   
        }

        /*
        //Funcion pedirNombre
        //Funcion que pide un nombre por consola y valida que sea un nombre correcto
        //Devuelve un String que es el nombre ingresado si este se valida correctamente, sino devuelde un error
        y pide el dato nuevamente.
        //No tiene parametros de entrada  
        */
        static string pedirNombre(){
            bool esValido;
            string ret = "";
            do{
                esValido=true;
                Console.Write("Ingrese nombre del alumno: ");
                ret = Console.ReadLine();
                if(!validarNombreApellido(ret)){
                    esValido=false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[ERROR]-Los nombres no pueden contener numeros ni estar vacios");
                    Console.WriteLine("Pulse cualquier tecla para continuar....");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }while(!esValido);
            return ret;
        }

        /*
        //Funcion pedirApellido
        //Funcion que pide un apellido por consola y valida que sea un apellido correcto
        //Devuelve un String que es el apellido ingresado si este se valida correctamente, sino devuelde un error
        y pide el dato nuevamente.
        //No tiene parametros de entrada  
        */
        static string pedirApellido(){
            bool esValido;
            string ret = "";
            do{
                esValido=true;
                Console.Write("Ingrese apellido del alumno: ");
                ret = Console.ReadLine();
                if(!validarNombreApellido(ret)){
                    esValido=false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[ERROR]-Los apellidos no pueden contener numeros ni estar vacios");
                    Console.WriteLine("Pulse cualquier tecla para continuar....");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }while(!esValido);
            return ret;
        }

         /*
        //Funcion pedirDNI
        //Funcion que pide un DNI por consola y valida que sea un DNI correcto
        //Devuelve un int que es el DNI ingresado si este se valida correctamente, sino devuelde un error
        y pide el dato nuevamente.
        //No tiene parametros de entrada  
        */
         static int pedirDNI(){
            bool esValido = true;
            int ret = 0;
            int numero = 0;
            do{
                try{
                    Console.Write("Ingrese DNI sin espacios, sin puntos y sin comas [xxxxxxxxxx]: ");
                    numero = int.Parse(Console.ReadLine());
                    if(!validarDni(numero)){
                        esValido=false;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("[ERROR]-No ingreso un DNI valido");
                        Console.WriteLine("Pulse cualquier tecla para continuar....");
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.White;
                    }else{
                        esValido = true;
                        ret = numero;
                    }
                }catch(Exception){
                    esValido = false;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("[ERROR]-Ingreso letras, puntos o comas");
                    Console.WriteLine("Pulse una tecla para continuar...");
                    Console.ReadKey(); 
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }while(!esValido);
                return ret;
        }

        /*
        //Funcion pedirFecha
        //Funcion que pide una fecha por consola y valida que sea una fecha correcta
        //Devuelve un dato del tipo DateTime que es la fecha ingresada si es valida, sino devuelde un error
        y pide el dato nuevamente.
        //No tiene parametros de entrada  
        */
        static DateTime pedirFecha(){
            bool esFecha = true;
            DateTime fecha = DateTime.Now;
            do{
                try{
                    Console.Write("Ingrese fecha de nacimiento[Dia-Mes-Año][00-00-0000]: ");
                    fecha = DateTime.Parse(Console.ReadLine());
                    if(validarEdad(fecha)){
                        esFecha = true;        
                    }else{
                        esFecha = false;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("[ERROR]-No Ingreso una fecha valida");
                        Console.WriteLine("Pulse una tecla para continuar...");
                        Console.ReadKey(); 
                        Console.ForegroundColor = ConsoleColor.White;
                    }    
                }catch(Exception){
                    esFecha = false;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("[ERROR]-No Ingreso una fecha valida");
                    Console.WriteLine("Pulse una tecla para continuar...");
                    Console.ReadKey(); 
                    Console.ForegroundColor = ConsoleColor.White;
                }    
            }while(!esFecha);
            return fecha; 
        }

        /*
        //Funcion validaEdad
        //Funcion que valida que la edad este dentro del rango de 1 a 99,
        Calcula la edad en años hace un print de la edad obtenida y evalua la condicion > o < que.
        //Recibe como parametro de entrada un tipo de dato DateTime que es la fecha ingresada por consola.
        //Devuelve un dato del tipo bool - TRUE cuando la fecha esta dentro del rango requerido o devuelve
        FALSE si el dato no esta dentro del rango requerido  
        */
        static bool validarEdad(DateTime fecha){
            bool ret;
            int edadDias = ((TimeSpan)(DateTime.Now-fecha)).Days;
            int edad = edadDias/365;
            if(edad>99 || edad<=0){
                Console.WriteLine("Edad ingresada: "+edad);
                ret = false;
            }else{
                Console.WriteLine("Edad ingresada: "+edad);
                ret = true;
            }
            return ret;
        }

        /*
        //Funcion calcularEdad
        //Funcion que evalua si la edad ingresada es mayoy o menor a 18, si es mayor
        devuelve un strng, si no lo es devuelve otro string
        //Recibe como parametro de entrada un tipo de dato DateTime que es la fecha ingresada por consola.
        //Devuelve un tipo de dato String que es el mensaje a mostrar
        */
        static string calcularEdad(DateTime fecha){
            string ret;
            int edadDias = ((TimeSpan)(DateTime.Now-fecha)).Days;
            int edad = edadDias/365;
            if(edad>=18){
                ret = "El alumno tiene aprobado el Ingreso";
            }else{
                ret = "El alumno no tiene aprobado el ingreso";
            }
            return ret;
        }

        /*
        //Funcion validarNombreApellido
        //Funcion que valida que el nombre y el apellido ingresado por consola se un dato valido
        //Recibe como parametro de entrada un tipo de dato String que es el nombre o el apellido ingresado por consola.
        //Devuelve un dato Bool - TRUE si el string es valido o FALSE si no lo es.
        */
        static bool validarNombreApellido(string nombreApellido){
            bool ret = true;
            for(int i=0; i<nombreApellido.Length; i++){
                if(Char.IsNumber(nombreApellido[i])){
                    ret = false;
                    break; 
                }
            }
            if(nombreApellido.Length==0 || nombreApellido.Contains(" ")){
                ret=false;
            }
            return ret;
        }

        /*
        //Funcion validarDni
        //Funcion que valida que el DNI ingresado por consola se un dato valido
        //Recibe como parametro de entrada un tipo de dato INT que es el DNI ingresado por consola.
        //Devuelve un dato Bool - TRUE si el DNI es valido o FALSE si no lo es.
        */
         static bool validarDni(int dni){
            bool ret = true;
            if(dni>99999999 || dni < 1000000){
                ret = false;
            }
            return ret;
        }        
    }
}
