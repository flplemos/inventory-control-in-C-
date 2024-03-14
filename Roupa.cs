
    class Roupa
    {
        public string Nome { get; }
        public string Cor { get; }
        public double Preco { get; set; }
        public string Marca { get; }
        public string Tamanho { get; }
        public string Material { get; }
        public int Quantidade { get; set; }

        public Roupa(string nome, string cor, double preco, string marca, string tamanho, string material)
        {
            Nome = nome;
            Cor = cor;
            Preco = preco;
            Marca = marca;
            Tamanho = tamanho;
            Material = material;
            Quantidade = 0;
        }
    }

