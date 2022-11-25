using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    internal class Produto
        //Atributos
    {
        public string Nome;
        public double Preco;
        public int Qtd;

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
