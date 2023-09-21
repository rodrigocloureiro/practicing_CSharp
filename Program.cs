using tp3csharp;

public class Program
{
    public static void Main(string[] args)
    {
        IAdicionar i = new AdicionarJogo();

        i.AdicionarGame(new Jogo("Rainbow Six Siege", 16, DateTime.ParseExact("01/12/2015", "dd/MM/yyyy", null), 199.90, false));

        int opcao;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1- Adicionar Jogo");
            Console.WriteLine("2- Pesquisar Jogo");
            Console.WriteLine("3- Sair");
            int.TryParse(Console.ReadLine(), out opcao);

            if (opcao == 3)
            {
                Console.WriteLine("Saindo...");
                break;
            }

            switch (opcao)
            {
                case 0:
                    Console.WriteLine("Informe somente números inteiros. Tente novamente.");
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("***** Informe os dados do jogo *****");

                    Console.Write("Nome: ");
                    string titulo = Console.ReadLine();

                    Console.Write("Faixa etária: ");
                    int faixaEtaria = int.Parse(Console.ReadLine());

                    Console.Write("Data de lançamento (dia/mes/ano): ");
                    string dataLancamento = Console.ReadLine();

                    Console.Write("Preço: R$ ");
                    double preco = double.Parse(Console.ReadLine());

                    Console.Write("É exclusivo (S/N)? ");
                    //char exclusivo = Console.ReadKey().KeyChar;
                    bool exclusivo = Console.ReadLine()[0] == 'S' ? true : false;

                    i.AdicionarGame(new Jogo(titulo, faixaEtaria, DateTime.ParseExact(dataLancamento, "dd/MM/yyyy", null), preco, exclusivo));
                    Console.WriteLine("Jogo adicionado com sucesso.");
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Informe o nome do jogo: ");
                    string tituloFiltro = Console.ReadLine().ToLower();

                    List<Jogo> listaFiltrada = i.ListaJogos()
                        .Where(jogo => jogo.Titulo.ToLower()
                            .Contains(tituloFiltro))
                        .OrderBy(jogo => jogo.Titulo)
                        .ToList();

                    if (listaFiltrada.Count == 0)
                    {
                        Console.WriteLine("Não há elementos correspondentes na lista.");
                        break;
                    }

                    for (int j = 0; j < listaFiltrada.Count; j++)
                    {
                        Console.WriteLine($"{j + 1}- {listaFiltrada.ElementAt(j).Titulo}");
                    }

                    Console.Write("Escolha uma das opções: ");
                    int escolha;
                    int.TryParse(Console.ReadLine(), out escolha);

                    if (escolha <= 0 || escolha > listaFiltrada.Count) Console.Write("Opção inválida.");
                    else Console.WriteLine("\n" + listaFiltrada.ElementAt(escolha - 1));

                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
            Console.ReadKey();
        }
        Console.ReadKey();
    }
}
