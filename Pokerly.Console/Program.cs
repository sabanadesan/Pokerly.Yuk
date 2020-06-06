using System;

using Pokerly.Yuk;

namespace Pokerly.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(CurrentDomain_ProcessExit);

            System.Console.CancelKeyPress += (object sender, ConsoleCancelEventArgs e) =>
            {
                Environment.Exit(0);
            };

            System.Console.WriteLine("Hello World!");

            while (true)
            {
                try
                {
                    Game game = new Game(new TexasHoldemPoker());
                    game.Run();
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message.ToString());
                }
            }
        }

        static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
            System.Console.WriteLine("exit");
        }
    }
}
