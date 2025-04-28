namespace JogoDaForca.ConsoleApp
{
	public class JogoDaForca
	{
		private PalavraSecreta palavraSecreta = new PalavraSecreta();
		private string palavraAtual;
		private string letrasChutadas = "";
		private int quantidadeErros = 0;

		public void ComecarJogo()
		{
			palavraAtual = palavraSecreta.EscolherPalavra();

			while (quantidadeErros < 6 && !PalavraCompleta())
			{
				Console.Clear();
				ForcaDesenho.Desenhar(quantidadeErros);
				MostrarPalavra();

				Console.Write("\nDigite uma letra: ");
				string letra = Console.ReadLine().ToUpper();

				if (letra == null || letra.Length == 0 || letra.Trim().Length != 1)
				{
					Console.WriteLine("Entrada inválida. Digite apenas uma letra.");
					Console.ReadKey();
					continue;
				}

				char letraChutada = letra[0];
				bool acertou = false;

				// Verifica se a letra está na palavra
				for (int i = 0; i < palavraAtual.Length; i++)
				{
					if (palavraAtual[i] == letraChutada)
					{
						acertou = true;
						break;
					}
				}

				if (!acertou)
					quantidadeErros++;

				// Registra a letra chutada
				letrasChutadas += letraChutada;
			}

			Console.Clear();
			ForcaDesenho.Desenhar(quantidadeErros);

			if (PalavraCompleta())
			{
				Console.WriteLine("\nParabéns, você acertou a palavra secreta");
				Console.WriteLine($"A palavra era: {palavraAtual}");
			}
			else
			{
				Console.WriteLine("\nQue pena!, você perdeu!");
				Console.WriteLine($"A palavra era: {palavraAtual}");
			}

			Console.WriteLine("\nPressione Enter para sair...");
			Console.ReadLine();
		}

		private void MostrarPalavra()
		{
			for (int i = 0; i < palavraAtual.Length; i++)
			{
				char c = palavraAtual[i];
				bool caractereChutado = false;

				// Verifica se o caractere ja foi chutado
				for (int j = 0; j < letrasChutadas.Length; j++)
				{
					if (letrasChutadas[j] == c)
					{
						caractereChutado = true;
						break;
					}
				}

				if (caractereChutado)
					Console.Write(c + " ");
				else
					Console.Write("_ ");
			}
			Console.WriteLine();
		}

		private bool PalavraCompleta()
		{
			for (int i = 0; i < palavraAtual.Length; i++)
			{
				char c = palavraAtual[i];
				bool caractereChutado = false;

				// Verifica em todo o histórico de chutadas
				for (int j = 0; j < letrasChutadas.Length; j++)
				{
					if (letrasChutadas[j] == c)
					{
						caractereChutado = true;
						break;
					}
				}

				if (!caractereChutado)
					return false;
			}

			return true;
		}
	}
}
