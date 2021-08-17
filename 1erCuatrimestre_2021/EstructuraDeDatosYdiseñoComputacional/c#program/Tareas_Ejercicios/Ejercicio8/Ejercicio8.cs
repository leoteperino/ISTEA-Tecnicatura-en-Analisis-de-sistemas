using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Generar una aplicación consola que implemente un diccionario con datos de usuarios y contraseñas, 
            el mismo deberá como mínimo utilizar 3 funciones
            -Ingresar usuarios.
            -Modificar contraseña.(opcional que la contraseña se valide con una expresión regular)
            -Ver usuarios y contraseñas.
            */

            Dictionary<string, string> usuarios = new Dictionary<string, string>();
            cargarMocksUsuarios(ref usuarios);
            do{
                int opcionMenu;
                opcionMenu = imprimirMenu();
                setearFuncionesMenu(opcionMenu, ref usuarios);    
            }while(true);
        }

        static void cargarMocksUsuarios(ref Dictionary<string, string> usuarios){
            usuarios.Add("usuario1@gmail.com", "PassUsuario1");
            usuarios.Add("usuario2@gmail.com", "PassUsuario2");
            usuarios.Add("usuario3@gmail.com", "PassUsuario3");
            usuarios.Add("usuario4@gmail.com", "PassUsuario4");
        }

        static int imprimirMenu(){
            bool esValido = true;
            int ret = 0;
            do{
                try{
                    Console.Clear();
                    esValido = true;
                    int opcionMenu;
                    Console.Write("======ABM Usuarios======\n"+
                                    "1-Ingresar nuevo usuario\n"+
                                    "2-Cambiar Contraseña\n"+
                                    "3-Mostrar Usuarios\n"+
                                    "4-Salir\n"+
                                    "Ingrese la opcion deseada: ");
                    opcionMenu = int.Parse(Console.ReadLine());
                    if(validarOpcionMenu(opcionMenu)==1){
                        ret = opcionMenu;
                    }else if(validarOpcionMenu(opcionMenu)==0){
                        Environment.Exit(-1);
                    }else if(validarOpcionMenu(opcionMenu)==-1){
                        esValido = false;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("[ERROR]-Eligio una opcion que no esta en el menu.");
                        Console.WriteLine("Pulse una tecla para continuar...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                    }
                }catch(Exception){
                    esValido = false;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("[ERROR]-La opcion Ingresada no esta en el Menu");
                    Console.WriteLine("Pulse una tecla para continuar...");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                }
            }while(!esValido);
            return ret;  
        }

        static int validarOpcionMenu(int opcionMenu){
            int ret;
            if(opcionMenu>4 || opcionMenu <=0){
                ret = -1;
            }else if(opcionMenu==4){
                ret = 0;
            }else{
                ret = 1;
            }
            return ret;
        }


        static void setearFuncionesMenu(int opcionMenuElegida,
                                        ref Dictionary<string, string> usuarios){
            switch(opcionMenuElegida){
                case 1:
                    ingresarNuevoUsuario(ref usuarios);
                    break;
                case 2:
                    cambiarContraseña(ref usuarios);
                    break;
                case 3:
                    mostrarUsuarios(usuarios);
                    break;
            }
        }

        static void ingresarNuevoUsuario(ref Dictionary<string, string> usuarios){
            Console.Clear();
            mostrarUsuarios(usuarios);
            Console.WriteLine("======Ingreso de Usuarios======");
            bool esDatoValido = true;
            string mail = "";
            string pass = "";

            do{
                Console.Write("Ingrese su mail: ");
                mail = Console.ReadLine();
                if(validarMail(mail, usuarios)){
                    do{
                        Console.Write("===Password===\n"+
                                      "La misma debe tener:\n"+
                                      "*Minimo de 8 caracteres\n"+
                                      "*Al menos una letra minuscula\n"+
                                      "*Al menos una letra Mayuscula\n"+
                                      "*Al menos un numero o un caracter especial\n"+
                                      "Ingrese la Password: ");
                        pass = Console.ReadLine();
                        if(validarPassword(pass,usuarios)){
                            esDatoValido=true;
                            usuarios.Add(mail,pass);
                            Console.WriteLine("Datos Ingresados con exito!!");
                            Console.WriteLine("=============================");
                            Console.WriteLine("Presione cualquier tecla para volver al Menu\n");
                            Console.ReadKey();
                        }else{
                            esDatoValido = false;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("[ERROR]-No ingreso una Password valida");
                            Console.WriteLine("=============================");
                            Console.WriteLine("Pulse una tecla para continuar...");
                            Console.ReadKey(); 
                            Console.ForegroundColor = ConsoleColor.White;  
                        }
                    }while(!esDatoValido);
                }else{
                    esDatoValido = false;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Pulse una tecla para continuar...");
                    Console.ReadKey(); 
                    Console.ForegroundColor = ConsoleColor.White; 
                }
            }while(!esDatoValido);     
        }

        static void mostrarUsuarios(Dictionary<string, string> usuarios){
            Console.Clear();
            Console.WriteLine("======Lista de Usuarios======");
            int i=0;
            foreach( KeyValuePair<string, string> usu in usuarios)
            {
                i++;
                Console.WriteLine("Usuario: {0}\tMail: {1}\tPass: {2}",i,usu.Key,usu.Value);
            }
            Console.WriteLine("=============================");
            Console.WriteLine("Presione cualquier tecla para continuar....\n");
            Console.ReadKey();
        }

        static bool validarMail(string mail, Dictionary<string, string> usuarios){
            bool ret;
            string formato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            Regex r = new Regex(formato);

            if(usuarios.ContainsKey(mail)){
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[ERROR]-El mail ingresado ya existe en la lista");
                Console.ForegroundColor = ConsoleColor.White; 
                ret=false;
            }else{
                if(r.IsMatch(mail)){
                    ret=true;
                }else{
                    Console.ForegroundColor = ConsoleColor.DarkRed; 
                    Console.WriteLine("[ERROR]-El mail ingresado no es valido");
                    Console.ForegroundColor = ConsoleColor.White; 
                    ret=false; 
                }   
            }
            return ret;  
        }

        static bool validarPassword(string pass,Dictionary<string, string> usuarios){
            bool ret;
            string formato = "(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
            Regex r = new Regex(formato);
            if(r.IsMatch(pass)){
                ret=true;
            }else{
                ret=false; 
            }   
            return ret;  
        }

        static void cambiarContraseña(ref Dictionary<string, string> usuarios){
            Console.Clear();
            string mail="";
            string passActual="";
            string passIngresada="";
            string nuevaPass="";
            bool esDatoValido = true;
            mostrarUsuarios(usuarios);
            Console.WriteLine("======Cambio de Contraseña======");
            do{
                Console.Write("Ingrese Mail: ");
                mail = Console.ReadLine();
                if(usuarios.ContainsKey(mail)){
                    foreach( KeyValuePair<string, string> usu in usuarios)
                    {
                        if(usu.Key.Equals(mail)){
                            passActual = usu.Value;
                        }
                    }
                    esDatoValido=true;
                    do{
                        Console.Write("Ingrese password actual: ");
                        passIngresada = Console.ReadLine();
                        if(passIngresada==passActual){
                            Console.Write("===Nueva Password===\n"+
                                          "La misma debe tener:\n"+
                                          "*Minimo de 8 caracteres\n"+
                                          "*Al menos una letra minuscula\n"+
                                          "*Al menos una letra Mayuscula\n"+
                                          "*Al menos un numero o un caracter especial\n"+
                                          "Ingrese la nueva Password: ");
                            nuevaPass = Console.ReadLine();
                            if(nuevaPass!=passActual && validarPassword(nuevaPass,usuarios)){
                                esDatoValido=true;
                                usuarios[mail]=nuevaPass;
                                Console.WriteLine("Password modificada con Exito!!");
                            }else{
                                esDatoValido = false;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("[ERROR]-No ingreso una Password valida\n"+
                                "Recuerde que la nueva Password debe ser diferente a la anterior");
                                Console.WriteLine("Pulse una tecla para continuar...");
                                Console.ReadKey(); 
                                Console.ForegroundColor = ConsoleColor.White;     
                            }
                        }else{
                            esDatoValido=false;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("[ERROR]-La Password ingresada no es correcta");
                            Console.WriteLine("Pulse una tecla para continuar...");
                            Console.ReadKey(); 
                            Console.ForegroundColor = ConsoleColor.White; 
                        }    
                    }while(!esDatoValido);
                }else{
                    esDatoValido=false;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("[ERROR]-El mail ingresado no esta en la lista de Usuarios");
                    Console.WriteLine("Pulse una tecla para continuar...");
                    Console.ReadKey(); 
                    Console.ForegroundColor = ConsoleColor.White;   
                }
            }while(!esDatoValido);
            Console.WriteLine("=============================");
            Console.WriteLine("Pulse una tecla para volver al Menu...");
            Console.ReadKey(); 
        }

    }
}
