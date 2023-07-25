using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Método_Somar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio1();
        }
        static void Exercicio1()
        {
            Console.Write("Informe o 1º valor: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Informe o 2º valor: ");
            double y = double.Parse(Console.ReadLine());

            double resultado = Somar(x, y);
            Console.WriteLine("O resultado é " + resultado);
            Console.ReadKey();
        }
        static void Exercicio2()
        {
            Console.Write("Informe o 1º valor: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Informe o 2º valor: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDiferença: " + CalcularDiferenca(x, y));
        }
        static double Somar(double x, double y)
        {
            return x + y;
        }
        static double CalcularDiferenca(double x, double y)
        {
            if (x > y)
                return x - y;
            else
                return y - x;
        }
    }
}
