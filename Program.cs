using System;

namespace orden_contrario
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Un programa que pida al usuario 5 números reales (pista: necesitarás un array de
           "float") y luego los muestre en el orden contrario al que se introdujeron.*/
           float[] numeros = new float [5];
           Console.WriteLine("Ingrese sus cinco numeros: ");
           
           //Aqui conseguimos los valores que desea el usuario
           for(int i = 0; i <= 4; i++){
               numeros[i] = float.Parse(Console.ReadLine());
           }
           //Limpio pantalla para que se vea mas ordenado el terminal
           Console.Clear();
           
           //Este es un metodo que pone al contrario las valores de tu lista segun los ingresaste
           Array.Reverse(numeros);
           Console.WriteLine("Sus valores ingresados de forma contraria serian: ");
           
           //Aqui evaluamos cada elemento de la lista que ya estan al contrario y los imprimimos
           foreach(var i in numeros){
               Console.WriteLine(i);
           }
        }
    }
}
