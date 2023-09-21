using System.Collections.Immutable;

namespace tp3csharp
{
	public class AdicionarJogo : IAdicionar
	{
		private List<Jogo> _jogos;

		public AdicionarJogo()
		{
			_jogos = new();
		}

		public void AdicionarGame(Jogo jg)
		{
			_jogos.Add(jg);
		}

		public ImmutableList<Jogo> ListaJogos()
		{
			return _jogos.ToImmutableList();
		}
	}
}

