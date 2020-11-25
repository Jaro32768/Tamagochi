using System;
using System.Threading;

namespace Tamagochi
{
    class Intro
    {
        /// <summary>
        /// This method sets up console for intro view.
        /// </summary>
        public void PlayIntro()
        {
            Menu menu = new Menu();
            string logo = @"
    
    ▄▄▄█████▓ ▄▄▄       ███▄ ▄███▓ ▄▄▄        ▄████  ▒█████   ▄████▄   ██░ ██  ██▓
    ▓  ██▒ ▓▒▒████▄    ▓██▒▀█▀ ██▒▒████▄     ██▒ ▀█▒▒██▒  ██▒▒██▀ ▀█  ▓██░ ██▒▓██▒
    ▒ ▓██░ ▒░▒██  ▀█▄  ▓██    ▓██░▒██  ▀█▄  ▒██░▄▄▄░▒██░  ██▒▒▓█    ▄ ▒██▀▀██░▒██▒
    ░ ▓██▓ ░ ░██▄▄▄▄██ ▒██    ▒██ ░██▄▄▄▄██ ░▓█  ██▓▒██   ██░▒▓▓▄ ▄██▒░▓█ ░██ ░██░
      ▒██▒ ░  ▓█   ▓██▒▒██▒   ░██▒ ▓█   ▓██▒░▒▓███▀▒░ ████▓▒░▒ ▓███▀ ░░▓█▒░██▓░██░
      ▒ ░░    ▒▒   ▓▒█░░ ▒░   ░  ░ ▒▒   ▓▒█░ ░▒   ▒ ░ ▒░▒░▒░ ░ ░▒ ▒  ░ ▒ ░░▒░▒░▓  
        ░      ▒   ▒▒ ░░  ░      ░  ▒   ▒▒ ░  ░   ░   ░ ▒ ▒░   ░  ▒    ▒ ░▒░ ░ ▒ ░
      ░        ░   ▒   ░      ░     ░   ▒   ░ ░   ░ ░ ░ ░ ▒  ░         ░  ░░ ░ ▒ ░
                   ░  ░       ░         ░  ░      ░     ░ ░  ░ ░       ░  ░  ░ ░  
                                                             ░
";
            for (int i = 0; i < logo.Length; i++)
            {
                if (logo[i] == '▓' || logo[i] == '░' || logo[i] == '▒')
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.Write(logo[i]);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;


            string intro = "Hello, welcome to this game.You will get a chance to take care of your own animal.Before you start playing, I recomend you to visit Options [O], as soon as you get moved to MENU.Click any key to be moved to MENU!";
            for (int i = 0; i < intro.Length; i++)
            {
                Console.Write(intro[i]);
                if (intro[i] == ' ')
                {
                    Thread.Sleep(100);
                }
                else if (intro[i] == ',')
                {
                    Thread.Sleep(150);
                }
                else
                {
                    Thread.Sleep(50);
                    if (intro[i] == '.')
                    {
                        Thread.Sleep(100);
                        Console.WriteLine();
                    }
                }

            }
            Console.ReadKey();
            Console.Clear();
            menu.Setup();
        }
    }
}
