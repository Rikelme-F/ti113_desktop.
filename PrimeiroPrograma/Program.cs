namespace PrimeiroPrograma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe seu Nome: ");
            string nome = Console.ReadLine()!;
            Console.WriteLine("\n");
            Console.Write("\nInforme a Nota 1: ");
            //float nota1 = Convert.ToSingle(Console.ReadLine()!);            
            float nota1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("\n");
            Console.Write("\nInforme a Nota 2: ");
            float nota2 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("\n");
            Console.Write("\nInforme a Nota 3: ");
            float nota3 = float.Parse(Console.ReadLine()!);

            float soma = nota1 + nota2 + nota3;
            float media = soma / 3;

            Console.WriteLine($"A média de {nome} é {media}");
        }
    }
}
