using System;

namespace Polimorfismo2.Src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opUpper;
            do
            {
                Console.Write("\nEntre com uma opção de cálculo\n" +
                "1 - Área do Quadrado\n" +
                "2 - Área do Retangulo\n" +
                "3 - Área do Triangulo\n\n" +
                "Digite a opção escohida: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("\nÁrea do Quadrado\n" +
                            "Entre com o valor do lado: ");
                        double lado = double.Parse(Console.ReadLine());

                        Quadrado quadrado = new Quadrado(lado);

                        Console.WriteLine(quadrado.ToString());
                        break;

                    case 2:
                        Console.Write("\nÁrea do Retangulo\n" +
                            "Entre com o valor para largura: ");
                        double largura = double.Parse(Console.ReadLine());
                        Console.Write("Entre com o valor para altura: ");
                        double altura = double.Parse(Console.ReadLine());

                        Retangulo retangulo = new Retangulo(largura, altura);

                        Console.WriteLine(retangulo.ToString());
                        break;

                    case 3:
                        Console.Write("\nÁrea do Triangulo\n" +
                            "Entre com o valor da base: ");
                        double basee = double.Parse(Console.ReadLine());
                        Console.Write("Entre com o valor da altura: ");
                        altura = double.Parse(Console.ReadLine());

                        Triangulo triangulo = new Triangulo(basee, altura);

                        Console.WriteLine(triangulo.ToString());
                        break;

                    default:
                        Console.WriteLine("Selecione uma opção válida");
                        break;
                }
                Console.Write("\nDeseja continuar?\n" +
                    "S - Sim\n" +
                    "N - Não\n");
                Console.Write("Digite a opção escohida: ");
                string op = Console.ReadLine();
                opUpper = op.ToUpper();
            } while (opUpper == "S");
        }
    }
}