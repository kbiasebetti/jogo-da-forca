namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        // Versão 01: Estrutura básica e entrada do usuário
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("-----------------");
                Console.WriteLine("| Jogo da Forca |");
                Console.WriteLine("-----------------");

                Console.Write("Digite uma letra: ");
                char chute = Console.ReadLine()[0];

                Console.WriteLine($"Você digitou: {chute}");
                Console.ReadLine();
            } while (true);

            Console.ReadLine();
        }
    }
}
