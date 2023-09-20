using tp3csharp;

public class Program
{
    public static void Main(string[] args)
    {
        IAdicionar i = new AdicionarJogo();

        i.AdicionarGame(new Jogo("Rainbow Six Siege", 16, DateTime.ParseExact("01/12/2015", "dd/MM/yyyy", null), 199.90, false));

        List<Jogo> jogos = i.ListaJogos().ToList();

        jogos.ForEach(jogo => Console.WriteLine(jogo));

        Console.ReadKey();
    }
}
