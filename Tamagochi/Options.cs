using System;

namespace Tamagochi
{
    class Options
    {
        /// <summary>
        /// This method sets up console for options view
        /// </summary>
        public void Setup()
        {
            Speed speed = new Speed();
            Difficulty difficulty = new Difficulty();
            Color color = new Color();
            Menu menu = new Menu();
            Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │         GAME SPEED [S]        │                                           │");
            Console.WriteLine("│                                         └───────────────────────────────┘                                           │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │         DIFFICULTY [D]        │                                           │");
            Console.WriteLine("│                                         └───────────────────────────────┘                                           │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │         GAME COLOR [C]        │                                           │");
            Console.WriteLine("│                                         └───────────────────────────────┘                                           │");
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
                    case 'S':
                    case 's':
                        {
                            Console.Clear();
                            speed.Setup();
                            break;
                        }
                    case 'D':
                    case 'd':
                        {
                            Console.Clear();
                            difficulty.Setup();
                            break;
                        }
                    case 'C':
                    case 'c':
                        {
                            Console.Clear();
                            color.Setup();
                            break;
                        }
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
