using System;

namespace pract_clase03
{
    class Program
    {
        static void Main(string[] args)
        {
            char Oper;
            bool EsDobleValor1;
            bool EsDobleValor2;
            double Valor1=0;
            double Valor2=0;

        do{    
            Console.Clear();
            Console.WriteLine("Calculadora");
            Console.WriteLine(" ");
            do{            
               Console.Write("Ingrese primer valor: ");
               EsDobleValor1 = Double.TryParse(Console.ReadLine(), out Valor1);
               Console.Write("Ingrese segundo valor: ");
               EsDobleValor2 = Double.TryParse(Console.ReadLine(), out Valor2);            
            }while(!EsDobleValor1 || !EsDobleValor2);
            

            Console.Write("Ingrese (S)-Suma, (R)-Resta, (D)-División, (M)-Multiplicación,(E)-Salir: ");
            Oper = Convert.ToChar(Console.ReadLine());
            Oper = Char.ToUpper(Oper);

        
            switch(Oper)
            {
                case 'S' :                 
                {
                    Console.WriteLine("El resultado de la suma es:"+(Valor1+Valor2) );
                    Console.ReadKey();
                    break;
                }
                case 'R':                
                {
                    Console.WriteLine("El resultado de la resta es:"+(Valor1-Valor2) );
                    Console.ReadKey();
                    break;
                }
                case 'D':                
                {
                    Console.WriteLine("El resultado de la suma es:"+(Valor1/Valor2) );
                    Console.ReadKey();
                    break;
                }
                case 'M':                
                {
                    Console.WriteLine("El resultado de la suma es:"+(Valor1*Valor2) );
                    Console.ReadKey();
                    break;
                }
                case 'E':
                {
                    Console.WriteLine("Programa terminado");
                    Console.ReadKey();
                    break;
                }
                
                default:
                {
                   Console.WriteLine("Opcion Incorrecta");
                   Console.ReadKey();
                   break; 
                }
          
            }
            }while(Oper!='E');
        }
    }
}
