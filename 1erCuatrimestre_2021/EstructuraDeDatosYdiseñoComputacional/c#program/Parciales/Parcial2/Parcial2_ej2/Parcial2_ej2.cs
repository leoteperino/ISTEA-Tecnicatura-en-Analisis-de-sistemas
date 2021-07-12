using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Parcial2_ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> usuarios = new Dictionary<string, string>();
            Queue colaDeImpresion = new Queue(); 
            cargarMocksUsuarios(ref usuarios);

            do{
                int opcionMenu;
                opcionMenu = imprimirMenu();
                setearFuncionesMenu(opcionMenu, ref usuarios, colaDeImpresion);    
            }while(true);
        }

        /*
        //Funcion cargarMocksUsuarios
        //Funcion que carga el diccionario que se va a utilizar durante el ejercicio
        //Recibe como parametro de referencia el diccionareio a cargar
        //No devuelve datos
        */
        static void cargarMocksUsuarios(ref Dictionary<string, string> usuarios){
            usuarios.Add("usuario1@gmail.com", "PassUsuario1");
            usuarios.Add("usuario2@gmail.com", "PassUsuario2");
            usuarios.Add("usuario3@gmail.com", "PassUsuario3");
            usuarios.Add("usuario4@gmail.com", "PassUsuario4");
        }

        /*
        //Funcion imprimirMenu
        //Esta Funcion imprime el Menu de ingreso, pide el ingreso de una opcion
        de menu y valida que este dato sea el correcto y lo devuelve al Main, si el 
        dato no es correcto muestra error y vuelve a pedir el ingreso.
        //No tiene parametros de entrada.
        //Devuelde un dato tipo int que es la opcion ingresada y validada.
        */
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
                                    "3-Eliminar usuario\n"+
                                    "4-Enviar a Imprimir Documento\n"+
                                    "5-Ver Estado de Impresion\n"+
                                    "6-Mostrar Usuarios\n"+
                                    "7-Salir\n"+
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

        /*
        //Funcion validarOpcionMenu
        //Esta funcion valida que el dato ingresado en imprimirMenu sea el correcto
        //Recibe como parametro un dato int que es el numero de la opcion elegida
        //Devuelve un dato int que tiene 3 opciones - si el dato devuelto es 1
        es porque ese dato es correcto - si el dato devuelto es 0 es porque el cliente 
        quiere salir del programa - si el dato devuelto es -1 es porque es un ERROR,
        un dato invalido. 
        */
        static int validarOpcionMenu(int opcionMenu){
            int ret;
            if(opcionMenu>7 || opcionMenu <=0){
                ret = -1;
            }else if(opcionMenu==7){
                ret = 0;
            }else{
                ret = 1;
            }
            return ret;
        }

        /*
        //Funcion setearFuncionesMenu
        //Funcion que nos dirige a la funcionalidad elegida por el Cliente
        //Reecibe como parametros: un dato int que es la opcion de menu elegida y validada
        y las cuatro listas co las que se trabaja
        //No devuelve ningun dato  
        */
        static void setearFuncionesMenu(int opcionMenuElegida,
                                        ref Dictionary<string, string> usuarios,
                                        Queue colaDeImpresion){
            switch(opcionMenuElegida){
                case 1:
                    ingresarNuevoUsuario(ref usuarios);
                    break;
                case 2:
                    cambiarContraseña(ref usuarios);
                    break;
                case 3:
                    eliminarUsuario(ref usuarios);
                    break;
                case 4:
                    imprimirDocumento(usuarios,ref colaDeImpresion);
                    break;
                case 5:
                    verEstadoImpresion(ref colaDeImpresion);
                    break;
                case 6:
                    mostrarUsuarios(usuarios);
                    break;
            }
        }

        /*
        //Funcion ingresarNuevoUsuario
        //Funcion que nos pide mail y contraseña, realiza las validaciones y carga al Nuevo Usuario 
        si es que los datos ingresados son correctos
        //Reecibe como parametros el diccionario con los usuarios
        //No devuelve ningun dato  
        */
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

        /*
        //Funcion validarMail
        //Funcion que valida que el mail ingresado no este repetido en la lista y luego
        valida que el mail ingresado tenga el formato correspondiente.
        //Recibe como parametros el diccionario con los usuarios y el mail ingresado por 
        consola por el usuario
        //Devuelve un dato booleano, TRUE si es el mail es valido, FALSE si no lo es  
        */
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

        /*
        //Funcion validarPassword
        //Funcion que valida que la Pass ingresada tenga el formato requerido por Seguridad.
        //Recibe como parametros el diccionario con los usuarios y la pass ingresado por 
        consola por el usuario
        //Devuelve un dato booleano, TRUE si es la Pass es valida, FALSE si no lo es  
        */
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

        /*
        //Funcion cambiarContraseña
        //Funcion que realiza la modificacion de la contraseña siempre y cuando esta exista 
        en la lista de Usuarios
        //Reecibe como parametros el diccionario con los usuarios
        //No devuelve ningun dato  
        */
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


        /*
        //Funcion eliminarUsuario
        //Funcion que realiza la eliminacion de un usuario siempre y cuando esta exista 
        en la lista de Usuarios y se ingrese con las credenciales validas.
        //Recibe como parametros el diccionario con los usuarios por referencia
        //No devuelve ningun dato  
        */
        static void eliminarUsuario(ref Dictionary<string, string> usuarios){
            Console.Clear();
            string mail;
            string passActual="";
            string passIngresada="";
            bool esDatoValido = true;
            mostrarUsuarios(usuarios);
            Console.WriteLine("======Eliminacion de Usuarios======");
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
                        Console.Write("Ingrese password: ");
                        passIngresada = Console.ReadLine();
                        if(passIngresada==passActual){
                            esDatoValido=true;
                            usuarios.Remove(mail);     
                            Console.WriteLine("El usuario fue eliminado con Exito!!");
                        }else{
                            esDatoValido=false;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("[ERROR]-La Password ingresada es incorrecta");
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

        /*
        //Funcion imprimirDocumento
        //Funcion que pide usuario y pass si ambos son validos envia a imprimir un documento
        a la cola de impresion que instancia previamente
        //Reecibe como parametros el diccionario con los usuarios y la cola de impresion
        //No devuelve ningun dato  
        */
        static void imprimirDocumento(Dictionary<string, string> usuarios,
                                      ref Queue colaDeImpresion){
            Console.Clear();
            string mail;
            string passActual="";
            string passIngresada="";
            bool esDatoValido = true;
            mostrarUsuarios(usuarios);
            Console.WriteLine("======Enviar Imprimir Documento======");
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
                        Console.Write("Ingrese password: ");
                        passIngresada = Console.ReadLine();
                        if(passIngresada==passActual){
                            esDatoValido=true;
                            colaDeImpresion.Enqueue(mail);  
                            Console.WriteLine("El documento se envio a la cola de impresion....");
                            mostrarColaDeImpresion(colaDeImpresion);
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
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();    
        }

        static void verEstadoImpresion(ref Queue colaDeImpresion){
            Console.Clear();
            mostrarColaDeImpresion(colaDeImpresion);
            if(colaDeImpresion.Count>0){
                Console.WriteLine("Se imprimio el documento {0}",colaDeImpresion.Dequeue());
                mostrarColaDeImpresion(colaDeImpresion);
            }
            Console.WriteLine("=============================");
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();    
        }


        /*
        //Funcion mostrarColaDeImpresion
        //Funcion que nos muestra la cola de Impresion actualizada
        //Reecibe como parametros la cola de impresion
        //No devuelve ningun dato  
        */
        static void mostrarColaDeImpresion(Queue colaDeImpresion){
            int cantImpresiones = 0;
            Console.WriteLine("======Cola de Impresion======");
            cantImpresiones=colaDeImpresion.Count;
            if(cantImpresiones==0){
                Console.WriteLine("No hay documentos para imprimir");
            }else{
                int i=0;
                foreach(var x in colaDeImpresion){
                    i++;    
                    Console.WriteLine("Nro:{0}\tDocumento en impresion\tUsuario:{1}",i,x); 
                }
            } 
            Console.WriteLine("Cantidad de documentos en Impresion: "+cantImpresiones); 
        }

        /*
        //Funcion mostrarUsuarios
        //Funcion que nos muestra la lista de usuarios actualizada
        //Reecibe como parametros el diccionario con los usuarios
        //No devuelve ningun dato  
        */
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
    }
}
