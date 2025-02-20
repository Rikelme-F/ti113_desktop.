namespace EX10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Digite um número inteiro para gerar a tabuada: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Tabuada de {numero}:");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{numero} x {i} = {numero * i}");
                }

                Console.Write("Deseja gerar outra tabuada? (s/n): ");
                string resposta = Console.ReadLine()!.ToLower();

                if (resposta != "s") break;

            }

            Console.WriteLine("Gerador de tabuada encerrado. Obrigado!");
        }
    }
}
