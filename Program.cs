using System;

namespace SequenciaPares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite qualquer número inteiro: ");
            int numero=Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            
            int contador=0;
            while (contador<=numero)
            {
              Console.Write($"{contador} ");
               contador=contador+2; 
            }
               Console.WriteLine("Programa finalizado!!!");
            
            
        }
    }
}
