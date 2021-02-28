using System;

namespace edad
{
    class Edades{
        string nombre;
        int edad;

        public void Conseguir(string nom, int ed){
            nombre = nom;
            edad = ed;
            Console.WriteLine("\nEl nombre de la persona es: {0}",nom);
            Console.WriteLine("\n{0} tiene {1} años", nom, ed);
        }
        public void Comparar(){
            if(edad >= 18){
                Console.WriteLine("\n{0} es mayor de edad", nombre);
            }
            else{
                Console.WriteLine("\n{0} es menor de edad",nombre);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        /*Confeccionar una clase que permita carga el nombre y la edad de una persona.
        Mostrar los datos cargados. Imprimir un mensaje si es mayor de edad (edad>=18).*/
        Edades e = new Edades();
        Console.WriteLine("Ingrese el nombre");
        string nom = Console.ReadLine();
        Console.WriteLine("\nIngrese la edad");
        int ed = int.Parse(Console.ReadLine());
        e.Conseguir(nom, ed);
        e.Comparar();
        }
    }
}
