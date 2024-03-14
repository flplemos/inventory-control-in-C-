
    class Navegacao
    {
        public int Menu()
        {
            Console.WriteLine("[1] Novo Produto");
            Console.WriteLine("[2] Listar Produtos");
            Console.WriteLine("[3] Remover Produto");
            Console.WriteLine("[4] Entrada Estoque");
            Console.WriteLine("[5] Saída Estoque");
            Console.WriteLine("[0] Sair");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }
    }

