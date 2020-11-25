using System;

namespace Tamagochi
{
    class Credits
    {
        /// <summary>
        /// This method sets up console for credits view.
        /// </summary>
        public void Setup()
        {
            Menu menu = new Menu();
            Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                        This game was made by Jaro and Matúš.                                        │");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │            BACK [X]           │                                           │");
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
