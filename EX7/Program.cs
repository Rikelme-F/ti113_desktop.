
namespace EX7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays para armazenar nomes e preços dos produtos
            string[] nomes = new string[6];
            double[] precos = new double[6];

            // Leitura dos nomes e preços dos produtos
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Digite o nome do {i + 1}º Produto: ");
                nomes[i] = Console.ReadLine();
                Console.Write($"Digite o preço do {i + 1}º Produto: ");
                precos[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n");
            }

            // Encontra o índice do menor preço
            int indiceMenorPreco = Array.IndexOf(precos, precos.Min());

            // Exibe o nome e o valor do produto mais barato
            Console.WriteLine($"O produto mais barato é {nomes[indiceMenorPreco]} com preço de {precos[indiceMenorPreco]:C}");
        }
    }
}

//Faça um algoritmo que o usuário escreva o nome e o preço de seis 
//produtos e assim que terminar de escrever o ultimo produto, mostre o 
//nome e o valor do produto mais barato.