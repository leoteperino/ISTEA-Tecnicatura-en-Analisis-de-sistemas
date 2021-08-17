using System;

namespace proyect14
{
    class Program
    {
        static void Main(string[] args)
        {
            var C4=new Auto();
            var F100=new Camioneta();
            F100.carga=100;            
            F100.Color="Roja";
            C4.Modelo="Citroen";            
            C4.id=12;
            C4.Precio=750000;
            C4.Color="Rojo";
            C4.cant_pasajeros=5;
            Console.WriteLine("Modelo: "+C4.Modelo+" Id:"+C4.id);
            Console.WriteLine(C4.imprimir());
        }
    }


public class Vehiculo
{
    public string Modelo{get;set;}
    public int id{get;set;}
    public double Precio{get;set;}
    public string Color{get;set;}

    public string imprimir()
    {
        return "Metodo de la clase Vehiculo";
    }

}


public class Auto:Vehiculo
{
public int cant_pasajeros{get;set;}
}


public class Camioneta:Vehiculo
{
public int carga{get;set;}
}








}
