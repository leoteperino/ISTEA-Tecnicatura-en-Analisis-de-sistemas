using System;
using System.IO;
using System.Collections.Generic;

namespace Parcial2_ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables y estructuras a utilizar
            List<string> listaProductos=new List<string>();
            List<string> listaDescripcion=new List<string>();
            List<int> listaCantidad=new List<int>();
            List<double> listaPrecios=new List<double>();

            cargarMocksListas(      ref listaProductos,
                                    ref listaDescripcion,
                                    ref listaCantidad,
                                    ref listaPrecios);
            do{
                int opcionMenuElegida = 0;
                opcionMenuElegida = imprimirMenu();
                setearFuncionesMenu(opcionMenuElegida,
                                    ref listaProductos,
                                    ref listaDescripcion,
                                    ref listaCantidad,
                                    ref listaPrecios);
            }while(true);
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
                    Console.Write("---VENTA DE ELECTRODOMESTICOS---\n"+
                                        "1-Agregar productos\n"+
                                        "2-Incrementar precios\n"+
                                        "3-Ingresar venta\n"+
                                        "4-Actualizar Stock\n"+
                                        "5-Ver lista de Productos\n"+
                                        "6-Salir\n"+
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
            if(opcionMenu>6 || opcionMenu <=0){
                ret = -1;
            }else if(opcionMenu==6){
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
                                        ref List<string> listaProductos,
                                        ref List<string> listaDescripcion,
                                        ref List<int> listaCantidad,
                                        ref List<double> listaPrecios){
            switch(opcionMenuElegida){
                case 1:
                    agregarProductos(ref listaProductos,
                                     ref listaDescripcion,
                                     ref listaCantidad,
                                     ref listaPrecios);
                    break;
                case 2:
                    incrementarPrecios(listaProductos, ref listaPrecios);
                    break;
                case 3:
                    ingresarVenta(ref listaProductos,
                                  ref listaDescripcion,
                                  ref listaCantidad,
                                  ref listaPrecios);
                    break;
                case 4:
                    actualizarStock(listaProductos, ref listaCantidad);
                    break;
                case 5:
                    mostrarProductos( listaProductos,
                                      listaDescripcion,
                                      listaCantidad,
                                      listaPrecios);
                    break;
            }
        }

        /*
        //Funcion ingresarVenta
        //Recibe como paramentros de den entrada las 4 listas pasadas por referencia
        //No decuelve datos
        //Esta funcion ingresa y valida una venta en el sistema
        Pide el producto a vender, chequea que seaun producto existente
        Pide la cantidad vendida, chequea que haya stock suficiente para realizar la venta
        Si todos los datos son correctos:
        Muestra todos los datos de la venta
        Actualiza el stock
        Copia en un archivo txt las ventas realizadas 
        */
        static void ingresarVenta(ref List<string> listaProductos,
                                  ref List<string> listaDescripcion,
                                  ref List<int> listaCantidad,
                                  ref List<double> listaPrecios){
            Console.Clear();                                
            Console.WriteLine("\n==========Ingreso de Ventas==========");
            for(int i=0; i<listaProductos.Count; i++){
                Console.WriteLine("{0}-{1}\tCantidad: {2}",i+1,listaProductos[i],listaCantidad[i]);
            }
            bool esValido = true;
            int productoElegido;
            int cantidadVendida;
            do{
                try{
                    Console.WriteLine("Elija el producto a vender: ");
                    productoElegido = int.Parse(Console.ReadLine());
                    if(productoElegido<=0 || productoElegido>listaProductos.Count){
                        esValido=false;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("[ERROR]-Ingreso un producto incorrecto");
                        Console.WriteLine("Pulse una tecla para continuar...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                    }else{
                        Console.WriteLine("***Cantidad vendida***");
                        Console.WriteLine("Producto: "+listaProductos[productoElegido-1]);
                        cantidadVendida = pedirCantidad();
                        if(cantidadVendida>listaCantidad[productoElegido-1]){
                            esValido=false;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("[ERROR]-la cantidad ingresada supera el stock actual");
                            Console.WriteLine("Pulse una tecla para continuar...");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey();
                        }else{
                            esValido=true;
                            DateTime fecha = DateTime.Now;
                            double precioTotalVenta = listaPrecios[productoElegido-1]*cantidadVendida;
                            int cantidadActual = listaCantidad[productoElegido-1];
                            String fechaFormat = fecha.ToString("dd/MM/yyyy");
                            String fechaHoraFormat = fecha.ToString("dd/MM/yyyy hh:mm");
                            string ruta="/home/leandro/Desktop/ISTEA/1erCuatrimestre_2021/ProgramacionLogica/c#Proyects/Parciales/Parcial2/Parcial2-ej2/ventas.txt";
                            string contenido=   "***Venta realizada: \n"+
                                                "Fecha: "+fechaHoraFormat+"\n"+
                                                "Producto: "+listaProductos[productoElegido-1]+"\n"+
                                                "Descripcion: "+listaDescripcion[productoElegido-1]+"\n"+
                                                "Cantidad vendida: "+cantidadVendida+"\n"+
                                                "Importe venta: "+precioTotalVenta.ToString("C")+"\n"+
                                                "============================================================";
                            escribirVenta(contenido,ruta);
                            //Actualizacion de Stock
                            listaCantidad[productoElegido-1] = cantidadActual-cantidadVendida;
                            Console.WriteLine("***Venta Realizada***\n"+
                                              "Fecha de venta: {0}\n"+
                                              "Producto: {1}\n"+
                                              "Cantidad vendida: {2}\n"+
                                              "Precio x Unidad: {3}\n"+
                                              "Precio Total de venta: {4}\n"+
                                              "Datos de la venta guardados y actualizados\n"+
                                              "Toque cualquier tecla para continuar.....",  
                                              fechaFormat,
                                              listaProductos[productoElegido-1],
                                              cantidadVendida,
                                              listaPrecios[productoElegido-1].ToString("C"),
                                              precioTotalVenta.ToString("C"));
                            Console.ReadKey();
                        }
                    }
                }catch(Exception){
                    esValido=false;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("[ERROR]-Ingreso un producto incorrecto");
                    Console.WriteLine("Pulse una tecla para continuar...");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey(); 
                }
            }while(!esValido);
        }

        /*
        //Funcion escribirVenta
        //Recibe como parametros de esntrada la ruta a un archivo txt y el contenido 
        que quiere cargar en es archivo
        //No devuelde datos
        //Raliza la escritura en un archivo de los datos pasados por parametro
        */
        static void escribirVenta(string contenido,string ruta)
        {
            File.AppendAllLines(ruta,new String[]{contenido});
        }


        /*
        //Funcion agregarProductos
        //Recibe como parementros de entrada todas las listas por referencia
        //No devuelve datos
        //Se encarga de agregar un producto a la lista de productos
        Pide usuario y contraseña validos para poder agregar el producto
        Pide el prodcuto a agregar y chequea que sea un producto valido
        Agrega el producto a la lista de productos
        */
        static void agregarProductos(   ref List<string> listaProductos,
                                        ref List<string> listaDescripcion,
                                        ref List<int> listaCantidad,
                                        ref List<double> listaPrecios){
            Console.Clear();                                
            Console.WriteLine("\n==========Ingreso de Productos==========");
            bool esUser;
            esUser = pedirUsuarioClave();
            if(esUser){
                Console.WriteLine("Usuario y clave correctos!");
                listaProductos.Add(pedirProducto(listaProductos));
                listaDescripcion.Add(pedirDescripcion());
                listaCantidad.Add(pedirCantidad());
                listaPrecios.Add(pedirPrecios());
                Console.WriteLine("Producto Ingresado con exito!!");
                mostrarProductos(listaProductos,listaDescripcion,listaCantidad,listaPrecios);   
            }
        }

        /*
        //Funcion pedirUsuarioClave
        //No recibe parametros
        //Devuelde un dato bool - TRUE o FALSE
        //Se encarga de realizar la validacion de usuario y pass, si los datos ingresados
        son correctos devuelve TRUE sino devuelve FALSE
        */
        static bool pedirUsuarioClave(){
            List<string> Usuarios=new List<string>();
            List<string> Pass=new List<string>();
            bool esUser = true;
            string usuario;
            string pass;
            do{
                //Pido los datos
                Console.Write("Ingrese Usuario: ");
                usuario=Console.ReadLine();
                Console.Write("Ingrese Password: ");
                pass=Console.ReadLine();
                //Cargo las listas de Usuarios y Claves
                var reader=new StreamReader(File.OpenRead("/home/leandro/Desktop/ISTEA/1erCuatrimestre_2021/ProgramacionLogica/c#Proyects/Parciales/Parcial2/Parcial2-ej2/users.csv"));
                while(!reader.EndOfStream)
                {
                    var linea=reader.ReadLine();
                    var valor=linea.Split(',');
                    Usuarios.Add(valor[0]);
                    Pass.Add(valor[1]);
                }
                //Verifico si los datos ingresados son correctos
                for(int i=0; i<Usuarios.Count;i++){
                    if(usuario == Usuarios[i] && pass==Pass[i]){
                        esUser=true;
                    }else{
                        esUser=false;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("[ERROR]-Usuario o clave Incorrecta");
                        Console.WriteLine("Pulse una tecla para continuar...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                    }
                }
            }while(!esUser);
            return esUser;
        }

        /*
        //Funcion pedirProducto
        //Recibe como parametro de entrada la lista de Productos
        //Devuelde un dato string que el producto ingresado por el usuario
        //Se encarga de pedir un producto al usuario y lo devuelve luego de validarlo
        */
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

        /*
        //Funcion validarProducto
        //Recibe como parametro de entrada un string que es el producto ingresado
        //Devuelde un dato bool TRUE si el producto es valido - FALSE si no lo es
        //Se encarga de validar que el producto ingresado por el usuario sea el correcto
        */
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

        /*
        //Funcion verificarProductoExistente
        //Recibe como parametro de entrada un string que es producto ingresado y una 
        lista de productos existentes
        //Devuelde un dato bool, TRUE si el producto no existe en la lista - FALSE si pertenece a la lista
        //Se encarga de chequear si el producto ingresado por el usuario se encuentra dentro de la lista de productos.
        */
        static bool verificarProductoExistente(string producto, List<string> listaProductos){
            bool ret = true;
            if(listaProductos.Contains(producto)){
                ret=false;
            }
            return ret;
        }

        /*
        //Funcion pedirDescripcion
        //No recibe parametros de entrada
        //Devuelde un dato string que es la descripcion del producto
        //Se encarga de pedir la descripcion de un producto por pantalla
        */
        static string pedirDescripcion(){
            bool esValido;
            string ret = "";
            do{
                esValido=true;
                Console.Write("Ingrese Descripcion del producto: ");
                ret = Console.ReadLine();
                if(!validarDescripcion(ret)){
                    esValido=false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[ERROR]-Ingreso una descripcion que no es valida");
                    Console.WriteLine("Pulse cualquier tecla para continuar....");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }while(!esValido);
            return ret;
        }

        /*
        //Funcion validarDescripcion
        //Recibe como parametro de entrada un string que es la descripcion ingresada
        //Devuelde un dato bool TRUE si la descripcion es valido - FALSE si no lo es
        //Se encarga de validar que la descripcion ingresada por el usuario sea correcta
        */
        static bool validarDescripcion(string descripcion){
            bool ret = true;
            if(descripcion.Length==0){
                ret=false;
            }
            return ret;
        }

        /*
        //Funcion pedirDescripcion
        //No recibe parametros de entrada
        //Devuelde un dato string que es la cantidad ingresada
        //Se encarga de pedir la cantidad de un producto por pantalla
        */
        static int pedirCantidad(){
            bool esValido = true;
            int ret = 0;
            int cantidad = 0;
            do{
                try{
                    Console.Write("Ingrese la cantidad: ");
                    cantidad = int.Parse(Console.ReadLine());
                    esValido = true;
                    ret = cantidad;
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
        //Funcion pedirPrecios
        //No recibe parametros de entrada
        //Devuelde un dato double que es el precio ingresada
        //Se encarga de pedir el precio de un producto por pantalla
        */
        static double pedirPrecios(){
            bool esValido = true;
            double ret = 0;
            double precio = 0;
            do{
                try{
                    Console.Write("Ingrese el precio: ");
                    precio = double.Parse(Console.ReadLine());
                    if(validarPrecio(precio)){
                        esValido = true;
                        ret = precio;   
                    }else{
                        esValido = false;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("[ERROR]-El precio no puede ser 0");
                        Console.WriteLine("Pulse una tecla para continuar...");
                        Console.ReadKey(); 
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }catch(Exception){
                    esValido = false;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("[ERROR]-No ingreso un precio valido");
                    Console.WriteLine("Pulse una tecla para continuar...");
                    Console.ReadKey(); 
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }while(!esValido);
                return ret;
        }

        /*
        //Funcion validarPrecio
        //Recibe como parametro de entrada un double que es la precio ingresado
        //Devuelde un dato bool TRUE si el precio es valido - FALSE si no lo es
        //Se encarga de validar que el precio ingresada por el usuario sea correcto
        */
        static bool validarPrecio(double precio){
            bool ret = true;
            if(precio==0){
                ret=false;
            }
            return ret;
        }

        /*
        //Funcion incrementarPrecios
        //Recibe como parametros de entrada una lista de productos y una lista de precios por referencia
        //No devuelve datos
        //Se encarga de pedir pantalla el precio que se quiere incrementar, valida que el producto exista 
        en la lista, pide un porcentaje de incremento, si los datos son correctos, incrementa el precio 
        del producto, sino vualve a pedir los datos.
        */
        static void incrementarPrecios(List<string> listaProductos, ref List<double> listaPrecios){
            //Muestro los productos y los precios
            Console.Clear();
            Console.WriteLine("\n==========Modificar Precios==========");
            for(int i=0;i<listaProductos.Count;i++){
                Console.WriteLine("{0}-{1}\t{2}",i+1,listaProductos[i],listaPrecios[i].ToString("C"));   
            }
            //Pregunto el producto a modificar y valido que sea correcto
            bool esValido = true;
            int productoElegido = 0;
            double porcentajeIncremento = 0;
            double nuevoPrecio = 0;
            double porcentajeTotal = 0;
            double precioActual = 0;
            do{
                try{
                    Console.WriteLine("Elija el numero del Producto al cual desea cambiar el precio: ");
                    productoElegido = int.Parse(Console.ReadLine());
                    if(productoElegido<=0 || productoElegido>listaProductos.Count){
                        esValido = false;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("[ERROR]-No ingreso un numero valido");
                        Console.WriteLine("Pulse una tecla para continuar...");
                        Console.ReadKey(); 
                        Console.ForegroundColor = ConsoleColor.White;
                    }else{
                        esValido = true;
                        //Modifico el precio
                        porcentajeIncremento = pedirPorcentaje();
                        precioActual = listaPrecios[productoElegido-1];
                        porcentajeTotal = (listaPrecios[productoElegido-1]*porcentajeIncremento)/100;
                        nuevoPrecio = listaPrecios[productoElegido-1]+porcentajeTotal;
                        listaPrecios[productoElegido-1]=nuevoPrecio;
                        Console.WriteLine(  "Usted elegio: {0}\n"+
                                            "Precio actual: {1}\n"+
                                            "Porcentaje de Incremento: {2}%\n"+
                                            "Incremento del precio: {3}\n"+
                                            "Precio Actualizado: {4}",
                                            listaProductos[productoElegido-1],
                                            precioActual.ToString("C"),
                                            porcentajeIncremento,
                                            porcentajeTotal.ToString("C"),
                                            nuevoPrecio.ToString("C"));
                        Console.WriteLine("Pulse una tecla para continuar...");
                        Console.ReadKey();
                    }
                }catch(Exception){
                    esValido = false;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("[ERROR]-No ingreso un numero valido");
                    Console.WriteLine("Pulse una tecla para continuar...");
                    Console.ReadKey(); 
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }while(!esValido);  
        }

        /*
        //Funcion pedirPorcentaje
        //No recibe datos
        //Devuelve un int que es el porcentaje ingresado por el usuario
        //Se encarga de pedir por pantalla el porcentaje de incremento para el precio de un producto
        si es correcto devuelve el dato sino realiza el pedido nuevamente
        */
        static int pedirPorcentaje(){
            bool esValido = true;
            int ret = 0;
            int porcentaje = 0;
            do{
                try{
                    Console.Write("Ingrese el porcentaje de incremento: ");
                    porcentaje = int.Parse(Console.ReadLine());
                    if(validarPorcentaje(porcentaje)){
                        esValido = true;
                        ret = porcentaje;   
                    }else{
                        esValido = false;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("[ERROR]-El porcentaje no puede ser 0");
                        Console.WriteLine("Pulse una tecla para continuar...");
                        Console.ReadKey(); 
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }catch(Exception){
                    esValido = false;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("[ERROR]-No ingreso un porcentaje valido");
                    Console.WriteLine("Pulse una tecla para continuar...");
                    Console.ReadKey(); 
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }while(!esValido);
                return ret;
        }

        /*
        //Funcion validarPorcentaje
        //Recibe como parametro de entrada un int que es la porcentaje ingresado
        //Devuelde un dato bool TRUE si el porcentaje es valido - FALSE si no lo es
        //Se encarga de validar que el porcentage ingresado por el usuario sea correcto
        */
        static bool validarPorcentaje(int porcentaje){
            bool ret = true;
            if(porcentaje==0){
                ret=false;
            }
            return ret;
        }

        /*
        //Funcion actualizarStock
        //Recibe como parametros de entrada la lista de productos y la lista de cantidades por referencia
        //No devuelve datos
        //Se encarga de actualizar el stock de un producto de forma manual
        Pide por pantalla el producto a actualizar, valida que este exista en la lista
        Pide la cantidad a actuaizar, si los datos son correctos actualiza el stock, sino
        muestra error y pide los datos nuevamente
        */
        static void actualizarStock(List<string> listaProductos, ref List<int> listaCantidad){
            //Muestro los productos y las cantidaes
            Console.Clear();
            Console.WriteLine("\n==========Actualizar Stock==========");
            for(int i=0;i<listaProductos.Count;i++){
                Console.WriteLine("{0}-{1}\tCantidad: {2}",i+1,listaProductos[i],listaCantidad[i]);   
            }
            //Pregunto el producto a modificar y valido que sea correcto
            bool esValido = true;
            int productoElegido = 0;
            int cantidadActual = 0;
            int cantidadActualizada = 0;
            do{
                try{
                    Console.WriteLine("Elija el numero del Producto al cual desea actualizar el stock: ");
                    productoElegido = int.Parse(Console.ReadLine());
                    if(productoElegido<=0 || productoElegido>listaProductos.Count){
                        esValido = false;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("[ERROR]-No ingreso un numero valido");
                        Console.WriteLine("Pulse una tecla para continuar...");
                        Console.ReadKey(); 
                        Console.ForegroundColor = ConsoleColor.White;
                    }else{
                        esValido = true;
                        //Modifico la cantidad
                        cantidadActual = listaCantidad[productoElegido-1];
                        cantidadActualizada = pedirCantidad();
                        listaCantidad[productoElegido-1]=cantidadActualizada;
                        Console.WriteLine(  "Usted elegio: {0}\n"+
                                            "Cantidad actual: {1}\n"+
                                            "Cantidad Actualizada: {2}",
                                            listaProductos[productoElegido-1],
                                            cantidadActual,
                                            cantidadActualizada);
                        Console.WriteLine("Pulse una tecla para continuar...");
                        Console.ReadKey();
                    }
                }catch(Exception){
                    esValido = false;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("[ERROR]-No ingreso un numero valido");
                    Console.WriteLine("Pulse una tecla para continuar...");
                    Console.ReadKey(); 
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }while(!esValido);  
        }

        /*
        //Funcion mostrarProductos
        //Funcion que muestra por pantalla la lista de productos actualizada
        //Recibe por parametros las 4 listas que utilizamos
        //No devuelve ningun dato 
        */
        static void mostrarProductos(   List<string> listaProductos,
                                        List<string> listaDescripcion,
                                        List<int> listaCantidad,
                                        List<double> listaPrecios){
            Console.Clear();                                    
            Console.WriteLine("\n==========Listado de Productos==========");
            for(int x =0;x<listaProductos.Count;x++)
            {
                Console.WriteLine(  "{0}-{1}\t-Desc: {2} --Cantidad: {3} --Precio: {4}",
                                    x+1,
                                    listaProductos[x],
                                    listaDescripcion[x],
                                    listaCantidad[x],
                                    listaPrecios[x].ToString("C"));
            }
            Console.WriteLine("Presione una letra para continuar.......");
            Console.ReadKey();
        }

        /*
        //Funcion cargarMocksListas
        //Funcion que carga las listas que se van a utilizar durante el ejercicio
        //Recibe como parametro de referencia todas las lista que utilizaremos
        //No devuelve datos
        */
        static void cargarMocksListas(  ref List<string> listaProductos,
                                        ref List<string> listaDescripcion,
                                        ref List<int> listaCantidad,
                                        ref List<double> listaPrecios){
            listaProductos.AddRange(new string[]
            {
                "Heladera",
                "Lavarropas",
                "Televisor",
                "Cafetera",
                "Tostadora"
            });

            listaDescripcion.AddRange(new string[]
            {
                "Heladera inverter no frost RT38",
                "Lavasecarropas automático Candy",
                "Smart TV Samsung Series 7 4K 50",
                "Cafetera Ultracomb CE-6108 auto",
                "Tostadora Blanca Black&Decker 4"
            });

            listaCantidad.AddRange(new int[]
            {
                23,56,120,200,560
            });

            listaPrecios.AddRange(new double[]
            {
                108000,
                97000,
                68399,
                16570,
                6780
            });
        }
    }
}

