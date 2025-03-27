namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        // Versão 02: Exibir palavra oculta com traços
        static void Main(string[] args)
        {
            string palavraEscolhida = "GREMIO";

            char[] letrasEncontradas = new char[palavraEscolhida.Length];

            for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
                letrasEncontradas[caractere] = '_';

            do
            {
                Console.Clear();
                Console.WriteLine("--------------------------");
                Console.WriteLine("| Jogo da Forca |");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Palavra escolhida: " + String.Join(" ", letrasEncontradas));

                Console.Write("Digite uma letra: ");
                char chute = Console.ReadLine()[0];

                Console.WriteLine($"Você digitou: {chute}");
                Console.ReadLine();
            } while (true);

            Console.ReadLine();
        }
    }
}
