using System;

namespace ParImpar_DecisaoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Par ou Impar ---\n");

            int numero;
            bool numeroDigitado;

            Console.Write("Digite um numero: ");
            numeroDigitado = Int32.TryParse((Console.ReadLine()), out numero);

            if (numero % 2 == 0)
            {
                Console.WriteLine("O numero digitado é par.");
            }
            else
            {
                Console.WriteLine("O numero digitado é ímpar.");
            }


        }
    }
}
