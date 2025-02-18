using System.Security.Cryptography;

namespace EX3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string mensagem = "";
            double numero1 = 0;
            double numero2 = 0;

            Console.WriteLine("Informe o numero1:");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o numero2:");
            numero2 = Convert.ToDouble(Console.ReadLine());

            if (numero1 > numero2) {
                mensagem = "O numero1 é maior que o numero2";
        }
    }
}
//Faça um algoritmo que preça dois números e imprima o maior deles
