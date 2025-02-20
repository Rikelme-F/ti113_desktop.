namespace EX6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que pergunte o nome do usuário, 
            //o quanto ganha por hora e o número de horas trabalhadas no mês.
            //Calcule o resultado e mostre o nome e o total da renda recebida no mês.

            string nome;
            double valorHora;
            short quantHora;

            Console.Write("Digite o seu Nome: ");
            nome = Console.ReadLine()!;
            Console.Write("Digite o numero de horas trabalhadas: ");
            quantHora = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite o valor por hora: ");
            valorHora = Convert.ToDouble(Console.ReadLine());

            double total = valorHora * quantHora;

            Console.WriteLine($@"
                O Valor Total de {nome} é R$ {total:f2}
            ");



        }
    }
}
