namespace CSBarbearia
{
    [Serializable]
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }
        public string Marca { get; set; }
        public double PrecoFornecedor { get; set; }
        public bool Adulto { get; set; }

        public Produto()
        {
            Estoque = 0;
        }
    }
}
