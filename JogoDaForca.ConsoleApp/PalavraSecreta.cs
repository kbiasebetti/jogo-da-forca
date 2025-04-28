namespace JogoDaForca.ConsoleApp;

public class PalavraSecreta
{
	private string[] palavras;
	private string palavraEscolhida;

	public PalavraSecreta()
	{
		if (File.Exists("palavras.txt"))
		{
			palavras = File.ReadAllLines("palavras.txt");
		}
		else
		{
			Console.WriteLine("ERRO: O banco de palavras não foi encontrado!");
		}
	}

	public string EscolherPalavra()
	{
		Random geradorDePalavra = new Random();
		int indicePalavraEscolhida = geradorDePalavra.Next(palavras.Length);

		palavraEscolhida = palavras[indicePalavraEscolhida].ToUpper().Trim();

		return palavraEscolhida;
	}
}
