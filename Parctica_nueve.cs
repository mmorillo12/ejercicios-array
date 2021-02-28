using System;

namespace tablas
{
    class Tablas{
        int valor;
    
    public void Mostar(){
        do{
        Console.WriteLine("Ingrese un valor");
        valor = int.Parse(Console.ReadLine());
        if(valor == -1){
            break;
        }
        for(int j = 0; j <= 10; j++){
        Console.WriteLine("{0} * {1} = {2}", valor,j,(valor*j));
        }
        }while(valor != -1);
        
    }
}
    class Program
    {
    
        static void Main(string[] args)
        {
            /*Crear una clase que permita ingresar valores enteros por teclado y nos muestre
            la tabla de multiplicar de dicho valor. Finalizar el programa al ingresar el -1.*/
            Tablas t = new Tablas();
            t.Mostar();
        }
    }
}
