using System.Collections.Immutable;

namespace tp3csharp
{
	public interface IAdicionar
	{
		void AdicionarGame(Jogo jg);
        ImmutableList<Jogo> ListaJogos();
	}
}

