
namespace EX12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[20];
            List<int> pares = new List<int>();
            List<int> impares = new List<int>();

            // Leitura dos números inteiros e armazenamento no vetor principal
            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Digite o {i + 1}º número inteiro: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                if (numeros[i] % 2 == 0)
                {
                    pares.Add(numeros[i]);
                }
                else
                {
                    impares.Add(numeros[i]);
                }
            }

            // Exibe os três vetores
            Console.WriteLine("\nVetor de Todos os Números:");
            Console.WriteLine(string.Join(", ", numeros));

            Console.WriteLine("\nVetor de Números Pares:");
            Console.WriteLine(string.Join(", ", pares));

            Console.WriteLine("\nVetor de Números Ímpares:");
            Console.WriteLine(string.Join(", ", impares));
        }
    }
}
