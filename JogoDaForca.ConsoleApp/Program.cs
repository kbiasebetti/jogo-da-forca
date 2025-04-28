namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                

                

                for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
                    letrasEncontradas[caractere] = '_';

                int quantidadeErros = 0;
                bool jogadorEnforcou = false;
                bool jogadorAcertou = false;

                do
                {
                    Console.Clear();
                    Console.WriteLine("--------------------");
                    Console.WriteLine("| Jogo da Forca |");
                    Console.WriteLine("|     Países    |");
                    Console.WriteLine("--------------------");

                    

                    Console.WriteLine("\n");
                    Console.WriteLine("Erros do jogador: " + quantidadeErros);
                    Console.WriteLine("Palavra escolhida: " + String.Join(" ", letrasEncontradas));
                    Console.WriteLine("--------------------------");

                    Console.Write("Digite uma letra: ");
                    char chute = Console.ReadLine()[0];

                    bool letraFoiEncontrada = false;

                    for (int contador = 0; contador < palavraEscolhida.Length; contador++)
                    {
                        char letraAtual = palavraEscolhida[contador];

                        if (chute == letraAtual)
                        {
                            letrasEncontradas[contador] = letraAtual;
                            letraFoiEncontrada = true;
                        }
                    }

                    if (letraFoiEncontrada == false)
                        quantidadeErros++;

                    string palavraEncontrada = String.Join("", letrasEncontradas);

                    jogadorAcertou = palavraEncontrada == palavraEscolhida;
                    jogadorEnforcou = quantidadeErros > 5;

                Console.ReadLine();
            }
        }
    }
}
