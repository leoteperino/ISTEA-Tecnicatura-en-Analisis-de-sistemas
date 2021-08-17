using System;
using System.IO;
using System.Collections.Generic;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Integrador Listas:
            Se deberá generar una aplicación consola que implemente una lista de datos 
            de tipo string junto su respectivo menú con las opciones de agregar, eliminar, 
            mostrar, contar elementos, buscar ,ordenar y borrar la lista.
            Todo debe estar incluido dentro de funciones para tal fin, y como el 
            ejercicio anterior, en caso de que el usuario no agregue ningún dato se 
            ingresara "como nuevo elemento"
            */

            List<string> listaProductos=new List<string>();
            cargarMocksListas(ref listaProductos);
            do{
                int opcionMenuElegida = 0;
                opcionMenuElegida = imprimirMenu();
                setearFuncionesMenu(opcionMenuElegida,
                                    ref listaProductos);
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
                    Console.Write("---ABM Listas de String---\n"+
                                        "1-Agregar productos\n"+
                                        "2-Eliminar productos\n"+
                                        "3-Mostar productos\n"+
                                        "4-Contar productos\n"+
                                        "5-Buscar productos\n"+
                                        "6-Ordenar productos\n"+
                                        "7-Borrar la lista\n"+
                                        "8-Salir\n"+
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
            if(opcionMenu>8 || opcionMenu <=0){
                ret = -1;
            }else if(opcionMenu==8){
                ret = 0;
            }else{
                ret = 1;
            }
            return ret;
        }


        static void setearFuncionesMenu(int opcionMenuElegida,
                                        ref List<string> listaProductos){
            switch(opcionMenuElegida){
                case 1:
                    agregarProductos(ref listaProductos);
                    break;
                case 2:
                    eliminarProductos(ref listaProductos);
                    break;
                case 3:
                    mostrarProductos(listaProductos);
                    break;
                case 4:
                    //contarProductos(listaCantidad);
                    break;
                case 5:
                    //buscarProductos(listaProductos);
                    break;
                case 6:
                    //ordenarProductos(listaProductos);
                    break;
                case 7:
                    //borrarLista(listaProductos);
                    break;
            }
        }

        static void agregarProductos(ref List<string> listaProductos){
            Console.Clear();                                
            Console.WriteLine("\n==========Ingreso de Productos==========");
            bool esUser;
            listaProductos.Add(pedirProducto(listaProductos));
            mostrarProductos(listaProductos);   
        }

        static string pedirProducto(List<string> listaProductos){
            bool esValido;
            string ret = "";
            do{
                esValido=true;
                Console.Write("Ingrese el Producto a agregar: ");
                ret = Console.ReadLine();
                if(!validarProducto(ret)){
                    esValido=false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[ERROR]-Ingreso un producto que no es valido");
                    Console.WriteLine("Pulse cualquier tecla para continuar....");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                }else if(verificarProductoExistente(ret, listaProductos)){
                    esValido = true;
                }else{
                    esValido = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[ERROR]-El producto que quiere ingresar ya existe en la lista");
                    Console.WriteLine("Pulse cualquier tecla para continuar....");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }while(!esValido);
            return ret;
        }

        static bool validarProducto(string producto){
            bool ret = true;
            for(int i=0; i<producto.Length; i++){
                if(Char.IsNumber(producto[i])){
                    ret = false;
                    break; 
                }
            }
            if(producto.Length==0 || producto.Contains(" ")){
                ret=false;
            }
            return ret;
        }

        static bool verificarProductoExistente(string producto, List<string> listaProductos){
            bool ret = true;
            if(listaProductos.Contains(producto)){
                ret=false;
            }
            return ret;
        }

        static void mostrarProductos(List<string> listaProductos){
            Console.Clear();                                    
            Console.WriteLine("\n==========Listado de Productos==========");
            for(int x =0;x<listaProductos.Count;x++)
            {
                Console.WriteLine(listaProductos[x]);
            }
            Console.WriteLine("Presione una letra para continuar.......");
            Console.ReadKey();
        }



        static void cargarMocksListas(ref List<string> listaProductos){
            listaProductos.AddRange(new string[]
            {
                "Heladera",
                "Lavarropas",
                "Televisor",
                "Cafetera",
                "Tostadora"
            });
        }
    }
}
