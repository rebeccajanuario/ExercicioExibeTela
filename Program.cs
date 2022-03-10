// See https://aka.ms/new-console-template for more information
using System;

namespace teste
{ 
    class Program
    {
        static void Main(string[]args)
        {
            string texto;
            Console.WriteLine("Digite um texto:");
            texto = Console.ReadLine();

            if(string.IsNullOrEmpty(texto))
            {
                Console.WriteLine("Sem texto");
            }
            else
            {
                Console.WriteLine(texto);

            }
        }
    }
    
}


