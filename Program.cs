using System;

namespace separar_letras
{
  class Program
  {
    static void Main(string[] args)
    {
      /*Un programa que te pida tu nombre y lo muestre en pantalla separando cada letra de la
      siguiente con un espacio. Por ejemplo, si tu nombre es "Juan", debería aparecer en pantalla "J u a n".*/
      string[] nombre = new string[1];
      for(int i = 0; i < nombre.Length; i++){
         nombre[i] = Console.ReadLine();
      }
      char[] lsn = nombre[0].ToCharArray();
      for(int i = 0; i < lsn.Length; i++){
        Console.WriteLine(lsn[i]);
      }
    }
  }
}
