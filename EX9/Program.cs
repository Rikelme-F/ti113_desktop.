namespace EX9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usuario;
            string senha;

            while (true)
            {

                Console.WriteLine("Digite seu nome de usuário: ");
                usuario = Console.ReadLine()!;
                Console.WriteLine("Digite sua senha: ");
                senha = Console.ReadLine()!;

                if (senha == usuario)
                {
                    Console.WriteLine("Erro: A senha não pode ser igual ao nome do usuário. Por favor, tente novamente.\n");
                }
                else
                {
                    Console.WriteLine("Usuário e senha cadastrados com sucesso!");
                    break;
                }
            }
        }
    }
}

//Faça um algoritmo que leia um nome de usuário e a sua senha. A senha não pode ser 
//igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as 
////informações. 