using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp //Classe com Membros Estaticos
{
    internal class Calculadora
    {
       public static double Pi = 3.14;

        public static double Circunferencia(double r) //A variavel r é do Raio, diferente da variavel acima
        {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
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

            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia = " + circ.ToString());
            Console.WriteLine("Volume = " + volume.ToString("F2"));
            Console.WriteLine("Valor de Pi = " + Calculadora.Pi.ToString());

        }
    }
}
