//Classe

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    internal class Conta
    {

        //Atributos

        public int Id { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        //Metodos
        public Conta(int id, string titular) //Construtor com 2 parametros (sobrecarga)
        {
            Id = id;
            Titular = titular;
            Saldo = 0.0;
        }

        public Conta(int id, string titular, double saldo) : this(id, titular) //Construtor com os 3 parametros.
        {
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
               + Id
               + ", Titular: "
               + Titular
               + " Saldo: $ "
               + Saldo.ToString("F2");
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
            Conta conta;

            Console.Write(" Entre com o numero da conta: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Entre com o Titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Havera Deposito Inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Ente o valor de deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new Conta(id, titular, depositoInicial);
            }
            else
            {
                conta = new Conta(id, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com um valor de Deposito: ");
            double quantia = double.Parse(Console.ReadLine());
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com um valor para o saque: ");
            quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}
