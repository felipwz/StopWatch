using System;
using System.Xml;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();



        }


        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao cronomêtro 'caseiro' ");

            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Descendente");
            Console.WriteLine("2 - Crescente");
            Console.WriteLine("3 - Sair");
            short res;
            while (!short.TryParse(Console.ReadLine(), out res) || res < 1 || res > 3)
            {
                Console.WriteLine("Digite um valor válido");
            }

            switch (res)
            {
                case 1: Descending(); break;
                case 2: Ascending(); break;
                case 3: Console.Clear(); Environment.Exit(0); break;
                default: Console.Clear(); Environment.Exit(0); break;
            }
        }

        static void Descending()
        {

            int seconds = 0;
            Console.WriteLine("CRONOMETRO DECRESCENTE");
            Console.WriteLine("Digite quanto tempo deseja esperar: ");
            while (!int.TryParse(Console.ReadLine(), out seconds))
            {
                Console.WriteLine("Digite um valor válido");
            }

            for (int i = seconds; i >= 0; i--)
            {
                Console.Clear();
                Console.WriteLine($"Tempo restante: {i}");
                System.Threading.Thread.Sleep(1000);
            }

            Console.WriteLine("Fim do cronometro");
            Console.WriteLine("------------------");
            System.Threading.Thread.Sleep(2000);
            Menu();
        }

        static void Ascending()
        {
            int correntTime = 0;
            int seconds = 0;

            Console.WriteLine("CRONOMETRO CRESCENTE");
            Console.WriteLine("Digite até quantos segundos desja contar: ");
            while (!int.TryParse(Console.ReadLine(), out correntTime))
            {
                Console.WriteLine("Digite um valor válido");
            }

            for (int i = seconds; i < correntTime; i++)
            {
                Console.Clear();
                Console.WriteLine($"Tempo: {i}");
                System.Threading.Thread.Sleep(1000);
            }

            Console.WriteLine("Fim do cronometro");
            Console.WriteLine("------------------");
            System.Threading.Thread.Sleep(2000);
            Menu();
        }
    }
}