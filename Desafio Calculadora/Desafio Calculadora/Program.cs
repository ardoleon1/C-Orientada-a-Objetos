using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = -1, verificador;
            Console.WriteLine("\t\t---Calculadora---");
            Console.WriteLine("Seja bem-vindo à calculadora!");
            do
            {
                Console.WriteLine("\n1 - Soma\n2 - Subtração\n3 - Divisão\n4 - Multiplicação\n5 - Resto da Divisão\n6 - Dobro\n7 - Quadrado\n8 - Cubo\n9 - Raiz Quadrado\n0 - Sair");
                Console.Write("O que você deseja fazer? ");
                verificador = int.Parse(Console.ReadLine());
                if (verificador < 0 || verificador > 9)
                {
                    Console.Clear();
                    Console.WriteLine("Digite um valor válido!");
                } else
                {
                    cont = verificador;
                }
                switch (cont)
                {
                    case 0:
                        Console.WriteLine("\nTenha um ótimo dia!");
                        break;
                    case 1:
                        Somar();
                        break;
                    case 2:
                        Subtracao();
                        break;
                    case 3:
                        Divisao();
                        break;
                    case 4:
                        Multiplicacao();
                        break;
                    case 5:
                        Resto();
                        break;
                    case 6:
                        Dobro();
                        break;
                    case 7:
                        Quadrado();
                        break;
                    case 8:
                        Cubo();
                        break;
                    case 9:
                        Raiz();
                        break;
                }
            } while (cont != 0);
            Console.ReadKey();
        }
        static void Somar()
        {
            Console.Write("Digite o 1º valor: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Digite o 2º valor: ");
            double y = double.Parse(Console.ReadLine());

            double total = x + y;
            Console.Clear();
            Console.WriteLine("O Resultado é " + total);
        }
        static void Subtracao()
        {
            Console.Write("Digite o 1º valor: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Digite o 2º valor: ");
            double y = double.Parse(Console.ReadLine());

            double total = x - y;
            Console.Clear();
            Console.WriteLine("O Resultado é " + total);
        }
        static void Divisao()
        {
            Console.Write("Digite o 1º valor: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Digite o 2º valor: ");
            double y = double.Parse(Console.ReadLine());

            double total = x / y;
            Console.Clear();
            Console.WriteLine("O Resultado é " + total);
        }
        static void Multiplicacao()
        {
            Console.Write("Digite o 1º valor: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Digite o 2º valor: ");
            double y = double.Parse(Console.ReadLine());

            double total = x * y;
            Console.Clear();
            Console.WriteLine("O Resultado é " + total);
        }
        static void Resto()
        {
            Console.Write("Digite o 1º valor: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Digite o 2º valor: ");
            double y = double.Parse(Console.ReadLine());

            double total = x % y;
            Console.Clear();
            Console.WriteLine("O Resultado é " + total);
        }
        static void Dobro()
        {
            Console.Write("Digite um valor: ");
            double x = double.Parse(Console.ReadLine());

            double total = x * 2;
            Console.Clear();
            Console.WriteLine("O Resultado é " + total);
        }
        static void Quadrado()
        {
            Console.Write("Digite um valor: ");
            double x = double.Parse(Console.ReadLine());

            double total = x * x;
            Console.Clear();
            Console.WriteLine("O Resultado é " + total);
        }
        static void Cubo()
        {
            Console.Write("Digite um valor: ");
            double x = double.Parse(Console.ReadLine());

            double total = x * x * x;
            Console.Clear();
            Console.WriteLine("O Resultado é " + total);
        }
        static void Raiz()
        {
            Console.Write("Digite um valor: ");
            double x = double.Parse(Console.ReadLine());

            double total = Math.Sqrt(x);
            Console.Clear();
            Console.WriteLine("O Resultado é " + total);
        }
    }
}
