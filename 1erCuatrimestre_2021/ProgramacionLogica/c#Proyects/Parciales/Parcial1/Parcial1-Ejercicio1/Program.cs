using System;

namespace Parcial1_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion e Inicializacion de variables
            int opcionMenu;
            string electrodomestico = "";
            int cantidadCuotas = 0;
            bool esNum;
            float precioProducto;
            bool esFloat;
            string precioFormatoMoneda;
            int porcentaje_intereses = 0;
            double calculo_interes;
            double precio_final;
            double valor_cuota;

            Console.Clear();
            do{
                //Se Muestra el Menu de opciones
                Console.Clear();    
                Console.Write("*********Bienvenido al Cotizador**********\n"+
                                  "1 - Microondas Grill LG NeoChef MH829\n"+
                                  "2 - Heladera Patrick HPK135\n"+
                                  "3 - Lavarropas automático Candy Alisè GVFWFL4139\n"+
                                  "4 - Salir\n"+
                                  "**********************************************\n"+
                                  "Ingrese el electrodomestico a facturar: ");
                //Se realiza la validacion de lo ingresado
                esNum = int.TryParse(Console.ReadLine(), out opcionMenu);
                if(esNum){
                    //Guardo el producto Ingresado en la variable electrodomestico
                    switch(opcionMenu){
                        case 1:
                            electrodomestico = "Microondas Grill LG NeoChef MH829";
                            break;
                        case 2:
                            electrodomestico = "Heladera Patrick HPK135";
                            break;
                        case 3:
                            electrodomestico = "Lavarropas automático Candy Alisè GVFWFL4139";
                            break;
                    }
                    //Recorro las opciones de Menu que se eligieron
                    switch(opcionMenu){
                        case 1:
                        case 2:
                        case 3:
                            do{
                                Console.Clear();
                                //Pido el precio del producto
                                Console.WriteLine("**********************************************\n"+
                                                  "Producto ingresado: {0}\n"+
                                                  "--\n"+
                                                  "*Ingrese el precio del producto[entre $20000 y $100000]\n"+
                                                  "*Ingrese 0 para salir del programa.\n"+
                                                  "**********************************************",electrodomestico);
                                //Se realiza la validacion de lo ingresado
                                esFloat = float.TryParse(Console.ReadLine(), out precioProducto);
                                if(esFloat){
                                    //Si lo ingresado es 0, hace un exit
                                    if(precioProducto==0){
                                        Console.WriteLine("\n**********************************************");
                                        Console.WriteLine("Saliendo.......");
                                        Console.WriteLine("**********************************************");
                                        Environment.Exit(-1);
                                    }
                                    //validacion del rango de precio
                                    if(precioProducto<20000 || precioProducto>100000){
                                        esFloat = false;
                                        Console.WriteLine("\n**********************************************");
                                        Console.ForegroundColor=ConsoleColor.Red;
                                        Console.WriteLine("[ERROR]-Ingreso un precio fuera del rango pedido\n"+
                                                          "Debe ingresar un precio entre 20.000 y 100.000 solo numeros\n"+
                                                          "Presione cualquier tecla y vuelva a intentarlo");
                                        Console.ForegroundColor=ConsoleColor.White;
                                        Console.WriteLine("**********************************************");
                                        Console.ReadKey();
                                    }else{
                                        do{
                                            //Muestro los datos ingresados al momento y pido las cuotas
                                            precioFormatoMoneda = precioProducto.ToString("C");
                                            Console.Clear();
                                            Console.WriteLine("**********************************************\n"+
                                                              "Producto ingresado: {0}\n"+
                                                              "Precio ingresado: {1}\n"+
                                                              "--\n"+
                                                              "*Ingrese la cantidad de cuotas[6-12-18]\n"+
                                                              "*Ingrese 0 para salir del programa.\n"+
                                                              "**********************************************",
                                                              electrodomestico, precioFormatoMoneda );
                                            //Validacion de las cuotas
                                            esNum = int.TryParse(Console.ReadLine(), out cantidadCuotas); 
                                            if(esNum){
                                                //pregunto por las cuotas ingresadas, las guardo en variables, proceso datos
                                                switch(cantidadCuotas){
                                                    case 0:
                                                        Console.WriteLine("\n**********************************************");
                                                        Console.WriteLine("Saliendo.......");
                                                        Console.WriteLine("**********************************************");
                                                        Environment.Exit(-1);
                                                        break;
                                                    case 6:
                                                    case 12:
                                                    case 18:
                                                        //Aca se procesa y se muestra el plan de cuotas
                                                        Console.Clear(); 
                                                        Console.WriteLine("Plan de cuotas\n--------------");
                                                        //Guardo la variable intereses segun la cantidad de cuotas
                                                        switch(cantidadCuotas){
                                                            case 6:
                                                                porcentaje_intereses = 30;
                                                                break;
                                                            case 12:
                                                                porcentaje_intereses = 50;
                                                                break;
                                                            case 18:
                                                                porcentaje_intereses = 80;
                                                                break;
                                                        }
                                                        //Calculo todos los valores que necesito
                                                        calculo_interes = (precioProducto*porcentaje_intereses)/100;
                                                        String calculo_interes_formato_moneda = calculo_interes.ToString("C");
                                                        precio_final= precioProducto + calculo_interes;
                                                        String precio_final_formato_moneda = precio_final.ToString("C");
                                                        valor_cuota=(precio_final/cantidadCuotas);
                                                        String valor_cuota_formato_moneda = valor_cuota.ToString("C");
                                                        DateTime fecha;  
                                                        fecha = DateTime.Now;
                                                        String fechaFormat = fecha.ToString("dd/MM/yyyy");
                                                        
                                                        //Muestro por pantalla los datos
                                                        Console.WriteLine("Producto: "+electrodomestico);
                                                        Console.WriteLine("Precio: "+precioFormatoMoneda);
                                                        Console.WriteLine("Cantidad Cuotas: "+cantidadCuotas);
                                                        Console.WriteLine("Interes: "+porcentaje_intereses+"%");
                                                        Console.WriteLine("Total Intereses: "+calculo_interes_formato_moneda);
                                                        Console.WriteLine("Precio final con Intereses: "+ precio_final_formato_moneda);
                                                        Console.WriteLine("El valor de la cuota es: "+ valor_cuota_formato_moneda);
                                                        Console.WriteLine("Fecha de la compra: "+ fechaFormat);
                                                        Console.WriteLine("-------------------------------------------------------------");
                                                        Console.WriteLine("Pagos\n------");
                                    
                                                        //Se crea el Array para recorrer la cuotas
                                                        double[] arrayCuotas = new double[cantidadCuotas];

                                                        //Creo variable de fecha auxiliar
                                                        DateTime fecha_aux;
                                                        fecha_aux = fecha;

                                                        //For que cambia la cantidad de iteraciones segun las cuotas ingresadas
                                                        //Cargo el Array de cuotas con los valores de las cuotas y las fechas
                                                        //Se muestra la lista del plan de pagos
                                                        for(int i = 0; i<cantidadCuotas; i++){
                                                            arrayCuotas[i] = valor_cuota;
                                                            fecha_aux = fecha_aux.AddDays(30);
                                                            String fecha_auxFormat = fecha_aux.ToString("dd/MM/yyyy");
                                                            Console.WriteLine("Cuota Nro[{0}]\tFecha Pago[{1}]\tValor Cuota:[{2}]", i+1, fecha_auxFormat, arrayCuotas[i].ToString("C")); 
                                                        }
                                                        Console.WriteLine("-------------------------------------------------------------");
                                                        Console.WriteLine("Presione cualquier tecla para volver al menu principal");
                                                        Console.ReadKey();
                                                        break;
                                                    default:
                                                        Console.WriteLine("\n**********************************************");
                                                        esNum = false;
                                                        Console.ForegroundColor=ConsoleColor.Red;
                                                        Console.WriteLine("[ERROR]-Ingreso un numero fuera del rango pedido\n"+
                                                                          "Solo puede ingresar los numeros 6-12-18\n"+
                                                                          "Presione cualquier tecla y vuelva a intentarlo");
                                                        Console.ForegroundColor=ConsoleColor.White;
                                                        Console.WriteLine("**********************************************");
                                                        Console.ReadKey();
                                                        break;
                                                }
                                            }else{
                                                Console.WriteLine("\n**********************************************");
                                                Console.ForegroundColor=ConsoleColor.Red;
                                                Console.WriteLine("[ERROR]-Ingreso letras\n"+
                                                                  "Solo puede ingresar los numeros 6-12-18\n"+
                                                                  "Presione cualquier tecla y vuelva a intentarlo");
                                                Console.ForegroundColor=ConsoleColor.White;
                                                Console.WriteLine("**********************************************");
                                                Console.ReadKey();
                                            }
                                        }while(!esNum);
                                    }
                                }else{
                                    Console.WriteLine("\n**********************************************");
                                    Console.ForegroundColor=ConsoleColor.Red;
                                    Console.WriteLine("[ERROR]-Ingreso letras\n"+
                                                      "Debe ingresar un precio entre 20.000 y 100.000, solo numeros\n"+
                                                      "Presione cualquier tecla y vuelva a intentarlo");
                                    Console.ForegroundColor=ConsoleColor.White;
                                    Console.WriteLine("**********************************************");
                                    Console.ReadKey();
                                }
                            }while(!esFloat);
                            break;
                        case 4:
                            Console.WriteLine("\n**********************************************");
                            Console.WriteLine("Saliendo.......");
                            Console.WriteLine("**********************************************");
                            break;
                        default:
                            Console.WriteLine("\n**********************************************");
                            Console.ForegroundColor=ConsoleColor.Red;
                            Console.WriteLine("[ERROR]-Ingreso un numero fuera del rango pedido\n"+
                                            "Solo puede ingresar numeros del 1 al 4\n"+
                                            "Presione cualquier tecla y vuelva a intentarlo");
                            Console.ForegroundColor=ConsoleColor.White;
                            Console.WriteLine("**********************************************");
                            Console.ReadKey();
                            break;
                    }
                }else{
                    Console.WriteLine("\n**********************************************");
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("[ERROR]-No ingreso una opcion valida - Ingreso letras\n"+
                                      "solo puede ingresar numeros del 1 al 4\n"+
                                      "Presione cualquier tecla y vuelva a intentarlo");
                    Console.ForegroundColor=ConsoleColor.White;
                    Console.WriteLine("**********************************************");
                    Console.ReadKey();
                }
            }while(opcionMenu!=4);
        }
    }
}
