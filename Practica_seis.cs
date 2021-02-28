using System;

namespace ficheros_imagenes
{
    class Program
    {
        class Imagenes{
            string[] nombre = new string[700];
            int[] ancho = new int[700];
            int[] altura = new int[700];
            float[] tamaño = new float[700];
            int numerodelista;

            public void Añadir(){
                int valor = 0;
                do{
                    Console.WriteLine("Ingrese el nombre del fichero: ");
                    nombre[numerodelista] = Console.ReadLine();
                    Console.WriteLine("Ingrese el ancho de los pixeles: ");
                    ancho[numerodelista] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura de la imagen: ");
                    altura[numerodelista] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba el tamaño de la imagen, (ejemplo en Kb):  ");
                    tamaño[numerodelista] = float.Parse(Console.ReadLine());
                    Console.WriteLine("Desea Salir? (Ingrese -1), sino ingrese 2");
                    valor = int.Parse(Console.ReadLine());
                    numerodelista++;
                    if(numerodelista == 700){
                        Console.WriteLine("Maximo de imagnes (!700!)");
                    }
                    if(valor == -1){
                        break;
                    }else{
                        continue;
                    }
                }while((numerodelista <= 700)&&(valor != -1));
            }
            
            public void Ver(){
                for(int i = 0; i < numerodelista;i++){
                Console.WriteLine("El fichero numero {0} se llama {1}", i, nombre[i]);
                Console.WriteLine("El fichero numero {0} tiene un ancho de {1}", i, ancho[i]);
                Console.WriteLine("El fichero numero {0} tiene una altura de {1}", i, altura[i]);
                Console.WriteLine("El fichero numero {0} tiene un tamaño de {1}", i, tamaño[i]);
                
                }
            }
            public void Buscar(){
                string fnom;
                Console.WriteLine("Ingrese el nombre del fichero que esta buscando: ");
                fnom = Console.ReadLine();
                for(int i = 0; i < numerodelista; i++){
                    if(nombre[i] == fnom){
                        Console.WriteLine("El fichero se llama {0}",nombre[i]);
                        Console.WriteLine("El fichero tiene un ancho de {0}",ancho[i]);
                        Console.WriteLine("El fichero tiene una altura de {0}",altura[i]);
                        Console.WriteLine("El fichero tiene un tamaño de {0}",tamaño[i]);
                    }
                }
            }
            public void Salir(){
                Console.Clear();
                Console.Write("Fin del Programa");
            }
        }
        static void Main(string[] args)
        {
        /*Un programa que permita guardar datos de "imágenes" (ficheros de ordenador que
        contengan fotografías o cualquier otro tipo de información gráfica). De cada imagen
        se debe guardar: nombre (texto), ancho en píxeles (por ejemplo 2000), alto en píxeles
        (por ejemplo, 3000), tamaño en Kb (por ejemplo 145,6). El programa debe ser capaz de
        almacenar hasta 700 imágenes (deberá avisar cuando su capacidad esté llena).
        Debe permitir las opciones: añadir una ficha nueva, ver todas las fichas (número
        y nombre de cada imagen), buscar la ficha que tenga un cierto nombre.*/
           Imagenes i = new Imagenes();  
           int va = 0;
           while(va != 4){
            Console.WriteLine("    -Menu Principal-    ");
            Console.WriteLine("Opcion 1: Añadir una ficha nueva");
            Console.WriteLine("Opcion 2: ver todas las fichas (número y nombre de cada imagen)");
            Console.WriteLine("Opcion 3: buscar la ficha que tenga un cierto nombre.");
            Console.WriteLine("Opcion 4: Salir del programa ");

            va = int.Parse(Console.ReadLine());
            Console.Clear();
            switch(va){
                case 1:
                i.Añadir();
                break;
                case 2:
                i.Ver();
                break;
                case 3:
                i.Buscar();
                break;
                case 4:
                i.Salir();
                break;
            }
           }
        }
    }
}

