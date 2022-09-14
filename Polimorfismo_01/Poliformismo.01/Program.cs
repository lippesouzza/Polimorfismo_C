using System;

namespace Polimorfismo1.Src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O animal que você está pensando é onivoro? (S/N)");
            string o = Console.ReadLine();

            if (o == "S" || o =="s")
            {
                Onivoros _resposta = new Onivoros();
                Console.WriteLine(_resposta.ToString());
            }

            else
            {
                Console.WriteLine("O animal que você está pensando é herbívoro? (S/N)");
                string c = Console.ReadLine();

                if (c == "S" || c == "s")
                {
                    Herbivoros _resposta = new Herbivoros();
                    Console.WriteLine(_resposta.ToString());
                }
                
                else
                {
                    Console.WriteLine("O animal que você está pensando é carnívoro? (S/N)");
                    string h = Console.ReadLine();

                    if (h == "S" || h == "s")
                    {
                        Carnivoros _resposta = new Carnivoros();
                        Console.WriteLine(_resposta.ToString());
                    }

                    else
                    {
                        Console.WriteLine("Então esse animal vai morrer de fome");
                    }
                }
            }
        }
    }
}