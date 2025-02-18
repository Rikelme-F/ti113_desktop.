using System;

namespace EX3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1 = 0;
            double numero2 = 0;

            Console.WriteLine("Informe o numero1:");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o numero2:");
            numero2 = Convert.ToDouble(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine($"O maior número é: {numero1}");
            }
            else if (numero1 < numero2)
            {
                Console.WriteLine($"O maior número é: {numero2}");
            }
            else
            {
                Console.WriteLine("Os números são iguais.");
            }
        }
    }
}

//Faça um algoritmo que peça dois números e imprima o maior deles
