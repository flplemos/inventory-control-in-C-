    class Estoque
    {
        private List<Roupa> roupas = new List<Roupa>();

        public void AdicionarRoupa(Roupa novaRoupa)
        {
            roupas.Add(novaRoupa);
        }

        public void ListarRoupas()
        {
            Console.WriteLine("Lista de Roupas no Estoque:");
            for (int i = 0; i < roupas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Nome: {roupas[i].Nome}, Cor: {roupas[i].Cor}, Marca: {roupas[i].Marca}, Tamanho: {roupas[i].Tamanho}, Material: {roupas[i].Material}, Preço: {roupas[i].Preco}, Quantidade: {roupas[i].Quantidade}");
            }
        }

        public void RemoverRoupa(int posicao)
        {
            if (posicao > 0 && posicao <= roupas.Count)
            {
                roupas.RemoveAt(posicao - 1);
                Console.WriteLine("Roupa removida.");
            }
            else
            {
                Console.WriteLine("Posição inválida.");
            }
        }

        public void EntradaEstoque(int posicao, int quantidade)
        {
            if (posicao > 0 && posicao <= roupas.Count)
            {
                roupas[posicao - 1].Quantidade += quantidade;
                Console.WriteLine("Estoque atualizado.");
            }
            else
            {
                Console.WriteLine("Posição inválida.");
            }
        }

        public void SaidaEstoque(int posicao, int quantidade)
        {
            if (posicao > 0 && posicao <= roupas.Count)
            {
                if (roupas[posicao - 1].Quantidade >= quantidade)
                {
                    roupas[posicao - 1].Quantidade -= quantidade;
                    Console.WriteLine("Estoque atualizado.");
                }
                else
                {
                    Console.WriteLine("Quantidade de saída excede o estoque disponível.");
                }
            }
            else
            {
                Console.WriteLine("Posição inválida.");
            }
        }
    }

