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
        private string _nome;
        private double _preco;
        private int _quantidade;

   //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

       public Produto (string nome, double preco, int qtd)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = qtd;
        }
        // Metodos Get permitem inserção de dados,
        //Metodos Set permites a edição/alteração de dados.
        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        { 
            if (nome != null && nome.Length > 1)
            _nome = nome; 
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade; 
        }

        public Produto()
        {

        }

        //Metodos
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade = _quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade = _quantidade - quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + _preco.ToString("F2")
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
