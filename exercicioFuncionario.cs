using System.Security.Cryptography;

namespace CursoCSharp
{
    class Program
    {
        static void Main()
        {
            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do Primeiro funcionario:");
            f1.Nome = Console.ReadLine();
            f1.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Nome: {0}\nSalario: {1}", f1.Nome, f1.Salario);

            Console.WriteLine("Dados do Segundo funcionario:");
            f2.Nome = Console.ReadLine();
            f2.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Nome: {0}\nSalario: {1}", f2.Nome, f2.Salario);

            double mediaSalario = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine("Salario Medio = {0}", mediaSalario);
        }
    }
}
