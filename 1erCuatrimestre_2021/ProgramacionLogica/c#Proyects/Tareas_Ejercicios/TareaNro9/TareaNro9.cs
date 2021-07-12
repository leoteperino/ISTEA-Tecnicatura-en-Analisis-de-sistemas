using System;

namespace TareaNro9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Se requiere crear una aplicación consola que implemente 4 arrays unidimencionales (Nombre, apellido, edad y genero) 
            y se carguen por pantalla como mínimo 2 líneas de datos, luego que se muestre por pantalla con el formato correcto.
            */

            string[] nombre=new string[3];
            string[] apellido=new string[3];
            int[] edad=new int[3];
            char[] genero=new char[3];

            cargarArrayNombres(nombre);
            cargarArrayApellido(apellido);
            cargarArrayEdad(edad);
            cargarArrayGenero(genero);
            mostrarArray(nombre,apellido,edad,genero);
        }

        static void cargarArrayNombres(string[] array){
            string nombre;
            for(int i = 0; i<array.Length; i++){
                Console.Write("Ingrese el nombre {0}:",i+1);
                nombre = Console.ReadLine();
                array[i] = nombre;     
            }
        }

        static void cargarArrayApellido(string[] array){
            string apellido;
            for(int i = 0; i<array.Length; i++){
                Console.Write("Ingrese el apellido {0}:",i+1);
                apellido = Console.ReadLine();
                array[i] = apellido;     
            }
        }

        static void cargarArrayEdad(int[] array){
            int edad;
            for(int i = 0; i<array.Length; i++){
                Console.Write("Ingrese la edad {0}:",i+1);
                edad = int.Parse(Console.ReadLine());
                array[i] = edad;     
            }
        }

        static void cargarArrayGenero(char[] array){
            char genero;
            for(int i = 0; i<array.Length; i++){
                Console.Write("Ingrese sexo {0}:",i+1);
                genero = char.Parse(Console.ReadLine());
                array[i] = genero;     
            }
        }

        static void mostrarArray(string[] nombre, string[] apelido, int[] edad, char[] sexo){
            for(int i=0;i<nombre.Length;i++){
                Console.WriteLine("{0}-Nombre: {1}--Apellido: {2}--Edad: {3}--Sexo: {4}",
                                  i+1, 
                                  nombre[i],
                                  apelido[i],
                                  edad[i],
                                  sexo[i]);
            }
        }
    }
}
