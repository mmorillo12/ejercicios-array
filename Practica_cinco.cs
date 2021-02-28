using System;

namespace nombre_100
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un programa que prepare espacio para un máximo de 100 nombres. El usuario deberá 
            ir introduciendo un nombre cada vez, hasta que se pulse Intro sin teclear nada,
            momento en el que dejarán de pedirse más nombres y se mostrará en pantalla la 
            lista de los nombres que se han introducido.*/
            int i = 0, nuevo = 0;
            string[] lsnom = new string[99];
            Console.WriteLine("Ingrese un nombre");
            
            //Ciclo para conseguir los nombres
            for(i = 0; i < 100; i++){
                lsnom[i] = Console.ReadLine();
                
                //Si un nombre es igual a "" o nada pues ahi sale del ciclo
                if(lsnom[i]== ""){

                    /*A la variable "nuevo" le pongo los valores de "i" para asi en el siguiente ciclo imprimir
                    la misma cantidad de nombres*/
                    nuevo = i;
                    break;
                }
            }
            //Se imprimen los nombres
            for(i = 0; i < nuevo; i++){
                Console.WriteLine(lsnom[i]);
            }
        }
    }
}
