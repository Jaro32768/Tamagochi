using System;

namespace Tamagochi
{
    class HowToPlay
    {
        public void Setup()
        {
            Menu menu = new Menu();
            Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│     Welcome to Tamagochi, the goal of this game is to take care of your own animal and keep him alive as long as    │");
            Console.WriteLine("│     possible. You need to balance 5 statistics of your animal. You can choose your speed, dificulty, color and      │");
            Console.WriteLine("│     animal. You lose stats every hour and gain them by playing minigames. Some minigames are available only under   │");
            Console.WriteLine("│     ceirtan conditions (just reaching threshold on stats tbh). Some minigames can also hurt you if not played       │");
            Console.WriteLine("│     correctly.                                                                                                      │");
            Console.WriteLine("│     And remember the point of games isn't to win, but to have fun :)                                                │");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │            EXIT [X]           │                                           │");
            Console.WriteLine("│                                         └───────────────────────────────┘                                           │");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
            while (true)
            {
                char button = Convert.ToChar(Console.Read());

                Console.WriteLine(button);
                switch (button)
                {
                    case 'X':
                    case 'x':
                        {
                            Console.Clear();
                            menu.Setup();
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Setup();
                            break;
                        }
                }
            }
        }
    }
}
