using System.Security.Cryptography;

//Com chamada do construtor na classe ProdutoV2.cs

namespace CursoCSharp
{
    class Program
    {
        static void Main()
        {
                        
            Console.WriteLine("Entre os dados do Produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int qtd = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, qtd);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: {0}", p);

            Console.Write("Digite o numero de produtos a ser adicionado: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: {0}", p);

            Console.WriteLine();

            Console.Write("Digite o numero de produtos a ser removido: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados {0}", p);
            
        }
    }
}
