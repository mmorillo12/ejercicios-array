using System;

namespace promedio_alturas
{
    class Alturas{
        float[] altura;
        float promedio;
        public void Obtener(){
            altura = new float[5];
            for(int i = 0;i < 5; i++){
                Console.WriteLine("Ingrese una altura: ");
                altura[i] = float.Parse(Console.ReadLine());
            }
        }
        public void Promedio(){
            float sum = 0;
            for(int i = 0; i < 5; i++){
                sum += altura[i];
            }
            promedio = sum / 5;
            Console.WriteLine("El promedio de todas las alturas es de {0}", promedio);
        }
        public void mayor_menor(){
            float mx = altura[0];
            float mn = altura[0];
            for(int i = 0; i < 5;i++){
                if(altura[i]>mx){
                    mx = altura[i];
                }
                if(altura[i]<mn){
                    mn = altura[i];
                }
            }
            Console.WriteLine("La persona mas alta tiene {0} y la persona mas pequeña tiene {1}", mx, mn);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        /*Crear un programa que defina un array de 5 elementos de tipo float que representen
        las alturas de 5 personas. Obtener el promedio de las mismas. Contar cuántas personas
        son más altas que el promedio y cuántas más bajas.*/
        Alturas a = new Alturas();
        a.Obtener();
        a.Promedio();
        a.mayor_menor();
        }
    }
}
