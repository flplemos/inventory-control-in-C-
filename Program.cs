using System;

namespace pti_algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            Estoque estoque = new Estoque();
            Navegacao navegacao = new Navegacao();

            int opcao;
            do
            {
                Console.WriteLine("CONTROLE DE ESTOQUE - LOJA DE ROUPAS");
                opcao = navegacao.Menu();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Informe o nome da roupa:");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Informe a cor:");
                        string cor = Console.ReadLine();

                        Console.WriteLine("Informe o material:");
                        string material = Console.ReadLine();

                        Console.WriteLine("Informe o preço:");
                        double preco = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a marca:");
                        string marca = Console.ReadLine();

                        Console.WriteLine("Informe o tamanho:");
                        string tamanho = Console.ReadLine();

                        Roupa novaRoupa = new Roupa(nome, cor, preco, marca, tamanho, material);
                        estoque.AdicionarRoupa(novaRoupa);

                        Console.WriteLine("Roupa adicionada!");
                        break;

                    case 2:
                        estoque.ListarRoupas();
                        break;

                    case 3:
                        Console.WriteLine("Informe a posição da roupa a ser removida:");
                        int posicaoRemocao = Convert.ToInt32(Console.ReadLine());
                        estoque.RemoverRoupa(posicaoRemocao);
                        break;

                    case 4:
                        Console.WriteLine("Informe a posição da roupa:");
                        int posicaoEntrada = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe a quantidade de Entrada:");
                        int quantidadeEntrada = Convert.ToInt32(Console.ReadLine());

                        estoque.EntradaEstoque(posicaoEntrada, quantidadeEntrada);
                        break;

                    case 5:
                        Console.WriteLine("Informe a posição da roupa:");
                        int posicaoSaida = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe a quantidade de Saída:");
                        int quantidadeSaida = Convert.ToInt32(Console.ReadLine());

                        estoque.SaidaEstoque(posicaoSaida, quantidadeSaida);
                        break;

                    case 0:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }
    }
}
