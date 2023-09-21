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
            _titulo = titulo;
            _faixaEtaria = faixaEtaria;
            _dataLancamento = dataLancamento;
            _preco = preco;
            _exclusivo = exclusivo;
        }

        public string Titulo { get => _titulo; }
        public int FaixaEtaria { get => _faixaEtaria; }
        public DateTime DataLancamento { get => _dataLancamento; }
        public double Preco { get => _preco; }
        public bool Exclusivo { get => _exclusivo; }

        private int CalculaIdade()
        {
            DateTime atual = DateTime.Now;

            if (atual.Month < _dataLancamento.Month || atual.Month == _dataLancamento.Month && atual.Day < _dataLancamento.Day)
            {
                return atual.Year - _dataLancamento.Year - 1;
            }
            return atual.Year - _dataLancamento.Year;
        }

        public override string ToString()
        {
            return $"Título: {_titulo}\n" +
                $"Faixa etária: {_faixaEtaria} anos\n" +
                $"Lançamento: {_dataLancamento.ToString("dd/MM/yyyy")}\n" +
                $"Tempo desde o lançamento: {CalculaIdade()} ano(s)\n" +
                $"Preço: R$ {_preco}\n" +
                $"É exclusivo: {(_exclusivo ? "Sim" : "Não")}\n";
        }
    }
}
