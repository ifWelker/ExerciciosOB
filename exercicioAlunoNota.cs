// Classe

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    internal class Aluno
    {
       public string Nome;
       public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }
        public bool Aprovado()
        {
            if (NotaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Diferenca()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60 - NotaFinal();
            }
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
            Aluno aluno = new Aluno();

            Console.WriteLine("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Ente com as 3 notas do aluno");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2= double.Parse(Console.ReadLine());
            aluno.Nota3= double.Parse(Console.ReadLine());
            Console.WriteLine("Nota Final: " + aluno.NotaFinal().ToString());

            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
            }
            Console.WriteLine("Faltaram " + aluno.Diferenca().ToString() + " Pontos!");
            
        }
    }
}
