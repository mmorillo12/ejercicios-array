using System;

namespace mayor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un programa que pida al usuario 10 números y luego calcule y muestre cuál es
            el mayor de todos ellos.*/
            int[] numeros = new int[10];
            int mayor = numeros[0];

            Console.WriteLine("Profavor Ingrese 10 valores para determinar el mayor");
            for(int i = 0; i<= 9; i++){
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            for(int i = 0; i<=9; i++){
                if(numeros[i] > mayor)
                    mayor = numeros[i];
                
            }
            Console.WriteLine("El mayor numero es: " + mayor);

        }
    }
}
