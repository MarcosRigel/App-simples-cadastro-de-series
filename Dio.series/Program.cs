using System;

namespace Dio.series
{
    class Program
    {
		static void Main(string[] args)
		{
			Metodos objeto = new Metodos();
			string opcaoUsuario = objeto.ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						objeto.ListarSeries();
						break;
					case "2":
						objeto.InserirSerie();
						break;
					case "3":
						objeto.AtualizarSerie();
						break;
					case "4":
						objeto.ExcluirSerie();
						break;
					case "5":
						objeto.VisualizarSerie();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = objeto.ObterOpcaoUsuario();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
		}
    }
}