using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp //Aula de Encapsulamento
{
    internal class Produto
        //Atributos
    {

        //Atributos em private, evita que usuários alterem os dados do codigo fonte.

        //Auto Propertie é utilizado quando o metodo nao possui uma logica
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

   //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

       public Produto (string nome, double preco, int qtd)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = qtd;
        }
        // Metodos Get permitem inserção de dados,
        // Metodos Set permites a edição/alteração de dados.

        public string Nome //Este metodo possui logica, logo não utiliza o auto propertie, tem que escrever a propertie
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }

        public Produto()
        {

        }

        //Metodos
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + Preco.ToString("F2")
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
