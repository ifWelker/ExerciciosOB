using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Essa classe esta com Construtor Produto

namespace CursoCSharp
{
    internal class Produto
        //Atributos
    {
        public string Nome;
        public double Preco;
        public int Qtd;

        public Produto(string nome, double preco, int qtd) //Construtor, faz com que o usuario Tenha que entrar com um dado, evitando que as variaveis fiquem nulas
        {
            Nome = nome;
            Preco = preco;
            Qtd = qtd;
        }

        //Metodos
        public double ValorTotalEmEstoque()
        {
            return Preco * Qtd;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Qtd = Qtd + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Qtd = Qtd - quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2")
                + ", "
                + Qtd
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
