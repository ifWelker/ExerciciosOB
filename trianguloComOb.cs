// Foi criada a classe Triangulo para a resolução do exercicio

//Fazer um programa para ler as medidas dos lados de dois triangulos X e Y (suponha medidas validas). Em seguida, mostrar o valor das areas dos dois
//triangulos e dizer qual dos dois triangulos possui a maior área.

//Para calcular a area do triangulo é usado a formula de Heron.

namespace CursoCSharp
{    
    // Mesmo exercicio, porem, solucionado com Orientação a Objeto criando a Classe Triangulo.cs
    class Program
    {
        static void Main()
        {   
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            System.Console.WriteLine("Entre com as medidas do Triangulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre com as medidas do Triangulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double p = (x.A + x.B + x.C)/2;
            double areaX = Math.Sqrt(p* (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C)/2;
            double areaY = Math.Sqrt(p* (p - y.A) * (p - y.B) * (p - y.C));

            System.Console.WriteLine("Area de X = {0:F4}\nArea de Y = {1:F4}", areaX, areaY);

            if (areaX > areaY)
            {
                System.Console.WriteLine("Maior Area X ");
            } else
            {
                System.Console.WriteLine("Maior Area Y ");
            }
        }

    }
}
