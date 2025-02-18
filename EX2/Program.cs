
namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mensagem = "";
            double dia = 0;

            Console.WriteLine("Informe um número de 1 a 7:");
            dia = Convert.ToDouble(Console.ReadLine());

            if (dia == 1)
            {
                mensagem = "Domingo";
            }
            else if (dia == 2)
            {
                mensagem = "Segunda-feira";
            }
            else if (dia == 3)
            {
                mensagem = "Terça-feira";
            }
            else if (dia == 4)
            {
                mensagem = "Quarta-feira";
            }
            else if (dia == 5)
            {
                mensagem = "Quinta-feira";
            }
            else if (dia == 6)
            {
                mensagem = "Sexta-feira";
            }
            else if (dia == 7)
            {
                mensagem = "Sábado";
            }
            else
            {
                mensagem = "Número inválido. Por favor, insira um número de 1 a 7.";
            }

            Console.WriteLine(mensagem);
        }
    }
}
