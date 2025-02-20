namespace EX5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array de Numeros
            int[] numeros = new int[3];

            Console.Write("Digite o 1º Numero: ");
            numeros[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Digite o 2º Número: ");
            numeros[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Digite o 3º Número: ");
            numeros[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            int maior = numeros.Max();
            Console.WriteLine($"O maior número é {maior}");
            int menor = numeros.Min();
            Console.WriteLine($"O menor número é {menor}");
        }
    }
}
