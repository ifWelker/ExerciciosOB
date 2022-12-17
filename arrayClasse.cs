using System.Numerics;
using System.Security.Cryptography;


// Nesse exercicio foi criado uma classe com a propertie Produto

namespace CursoCSharp
{
    class Program
    {
        static void Main()
        {
            Console.Write("Entre com a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            produtoarray[] vect = new produtoarray[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vect[i] = new produtoarray { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum/ n;
            Console.WriteLine();
            Console.WriteLine("Average Price = " + avg);
        }
    }
}
