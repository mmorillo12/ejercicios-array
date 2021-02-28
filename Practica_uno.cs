using System;

namespace media_aritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un programa que pida al usuario 4 números, los memorice (utilizando un array),
            calcule su media aritmética y después muestre en pantalla la media y los datos
            tecleados.*/
            int suma, media = 0;
            int[] numeros = new int[4];
            Console.WriteLine("Ingresas sus cuatro numeros: ");
            
            //Se toman los valores
            for(int i = 0; i <= 3; i++){
                numeros[i] = int.Parse(Console.ReadLine());
            }
            //Limpiamos la terminal para que se vea mas ordenado y limpio el output
            Console.Clear();
            
            //Ya que tenemos los valores, usamos estos para sumarlos entre si con un ciclo.
            suma  = 0;
            for(int i = 0; i < 4; i++){
                suma += numeros[i];
                media = suma / 4;
            }
            
            Console.WriteLine("El resultado de la media aritmetica de: {0}, {1}, {2}, {3}", numeros[0], numeros[1], numeros[2], numeros[3]);
            Console.WriteLine("Es igual a: {0}", media);
        }
    }
}
