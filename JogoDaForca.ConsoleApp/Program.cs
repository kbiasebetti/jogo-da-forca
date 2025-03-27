namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        // Versão 05: Escolher uma palavra aleatória
        static void Main(string[] args)
        {
            string[] paises = [
                "BRASIL",
                "ARGENTINA",
                "CHILE",
                "COLOMBIA",
                "MEXICO",
                "ESPANHA",
                "PORTUGAL",
                "FRANCA",
                "ITALIA",
                "ALEMANHA",
                "RUSSIA",
                "CHINA",
                "JAPAO",
                "COREIA",
                "INDIA",
                "AUSTRALIA",
                "CANADA",
                "INGLATERRA",
                "IRLANDA",
                "EGITO",
                "MARROCOS",
                "NIGERIA",
                "ANGOLA",
                "TURQUIA",
                "GRECIA",
                "SUECIA",
                "NORUEGA",
                "FINLANDIA"
            ];

            while (true)
            {
                Random geradorDePalavras = new Random();
                int indicePalavraEscolhida = geradorDePalavras.Next(paises.Length);

                string palavraEscolhida = paises[indicePalavraEscolhida];

                char[] letrasEncontradas = new char[palavraEscolhida.Length];

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

                    if (quantidadeErros == 0)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                 ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }

                    else if (quantidadeErros == 1)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                 ");
                        Console.WriteLine(" |         O        ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }
                    else if (quantidadeErros == 2)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                 ");
                        Console.WriteLine(" |         O        ");
                        Console.WriteLine(" |         x        ");
                        Console.WriteLine(" |         x        ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }
                    else if (quantidadeErros == 3)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                 ");
                        Console.WriteLine(" |         O        ");
                        Console.WriteLine(" |        /x\\      ");
                        Console.WriteLine(" |         x        ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }
                    else if (quantidadeErros == 4)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                 ");
                        Console.WriteLine(" |         O        ");
                        Console.WriteLine(" |        /x\\      ");
                        Console.WriteLine(" |         x        ");
                        Console.WriteLine(" |        / \\      ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }
                    else if (quantidadeErros == 5)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                 ");
                        Console.WriteLine(" |         O        ");
                        Console.WriteLine(" |        /x\\      ");
                        Console.WriteLine(" |         x        ");
                        Console.WriteLine(" |        / \\      ");
                        Console.WriteLine(" |        ---       ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }

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

                    if (jogadorAcertou)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine($"Parabéns, você acertou a palavra secreta!");
                        Console.WriteLine($"A palavra era {palavraEscolhida}");
                    }
                    else if (jogadorEnforcou)
                    {
                        Console.Clear();
                        Console.WriteLine("--------------------");
                        Console.WriteLine("| Jogo da Forca |");
                        Console.WriteLine("|     Países    |");
                        Console.WriteLine("--------------------");
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/        |        ");
                        Console.WriteLine(" |         O        ");
                        Console.WriteLine(" |        /x\\      ");
                        Console.WriteLine(" |         x        ");
                        Console.WriteLine(" |        / \\      ");
                        Console.WriteLine(" |        ---       ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                        Console.WriteLine("\n");
                        Console.WriteLine("Que pena, você perdeu!");
                        Console.WriteLine($"A palavra era {palavraEscolhida}");
                    }
                } while (jogadorEnforcou == false && jogadorAcertou == false);

                Console.ReadLine();
            }
        }
    }
}
