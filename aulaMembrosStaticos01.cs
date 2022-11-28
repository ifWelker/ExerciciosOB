using System.Security.Cryptography;

namespace CursoCSharp
{
    class Program
    {

        static double Pi = 3.14;
        static void Main()
        {
            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferencia = " + circ.ToString());
            Console.WriteLine("Volume = " + volume.ToString("F2"));
            Console.WriteLine("Valor de Pi = " + Pi.ToString());

        }

        static double Circunferencia (double r) //A variavel r é do Raio, diferente da variavel acima
        {
            return 2.0 * Pi * r;
        }

        static double Volume (double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }

    }
}
