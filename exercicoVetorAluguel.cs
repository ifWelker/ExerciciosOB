//Classe Estudante

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    internal class Estudante
    {
        public string Name { get; set; } //propertie

        public string Email { get; set; } //propertie

        public Estudante(string name, string email) //construtor
        {
            Name = name;
            Email = email;  
        }

        public override string ToString() // Overide To String
        {
            return Name + ", " + Email; 
        }
    }
}

// Program

using System.Numerics;
using System.Security.Cryptography;

namespace CursoCSharp
{
    class Program
    {
        static void Main()
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Estudante[] vect = new Estudante[10];

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante (name,email);
                    
            }
            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados: ");

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
