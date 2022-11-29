//Conversao de Moeda


//Classe de membro estatico

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double Converao (double valor, double cotacao)
        {
            double total = valor * cotacao;
            return total + (total * Iof / 100);
        }
        
    }
}


//Program

using System.Security.Cryptography;

namespace CursoCSharp
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Qual a cotação do Dolar? ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.WriteLine("Cotação => " + cotacao.ToString("F2"));

            Console.WriteLine("Qual valor a ser comprado?");
            double quantia = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantia => " + quantia);

            double conversao = ConversorDeMoeda.Converao(quantia,cotacao);
            Console.WriteLine("O valor a ser pago é de => " + conversao.ToString("F2"));


        }
    }
}
