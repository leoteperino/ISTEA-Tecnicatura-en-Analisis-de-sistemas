﻿using System;

namespace proyect17
{
    class Program
    {
        static void Main(string[] args)
        {
          // Console.Clear();
          // for(int x=0;x<20;x++)
          // {
          //   Console.WriteLine("El valor de la X es :"+x);     
          // }  

          // Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/"); 

          // for(int x=0;x<20;x=x+5)
          // {
          //   Console.WriteLine("El valor de la X es :"+x);                     
          // } 

          // Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/");

          // int y;
          // for(int i=0;i<10;i++)
          // {
          //     y=10;
          //     y=y+i;
          //     Console.WriteLine("Valor i:"+i);
          //     Console.WriteLine("Valor x:"+y);
          // }

          // Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/");

          // for(int i=10;i>0;i--)
          // {
          //     Console.WriteLine("Valor de i es: "+i);
          // }

          // Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/");

          // Console.Clear();
          // int e;
          // Random nrd=new Random();           
          // for(int i=0;i<250;i++)
          // {
          //    e=nrd.Next(900,1000);
          //    Console.WriteLine("EL valor de la i="+i);
          //    Console.WriteLine("EL valor Aleatorio es="+e);
          // }

          // Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/");

          string oracion1="Nicolas Manuel Fernandez";
          int cant=oracion1.Length;
          int cant_real=0;
          for(int i=0;i<oracion1.Length;i++)
          {
              if(oracion1[i]==' ')
              {
                  cant_real++;                    
              }                    
          }
          Console.WriteLine("Cant. Letras: "+cant);
          Console.WriteLine("Cant. Letras sin espacios: "+(cant-cant_real));

          // Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/");

          // int y=0;
          // do
          // {
          //   Console.WriteLine("Valor de y="+y);
          //   y++;
          // }while(y<=5);

          // Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/");
            
          // int y=0;
          // string oracion2="Nicolas";
          // int cant=oracion2.Length;
          // do
          // {
          //   Console.WriteLine("Letra= "+oracion2[y]);
          //   y++;    
          // }while(y<cant);

          // Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/");

          // string usuario;
          // int pass;
          // do
          // {
          //   Console.Clear();
          //   Console.WriteLine("Usuario:");
          //   usuario=Console.ReadLine();
          //   Console.WriteLine("Password:");
          //   pass=Int32.Parse(Console.ReadLine());
          //   if(usuario=="admin" && pass==123456)
          //   {
          //       Console.WriteLine("Acceso Permitido");                        
          //   }
          //   else
          //   {
          //       Console.WriteLine("Acceso No Permitido"); 
          //   }
          // }while(usuario!="admin" || pass!=123456);

          //Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/");

          // int n=0;
          // while(n<5)
          // {
          //   Console.WriteLine("Valor:"+n);       
          //   n++; 
          // }

          //Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/");

          // int [] valores2= new int[50];
          // for(int x=0;x<50;x++)
          // {
          //   valores2[x]=x;  
          //   Console.WriteLine("Valor  del Array es:"+valores2[x]);
          //   Console.WriteLine("Indice del Array es:"+x);
          // }

          //Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/");

          // string[] paises={"Argentina","Brasil","Peru"};
          // string[] paises2=paises.Clone() as string[];
          // for(int x=0;x<3;x++)
          // {
          //   Console.WriteLine("Pais: "+paises2[x]);
          // }
          // Console.WriteLine(string.Join(" | ",paises2));

          // Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/");

          // int[] array_enteros={1,23,45,66,23,11};
          // int[] array_enteros2={99,99,99,99,99,99};
          // Array.Copy(array_enteros,0,array_enteros2,0,4);
          // Console.WriteLine(string.Join(" - ",array_enteros2));
          // Console.WriteLine("Cantidad:"+array_enteros.Length);

          // Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/");

        //   int a=20;
        //   switch(a)
        //   {
        //       case 17:
        //       Console.WriteLine("EL valor 17");
        //       break;
        //       case 19:
        //       {
        //       Console.WriteLine("EL valor 19");
        //       break;
        //       }
        //       case 20:
        //       Console.WriteLine("EL valor 20");
        //       break;
        //   }
        //   Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/");
      }
    }
}
