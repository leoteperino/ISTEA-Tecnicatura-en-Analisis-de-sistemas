using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Realizar una aplicación consola que a partir de dos listas genere una repositorio 
                de mails y contraseñas, la misma deberá verificar que los mails y usuarios a 
                ingresar pasen por los requisitos de seguridad mínima y además que no estén 
                ya ingresados en la lista.
                Todo deberá ser desarrollado con funciones y expresiones regulares.
            */
            List<string> listaMails=new List<string>();
            List<string> listaContraseñas=new List<string>();
            do{
                int opcionMenu;
                opcionMenu = imprimirMenu();
                setearFuncionesMenu(opcionMenu,listaMails,listaContraseñas);    
            }while(true); 
        }

        static int imprimirMenu(){
            bool esValido = true;
            int ret = 0;
            do{
                try{
                    Console.Clear();
                    esValido = true;
                    int opcionMenu;
                    Console.Write("======Listas de Mails y Contraseñas======\n"+
                                    "1-Ingresar nuevo Usuario\n"+
                                    "2-Mostrar Listas\n"+
                                    "3-Salir\n"+
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
            if(opcionMenu>3 || opcionMenu <=0){
                ret = -1;
            }else if(opcionMenu==3){
                ret = 0;
            }else{
                ret = 1;
            }
            return ret;
        }

         static void setearFuncionesMenu(   int opcionMenuElegida,
                                            List<string> listaMails,
                                            List<string> listaContraseñas){
            switch(opcionMenuElegida){
                case 1:
                    ingresarNuevoUsuario(ref listaMails, ref listaContraseñas);
                    break;
                case 2:
                    mostrasListas(listaMails, listaContraseñas);
                    break;
            }
        }

        static void ingresarNuevoUsuario(ref List<string> listaMails,ref List<string> listaContraseñas){
            Console.Clear();
            Console.WriteLine("======Ingreso de Usuarios======");
            bool esDatoValido = true;
            string mail = "";
            string pass = "";

            do{
                Console.Write("Ingrese su mail: ");
                mail = Console.ReadLine();
                if(validarMail(mail)){
                    do{
                        Console.Write("===Password===\n"+
                                      "La misma debe tener:\n"+
                                      "*Minimo de 8 caracteres\n"+
                                      "*Al menos una letra minuscula\n"+
                                      "*Al menos una letra Mayuscula\n"+
                                      "*Al menos un numero o un caracter especial\n"+
                                      "Ingrese la Password: ");
                        pass = Console.ReadLine();
                        if(validarPassword(pass)){
                            esDatoValido=true;
                            listaMails.Add(mail);
                            listaContraseñas.Add(pass);
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

        static bool validarMail(string mail){
            bool ret;
            string formato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            Regex r = new Regex(formato);
            if(r.IsMatch(mail)){
                ret=true;
            }else{
                Console.ForegroundColor = ConsoleColor.DarkRed; 
                Console.WriteLine("[ERROR]-El mail ingresado no es valido");
                Console.ForegroundColor = ConsoleColor.White; 
                ret=false; 
            }   
            return ret;  
        }

        static bool validarPassword(string pass){
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

        static void mostrasListas(List<string> listaMails, List<string> listaContraseñas){
            Console.Clear();
            Console.WriteLine("======Lista de Mails y Contraseñas======");
            if(listaMails.Count==0){
                Console.WriteLine("La lista esta vacia");
            }
            for(int i=0;i<listaMails.Count;i++){
                Console.WriteLine("Mail: {0}\tContraseña: {1}",listaMails[i], listaContraseñas[i]); 
            }
            Console.ReadKey();
        }
    }
}
