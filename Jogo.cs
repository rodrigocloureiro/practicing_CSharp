namespace tp3csharp
{
    public class Jogo
    {
        private string _titulo;
        private int _faixaEtaria;
        private DateTime _dataLancamento;
        private double _preco;
        private bool _exclusivo;

        public Jogo(string titulo, int faixaEtaria, DateTime dataLancamento, double preco, bool exclusivo)
        {
            Titulo = titulo;
            FaixaEtaria = faixaEtaria;
            DataLancamento = dataLancamento;
            Preco = preco;
            Exclusivo = exclusivo;
        }

        public string Titulo { get => _titulo; set => _titulo = value; }
        public int FaixaEtaria { get => _faixaEtaria; set => _faixaEtaria = value; }
        public DateTime DataLancamento { get => _dataLancamento; set => _dataLancamento = value; }
        public double Preco { get => _preco; set => _preco = value; }
        public bool Exclusivo { get => _exclusivo; set => _exclusivo = value; }

        public override string ToString()
        {
            return $"Título: {_titulo}\n" +
                $"Faixa etária: {_faixaEtaria} anos\n" +
                $"Lançamento: {_dataLancamento.ToString("dd/MM/yyyy")}\n" +
                $"Preço: R$ {_preco}\n" +
                $"É exclusivo: {(_exclusivo ? "Sim" : "Não")}\n";
        }
    }
}
