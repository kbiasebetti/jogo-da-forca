namespace JogoDaForca.ConsoleApp;

public class ForcaDesenho
{
	public static void Desenhar(int quantidadeErros)
	{
		Console.Clear();
		Console.WriteLine("-------------------");
		Console.WriteLine(" | Jogo da Forca | ");
		Console.WriteLine("-------------------");

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

	}
}