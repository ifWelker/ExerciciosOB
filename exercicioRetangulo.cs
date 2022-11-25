\\Classe

using System;

namespace CursoCSharp
{
    internal class Retangulo
    {
        public double l, h;

        public double Area()
        {
            return l * h;
        }

        public double Perimetro()
        {
            return 2 * (l + h);
        }

        public double Diagonal()
        {
            return Math.Sqrt(l * l + h * h);
        }
    }   
}

\\Program

using System.Security.Cryptography;

namespace CursoCSharp
{
    class Program
    {
        static void Main()
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retangulo");
            r.l = double.Parse(Console.ReadLine());
            r.h= double.Parse(Console.ReadLine());

            Console.WriteLine("Area = " + r.Area().ToString("F2") +
                "\nPerimetro = " + r.Perimetro().ToString("F2") +
                "\nDiagonal = " + r.Diagonal().ToString("F2"));

        }
    }
}
