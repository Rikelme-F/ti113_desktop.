namespace StatusAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1 = 0;
            double nota2 = 0;
            string mensagem = "";
            double media = 0;

            Console.Write("Informe a 1 nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Infome a 2 nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");
            media = (nota1 + nota2) / 2;

            if (media >= 7)
            {
                mensagem = "Aprovado";
            }
            else if (media >= 5 && media < 7)
            {
                mensagem = "Recuperação";
            }
            else
            {
                mensagem = "Reprovado";
            }
            Console.WriteLine($"O Status do Aluno de Média: {media} é {mensagem}");

        }
    }
}

