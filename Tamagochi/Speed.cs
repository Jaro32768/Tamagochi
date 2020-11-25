using System;

namespace Tamagochi
{
    class Speed
    {
        /// <summary>
        /// This method sets up console for speed view.
        /// </summary>
        public void Setup()
        {
            FirstOpen firstOpen = new FirstOpen();
            Options options = new Options();
            Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │         ULTRA FAST [U]        │                                           │");
            Console.WriteLine("│                                         └───────────────────────────────┘                                           │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │          VERY FAST [V]        │                                           │");
            Console.WriteLine("│                                         └───────────────────────────────┘                                           │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │            FAST [F]           │                                           │");
            Console.WriteLine("│                                         └───────────────────────────────┘                                           │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │           NORMAL [N]          │                                           │");
            Console.WriteLine("│                                         └───────────────────────────────┘                                           │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │            SLOW [S]           │                                           │");
            Console.WriteLine("│                                         └───────────────────────────────┘                                           │");
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
                    case 'U':
                    case 'u':
                        {
                            firstOpen.SetSpeed(125);
                            Console.Clear();
                            options.Setup();
                            break;
                        }
                    case 'V':
                    case 'v':
                        {
                            firstOpen.SetSpeed(250);
                            Console.Clear();
                            options.Setup();
                            break;
                        }

                    case 'F':
                    case 'f':
                        {
                            firstOpen.SetSpeed(500);
                            Console.Clear();
                            Setup();
                            break;
                        }
                    case 'N':
                    case 'n':
                        {
                            firstOpen.SetSpeed(1000);
                            Console.Clear();
                            Setup();
                            break;
                        }
                    case 'S':
                    case 's':
                        {
                            firstOpen.SetSpeed(2000);
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
