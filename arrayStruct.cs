using System.Numerics;
using System.Security.Cryptography;

namespace CursoCSharp
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n]; // <=== Estrutura de um vetor. tipo [] nome = new tipo [quantidade informada para vetor];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine());
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("Average Height = " + avg.ToString("F2"));
        }
    }
}
