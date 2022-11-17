//Esse é um problema voltado a Orientação de Objeto, porem, "solucionado" sem fazer a orientação a objeto.

//Fazer um programa para ler as medidas dos lados de dois triangulos X e Y (suponha medidas validas). Em seguida, mostrar o valor das areas dos dois
//triangulos e dizer qual dos dois triangulos possui a maior área.

//Para calcular a area do triangulo é usado a formula de Heron.

namespace Curso
{    
    class Program
    {
        static void Main()
        {   
            System.Console.WriteLine("Entre com as medidas do triangulo X: ");
            //triangulo X
            double a, b, c;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            double p = (a + b + c)/2;
            double areaX = Math.Sqrt(p* (p - a) * (p - b) * (p - c));
            System.Console.WriteLine("A area é: {0}", areaX);

            System.Console.WriteLine("Entre com as medidas do triangulo Y:");
            //triangulo Y
            double x, y, z;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            z = double.Parse(Console.ReadLine());
            p = (x + y + z)/2;
            double areaY = Math.Sqrt(p *(p - x) * (p - y) * (p - z));
            System.Console.WriteLine("A area é: {0}", areaY);

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
