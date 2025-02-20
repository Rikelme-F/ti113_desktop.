
namespace EX8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha uma operação: (1) Adição (2) Subtração (3) Multiplicação (4) Divisão (5) Sair");
                int opcao = Convert.ToInt32(Console.ReadLine());
                if (opcao == 5) break;

                Console.Write("Digite o primeiro número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"Resultado da Adição: {num1 + num2}\n");
                        break;
                    case 2:
                        Console.WriteLine($"Resultado da Subtração: {num1 - num2}\n");
                        break;
                    case 3:
                        Console.WriteLine($"Resultado da Multiplicação: {num1 * num2}\n");
                        break;
                    case 4:
                        Console.WriteLine(num2 == 0 ? "Erro: Divisão por zero não é permitida.\n" : $"Resultado da Divisão: {num1 / num2}\n");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.\n");
                        break;
                }
            }

            Console.WriteLine("Calculadora encerrada. Obrigado!");
        }
    }
}

//Faça um algoritmo para montar uma calculadora simples, onde o 
//usuário vai optar em escolher conforme o menu adiante. 
//Observação: no caso de divisão, o denominador não pode ser zero,
//invalidando a operação.