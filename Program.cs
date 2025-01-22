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
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("S = Segndos 10s => 10 segundos");
            Console.WriteLine("m = Minutos 1m => 1 minuto");
            Console.WriteLine("0 = Sair");
            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));


            int time = int.Parse(data.Substring(0, data.Length - 1));

            if (type == 'm')
                time *= 60;

            if (time == 0)
                Environment.Exit(0);

            Console.WriteLine("---------------------------");
            Console.WriteLine("Agora Escolha uma opção: ");
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
                case 1: Descending(time); break;
                case 2: Ascending(time); break;
                case 3: Console.Clear(); Environment.Exit(0); break;
                default: Console.Clear(); Environment.Exit(0); break;
            }


        }

        static void Descending(int time)
        {

            while (time > 0)
            {
                Console.Clear();
                time--;
                Console.WriteLine($"Tempo restante: {time}");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Fim do cronometro");
            Console.WriteLine("------------------");
            Thread.Sleep(2000);
            Menu();
        }

        static void Ascending(int time)
        {

            int seconds = 0;

            while (seconds < time)
            {
                Console.Clear();
                seconds++;
                Console.WriteLine($"Tempo: {seconds}");
                System.Threading.Thread.Sleep(1000);
            }

            Console.WriteLine("Fim do cronometro");
            Console.WriteLine("------------------");
            System.Threading.Thread.Sleep(2000);
            Menu();
        }
    }
}