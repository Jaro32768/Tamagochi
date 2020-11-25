using System;

namespace Tamagochi
{
    class Color //not done yet
    {
        private static string colors = "Green";
        /// <summary>
        /// This method sets up console for color pick view.
        /// </summary>
        public void Setup()
        {
            Options options = new Options();
            Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │           GREEN [G]           │                                           │");
            Console.WriteLine("│                                         └───────────────────────────────┘                                           │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │           YELLOW [Y]          │                                           │");
            Console.WriteLine("│                                         └───────────────────────────────┘                                           │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │            RED [R]            │                                           │");
            Console.WriteLine("│                                         └───────────────────────────────┘                                           │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │           WHITE [W]           │                                           │");
            Console.WriteLine("│                                         └───────────────────────────────┘                                           │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │            BLUE [B]           │                                           │");
            Console.WriteLine("│                                         └───────────────────────────────┘                                           │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │            BACK [X]           │                                           │");
            Console.WriteLine("│                                         └───────────────────────────────┘                                           │");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
            bool loop = true;
            while (loop)
            {
                switch (Convert.ToChar(Console.Read()))
                {
                    case 'G':
                    case 'g':
                        {
                            loop = !loop;
                            colors = "Green";
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Clear();
                            Setup();
                            break;
                        }
                    case 'Y':
                    case 'y':
                        {
                            loop = !loop;
                            colors = "Yellow";
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Clear();
                            Setup();
                            break;
                        }
                    case 'R':
                    case 'r':
                        {
                            loop = !loop;
                            colors = "Red";
                            Console.WriteLine(colors);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Setup();
                            break;
                        }
                    case 'W':
                    case 'w':
                        {
                            loop = !loop;
                            colors = "White";
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Setup();
                            break;
                        }
                    case 'B':
                    case 'b':
                        {
                            loop = !loop;
                            colors = "Blue";
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Clear();
                            Setup();
                            break;
                        }
                    case 'X':
                    case 'x':
                        {
                            loop = !loop;
                            Console.Clear();
                            options.Setup();
                            break;
                        }
                }
            }
        }
        /// <summary>
        /// This method returns color picked in settings.
        /// </summary>
        /// <returns></returns>
        public string GetColor()
        {
            return colors;
        }
        /// <summary>
        /// This method sets value of color.
        /// </summary>
        public void SetColor(string color)
        {
            colors = color;
            switch(color)
            {
                case "Green":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    }
                case "Yellow":
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        break;
                    }
                case "Red":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        break;
                    }
                case "White":
                    {
                        Console.ForegroundColor = ConsoleColor.White;

                        break;
                    }
                case "Blue":
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;

                        break;
                    }
                default:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        break;
                    }
            }
        }
    }
}
