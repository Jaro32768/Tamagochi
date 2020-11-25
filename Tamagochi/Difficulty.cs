using System;

namespace Tamagochi
{
    /// <summary>
    /// This method sets up console for difficulty pick view.
    /// </summary>
    class Difficulty
    {
        public void Setup() //not done yet
        {
            FirstOpen firstOpen = new FirstOpen();
            Options options = new Options();
            Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │            HARD [H]           │                                           │");
            Console.WriteLine("│                                         └───────────────────────────────┘                                           │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │           NORMAL [N]          │                                           │");
            Console.WriteLine("│                                         └───────────────────────────────┘                                           │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │            EASY [E]           │                                           │");
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
                    case 'H':
                    case 'h':
                        {
                            firstOpen.SetDifficulty(2);
                            Console.Clear();
                            Setup();
                            break;
                        }
                    case 'N':
                    case 'n':
                        {
                            firstOpen.SetDifficulty(1);
                            Console.Clear();
                            Setup();
                            break;
                        }
                    case 'E':
                    case 'e':
                        {
                            firstOpen.SetDifficulty(0);
                            Console.Clear();
                            Setup();
                            break;
                        }
                    case 'X':
                    case 'x':
                        {
                            Console.Clear();
                            options.Setup();
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
