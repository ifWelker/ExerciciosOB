using System.Security.Cryptography;

namespace CursoCSharp
{
    class Program
    {
        static void Main()
        {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Dados da Primeira Pessoa: ");
            p1.nome = Console.ReadLine();
            p1.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome: {0}\nIdade: {1}", p1.nome, p1.idade);

            Console.WriteLine("Dados da Segunda Pessoa:");
            p2.nome = Console.ReadLine();
            p2.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome: {0}\nIdade: {1}", p2.nome, p2.idade);

            if (p1.idade > p2.idade)
            {
                Console.WriteLine("Pessoa mais velha: {0}", p1.nome);
            }else
            {
                Console.WriteLine("Pessoa mais velha: {0}", p2.nome);
            }

        }
    }
}
