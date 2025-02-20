
namespace EX11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double INSS_DESCONTO = 0.12;
            double[] salariosBrutos = new double[5];
            double[] salariosLiquidos = new double[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite o salário bruto da {i + 1}ª pessoa: ");
                salariosBrutos[i] = Convert.ToDouble(Console.ReadLine());
                salariosLiquidos[i] = salariosBrutos[i] * (1 - INSS_DESCONTO);
            }

            Console.WriteLine("\nSalários Líquidos:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Pessoa {i + 1}: R$ {salariosLiquidos[i]:F2}");
            }
        }
    }
}
