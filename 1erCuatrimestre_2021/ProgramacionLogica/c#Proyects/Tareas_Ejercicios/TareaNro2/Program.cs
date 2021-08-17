using System;

namespace TareaNro2
{
    class Program
    {
        const int DIAS_MES = 30;
        static void Main(string[] args)
        {
           /*
            Ingresar por pantalla uno de los puestos de trabajo abajo mencionados, luego ingresar los días trabajados (1 a 30) , 
            por ultimo mostrar por pantalla el sueldo base, los días trabajados y el monto a liquidar según los días trabajados.
    
            Ingeniero=$120.000
            Analista=$110.000
            Desarrollador=$100.000

            -El ingreso del puesto debe ser indistinto ya sea mayúscula/minúscula o cualquier  combinación.
            -Si se ingresa otro puesto debe mostrar un mensaje de error.
            -Validar el ingreso correcto de la cantidad de días.
            -Los días trabajados tienen que ser entre 1 y 30.

            Como tarea investigativa y opcional, se requiere mostrar los resultados como formato moneda.
           */
            string puestoTrabajo = "";
            int diasTrabajados = 0;
            float sueldo = 0;
            float liquidacionFinal = 0;
            char opcionMenu;
            bool esChar;
            bool esInt;

            Console.Clear();
            do{
                Console.WriteLine("***Menu de Ingreso***");
                Console.WriteLine("Ingrese un puesto de trabajo:\nI-Ingeniero\nA-Analista\nD-Desarrollador\nS-Salir");
                esChar = char.TryParse(Console.ReadLine(), out opcionMenu);
                opcionMenu = Char.ToLower(opcionMenu);
                if(esChar){
                    switch(opcionMenu){
                        case 'i':
                        case 'a':
                        case 'd':
                            do{
                                Console.WriteLine("Ingrese los dias trabajados[1-30] o 0 para Salir: ");
                                esInt = int.TryParse(Console.ReadLine(), out diasTrabajados);
                                if(esInt){
                                    if(diasTrabajados <= 0 || diasTrabajados > 30){
                                        if(diasTrabajados==0){
                                            Console.WriteLine("Gracias!\n");    
                                        }else{
                                            Console.WriteLine("-ERROR-Ingrese los dias del 1 al 30\n");        
                                        }
                                    }else{
                                        if(opcionMenu.Equals('i')){
                                            puestoTrabajo="Ingeniero";
                                            sueldo=120000;
                                            liquidacionFinal= (sueldo/DIAS_MES)*diasTrabajados;
                                        }
                                        if(opcionMenu.Equals('a')){
                                            puestoTrabajo="Analista";
                                            sueldo=110000;
                                            liquidacionFinal= (sueldo/DIAS_MES)*diasTrabajados;
                                        }
                                        if(opcionMenu.Equals('d')){
                                            puestoTrabajo="Desarrollador";
                                            sueldo=100000;
                                            liquidacionFinal= (sueldo/DIAS_MES)*diasTrabajados;
                                        }
                                        string sueldo_formatoMoneda = sueldo.ToString("C");
                                        string liquidacionFinal_formatoMoneda = liquidacionFinal.ToString("C");
                                        Console.Clear();
                                        Console.WriteLine("**************************");
                                        Console.WriteLine("Puesto de trabajo: "+puestoTrabajo+
                                                          "\nSueldo base: "+sueldo_formatoMoneda+
                                                          "\nDias trabajados: "+diasTrabajados+
                                                          "\nLiquidacion Final: "+liquidacionFinal_formatoMoneda);
                                        Console.WriteLine("**************************");
                                        Console.WriteLine("Presione una tecla para continuar");
                                        Console.ReadKey();
                                        Console.Write("\n");
                                    }
                                }else{
                                    Console.WriteLine("-ERROR-No ingreso dias\n");
                                }
                            }while((diasTrabajados < 0 || diasTrabajados > 30) || !esInt);
                            break;
                        case 's':
                            Console.WriteLine("Gracias por usar el programa\nPresione una tecla para salir.");
                            break;
                        default:
                            Console.WriteLine("-ERROR-Usted no ha ingresado una opcion del Menu\nPresione cualquier tecla para continuar");
                            Console.ReadKey();
                            Console.WriteLine("");
                            break;
                    }
                }else{
                    Console.WriteLine("-ERROR-Usted no ha ingresado una opcion del Menu\nPresione cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.WriteLine("");
                }
            }while(opcionMenu!='s');
            Console.ReadKey();
            Console.WriteLine("");
        }
    }
}
