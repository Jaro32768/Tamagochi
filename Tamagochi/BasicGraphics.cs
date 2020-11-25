using System;

namespace Tamagochi
{
    class BasicGraphics
    {

        private static int animalNumber = 1;
        private static string animalName = "";
        /// <summary>
        /// This method sets up animal name for future usage.
        /// </summary>
        /// <param name="animalName"></param>
        public void SetAnimalName(string name)
        {
            animalName = name;
            Setup();
        }
        /// <summary>
        /// This method sets up console for ingame view.
        /// </summary>
        public void Setup()
        {
            Color color = new Color();
            Save save = new Save();
            Walking fitnessStat = new Walking();
            Sleeping energyStat = new Sleeping();
            Playing happinessStat = new Playing();
            Hygiene hygieneStat = new Hygiene();
            Food satietyStat = new Food();
            Menu menu = new Menu();
            DeathScreen deathScreen = new DeathScreen();
            string colors = color.GetColor();
            string energy = energyStat.GetEnergyStat().ToString() + "%";
            string hygiene = hygieneStat.GetHygieneStat().ToString() + "%";
            string happiness = happinessStat.GetHappinessStat().ToString() + "%";
            string fitness = fitnessStat.GetFitnessStat().ToString() + "%";
            string satiety = satietyStat.GetSatietyStat().ToString() + "%";
            if (energyStat.GetEnergyStat() == 0 || hygieneStat.GetHygieneStat() == 0 || happinessStat.GetHappinessStat() == 0 || fitnessStat.GetFitnessStat() == 0 || satietyStat.GetSatietyStat() == 0)
            {
                deathScreen.Setup();
            }
            else
            {
                Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                Console.WriteLine("│ ┌────────────────────────────────┐ ┌────────────────────┬──────────────────────────────────────────────────┬──────┐ │");
                Console.Write("│ │                                │ │     ENERGY [E]     │");
                for (int i = 0; i < (energyStat.GetEnergyStat() / 2); i++)
                {
                    switch (colors)
                    {
                        case "Green":
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                            }
                        case "Yellow":
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                break;
                            }
                        case "Red":
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                break;
                            }
                        case "White":
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                break;
                            }
                        case "Blue":
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                break;
                            }
                        default:
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                            }
                    }
                    Console.Write(" ");
                }
                for (int i = 0; i < 50 - (energyStat.GetEnergyStat() / 2); i++)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(" ");

                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("│");
                for (int i = 0; i < 3 - (energy.Length / 2); i++)
                {
                    if (i == 0 && energy.Length % 2 == 1)
                    {

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write(energy);
                for (int i = 0; i < 3 - (energy.Length / 2); i++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("│ │");
                Console.WriteLine("│ │                                │ └────────────────────┴──────────────────────────────────────────────────┴──────┘ │");
                Console.WriteLine("│ │                                │ ┌────────────────────┬──────────────────────────────────────────────────┬──────┐ │");
                Console.Write("│ │                                │ │     HYGIENE [H]    │");
                for (int i = 0; i < (hygieneStat.GetHygieneStat() / 2); i++)
                {
                    switch (colors)
                    {
                        case "Green":
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                            }
                        case "Yellow":
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                break;
                            }
                        case "Red":
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                break;
                            }
                        case "White":
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                break;
                            }
                        case "Blue":
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                break;
                            }
                        default:
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                            }
                    }
                    Console.Write(" ");
                }
                for (int i = 0; i < 50 - (hygieneStat.GetHygieneStat() / 2); i++)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(" ");

                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("│");
                for (int i = 0; i < 3 - (hygiene.Length / 2); i++)
                {
                    if (i == 0 && hygiene.Length % 2 == 1)
                    {

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write(hygiene);
                for (int i = 0; i < 3 - (hygiene.Length / 2); i++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("│ │");
                Console.WriteLine("│ │                                │ └────────────────────┴──────────────────────────────────────────────────┴──────┘ │");
                Console.WriteLine("│ │                                │ ┌────────────────────┬──────────────────────────────────────────────────┬──────┐ │");
                Console.Write("│ │                                │ │       FUN [F]      │");
                for (int i = 0; i < (happinessStat.GetHappinessStat() / 2); i++)
                {
                    switch (colors)
                    {
                        case "Green":
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                            }
                        case "Yellow":
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                break;
                            }
                        case "Red":
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                break;
                            }
                        case "White":
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                break;
                            }
                        case "Blue":
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                break;
                            }
                        default:
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                            }
                    }
                    Console.Write(" ");
                }
                for (int i = 0; i < 50 - (happinessStat.GetHappinessStat() / 2); i++)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(" ");

                }
                Console.BackgroundColor = ConsoleColor.Black;

                Console.Write("│");
                for (int i = 0; i < 3 - (happiness.Length / 2); i++)
                {
                    if (i == 0 && happiness.Length % 2 == 1)
                    {

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write(happiness);
                for (int i = 0; i < 3 - (happiness.Length / 2); i++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("│ │");
                Console.WriteLine("│ │                                │ └────────────────────┴──────────────────────────────────────────────────┴──────┘ │");
                Console.WriteLine("│ │                                │ ┌────────────────────┬──────────────────────────────────────────────────┬──────┐ │");
                Console.Write("│ │                                │ │     WALKING [W]    │");
                for (int i = 0; i < (fitnessStat.GetFitnessStat() / 2); i++)
                {
                    switch (colors)
                    {
                        case "Green":
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                            }
                        case "Yellow":
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                break;
                            }
                        case "Red":
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                break;
                            }
                        case "White":
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                break;
                            }
                        case "Blue":
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                break;
                            }
                        default:
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                            }
                    }
                    Console.Write(" ");
                }
                for (int i = 0; i < 50 - (fitnessStat.GetFitnessStat() / 2); i++)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(" ");

                }
                Console.BackgroundColor = ConsoleColor.Black;

                Console.Write("│");
                for (int i = 0; i < 3 - (fitness.Length / 2); i++)
                {
                    if (i == 0 && fitness.Length % 2 == 1)
                    {

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write(fitness);
                for (int i = 0; i < 3 - (fitness.Length / 2); i++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("│ │");
                Console.WriteLine("│ │                                │ └────────────────────┴──────────────────────────────────────────────────┴──────┘ │");
                Console.WriteLine("│ │                                │ ┌────────────────────┬──────────────────────────────────────────────────┬──────┐ │");
                Console.Write("│ │                                │ │     SATIETY [T]    │");
                for (int i = 0; i < (satietyStat.GetSatietyStat() / 2); i++)
                {
                    switch (colors)
                    {
                        case "Green":
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                            }
                        case "Yellow":
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                break;
                            }
                        case "Red":
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                break;
                            }
                        case "White":
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                break;
                            }
                        case "Blue":
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                break;
                            }
                        default:
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                            }
                    }
                    Console.Write(" ");
                }
                for (int i = 0; i < 50 - (satietyStat.GetSatietyStat() / 2); i++)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(" ");

                }
                Console.BackgroundColor = ConsoleColor.Black;

                Console.Write("│");
                for (int i = 0; i < 3 - (satiety.Length / 2); i++)
                {
                    if (i == 0 && satiety.Length % 2 == 1)
                    {

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write(satiety);
                for (int i = 0; i < 3 - (satiety.Length / 2); i++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("│ │");
                Console.WriteLine("│ │                                │ └────────────────────┴──────────────────────────────────────────────────┴──────┘ │");
                Console.WriteLine("│ │                                │ Press [R] to refresh status.                                                     │");
                Console.Write("│ │                                │  ");


                Console.WriteLine("                                                                                │");
                Console.WriteLine("│ ├────────────────────────────────┤ ┌───────────────────────────────┐              ┌───────────────────────────────┐ │");
                Console.Write("│ │");
                for (int i = 0; i < 16 - (animalName.Length / 2); i++)
                {
                    if (i == 0 && animalName.Length % 2 == 1)
                    {

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write(animalName);
                for (int i = 0; i < 16 - (animalName.Length / 2); i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("│ │            SAVE [S]           │              │            EXIT [X]           │ │");
                Console.WriteLine("│ └────────────────────────────────┘ └───────────────────────────────┘              └───────────────────────────────┘ │");
                Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
            }
            WriteAnimal();
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

                            save.Setup();
                            break;
                        }
                    case 'X':
                    case 'x':
                        {
                            Console.Clear();
                            menu.Setup();
                            break;
                        }
                    case 'R':
                    case 'r':
                        {
                            Console.SetCursorPosition(0, 0);
                            Setup();
                            break;
                        }
                    case 'E':
                    case 'e':
                        {
                            Console.Clear();
                            energyStat.EnergyIntro();
                            break;
                        }
                    case 'H':
                    case 'h':
                        {
                            Console.Clear();
                            hygieneStat.HygieneIntro();
                            break;
                        }
                    case 'F':
                    case 'f':
                        {
                            Console.Clear();
                            happinessStat.HappinsessIntro();
                            break;
                        }
                    case 'W':
                    case 'w':
                        {
                            Console.Clear();
                            fitnessStat.FitnessIntro();
                            break;
                        }
                    case 'T':
                    case 't':
                        {
                            Console.Clear();
                            satietyStat.FoodIntro();
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
        /// <summary>
        /// This method sets user's pick of animal.
        /// </summary>
        /// <param name="animalNumber1"></param>
        public void SetAnimal(int animalNumber1)
        {
            animalNumber = animalNumber1;
        }
        /// <summary>
        /// This method rerurns user's pick of animal.
        /// </summary>
        /// <returns></returns>
        public int GetAnimal()
        {
            return animalNumber;
        }
        /// <summary>
        /// This method writes animal on console.
        /// </summary>
        public void WriteAnimal()
        {

            switch (animalNumber)
            {
                case 1:
                    {
                        Console.SetCursorPosition(3, 3);
                        Console.WriteLine(@"    =/\                 /\=");
                        Console.SetCursorPosition(3, 4);
                        Console.WriteLine(@"    / \'._   (\_/)   _.'/ \");
                        Console.SetCursorPosition(3, 5);
                        Console.WriteLine(@"   / .''._'--(o.o)--'_.''. \");
                        Console.SetCursorPosition(3, 6);
                        Console.WriteLine(@"  /.' _/ |`'=/   \= '`| \_ `.\");
                        Console.SetCursorPosition(3, 7);
                        Console.WriteLine(@" /` .' `\;-,'\___/',-;/` '. '\");
                        Console.SetCursorPosition(3, 8);
                        Console.WriteLine(@"/.-'       `\(-V-)/`       `-.\");
                        Console.SetCursorPosition(3, 9);
                        Console.WriteLine(@"`           ''   ''            `");
                        break;
                    }
                case 2:
                    {

                        Console.SetCursorPosition(8, 8);
                        Console.WriteLine(@" .--.              .--.");
                        Console.SetCursorPosition(8, 9);
                        Console.WriteLine(@": (\ '. _......_ .' /) :");
                        Console.SetCursorPosition(8, 10);
                        Console.WriteLine(@" '.    `        `    .'");
                        Console.SetCursorPosition(8, 11);
                        Console.WriteLine(@"  /'   _        _   `\");
                        Console.SetCursorPosition(8, 12);
                        Console.WriteLine(@" /     0}      {0     \");
                        Console.SetCursorPosition(8, 13);
                        Console.WriteLine(@"|       /      \       |");
                        Console.SetCursorPosition(8, 14);
                        Console.WriteLine(@"|     /'        `\     |");
                        Console.SetCursorPosition(8, 15);
                        Console.WriteLine(@" \   | .  .==.  . |   /");
                        Console.SetCursorPosition(8, 16);
                        Console.WriteLine(@"  '._ \.' \__/ './ _.'");
                        Console.SetCursorPosition(8, 17);
                        Console.WriteLine(@" /  ``'._-''-_.'``  \");
                        break;
                    }
                case 3:
                    {

                        Console.SetCursorPosition(6, 7);
                        Console.WriteLine(@"           __,__");
                        Console.SetCursorPosition(6, 8);
                        Console.WriteLine(@"  .--.  .-'     '-.  .--.");
                        Console.SetCursorPosition(6, 9);
                        Console.WriteLine(@" / .. \/  .-. .-.  \/ .. \");
                        Console.SetCursorPosition(6, 10);
                        Console.WriteLine(@"| |  '|  /   Y   \  |'  | |");
                        Console.SetCursorPosition(6, 11);
                        Console.WriteLine(@"| \   \  \ 0 | 0 /  /   / |");
                        Console.SetCursorPosition(6, 12);
                        Console.WriteLine(@" \ '- ,\.-'`` ``'-./, -' /");
                        Console.SetCursorPosition(6, 13);
                        Console.WriteLine(@"  `'-' /_   ^ ^   _\ '-'`");
                        Console.SetCursorPosition(6, 14);
                        Console.WriteLine(@"      |  \._   _./  |");
                        Console.SetCursorPosition(6, 15);
                        Console.WriteLine(@"      \   \ `~` /   /");
                        Console.SetCursorPosition(6, 16);
                        Console.WriteLine(@"       '._ '-=-' _.'");
                        Console.SetCursorPosition(6, 17);
                        Console.WriteLine(@"          '~---~'");
                        break;
                    }
                case 4:
                    {
                        Console.SetCursorPosition(4, 6);
                        Console.WriteLine(@"          ,-.___.-.");
                        Console.SetCursorPosition(4, 7);
                        Console.WriteLine(@"       ,-.(|)   (|),-.");
                        Console.SetCursorPosition(4, 8);
                        Console.WriteLine(@"       \_*._ ' '_.* _/");
                        Console.SetCursorPosition(4, 9);
                        Console.WriteLine(@"        /`-.`--' .-'\");
                        Console.SetCursorPosition(4, 10);
                        Console.WriteLine(@"   ,--./    `---'    \,--.");
                        Console.SetCursorPosition(4, 11);
                        Console.WriteLine(@"   \   |(  )     (  )|   /");
                        Console.SetCursorPosition(4, 12);
                        Console.WriteLine(@"    \  | ||       || |  /");
                        Console.SetCursorPosition(4, 13);
                        Console.WriteLine(@"     \ | /|\     /|\ | /");
                        Console.SetCursorPosition(4, 14);
                        Console.WriteLine(@"     /  \-._     _,-/  \");
                        Console.SetCursorPosition(4, 15);
                        Console.WriteLine(@"    //| \\  `---'  // |\\");
                        Console.SetCursorPosition(4, 16);
                        Console.WriteLine(@"   /,-.,-.\       /,-.,-.\");
                        Console.SetCursorPosition(4, 17);
                        Console.WriteLine(@"  o   o   o      o   o    o");
                        break;
                    }
                case 5:
                    {

                        Console.SetCursorPosition(8, 4);
                        Console.WriteLine(@"        ▄▀▀▀▀▀▀▀▄");
                        Console.SetCursorPosition(8, 5);
                        Console.WriteLine(@"       █▒▒▒▒▒▒▒▒▒█");
                        Console.SetCursorPosition(8, 6);
                        Console.WriteLine(@"      ▄▀▒▒▒▒▒▒▒▒▄▀");
                        Console.SetCursorPosition(8, 7);
                        Console.WriteLine(@"     █▒▒▒▒▒▒▒▒▒▒█");
                        Console.SetCursorPosition(8, 8);
                        Console.WriteLine(@"    ▄▀▒▄▄▄▒▄▄▄▒▒█");
                        Console.SetCursorPosition(8, 9);
                        Console.WriteLine(@"    █▒▒─▀─▒─▀─▒▒█");
                        Console.SetCursorPosition(8, 10);
                        Console.WriteLine(@"    █▒▒▒▒▒▒▒▒▒▒▒█");
                        Console.SetCursorPosition(8, 11);
                        Console.WriteLine(@"   ▄▀▒▒▒▀▄▄▄▀▒▒▒▒▀▀▄");
                        Console.SetCursorPosition(8, 12);
                        Console.WriteLine(@" ▄▀▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▀▄");
                        Console.SetCursorPosition(8, 13);
                        Console.WriteLine(@"█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒█");
                        Console.SetCursorPosition(8, 14);
                        Console.WriteLine(@"▀▄▀▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▀▄▀");
                        Console.SetCursorPosition(8, 15);
                        Console.WriteLine(@"  █▌▌▌▌▌▌▌▌▌▌▌▌▌▌▌▌█");
                        Console.SetCursorPosition(8, 16);
                        Console.WriteLine(@"  ▀█▌▌▌▌▌▌▌▌▌▌▌▌▌▌█▀");
                        Console.SetCursorPosition(8, 17);
                        Console.WriteLine(@"    █▒▒▌▌▌▌▌▌▌▌▌▒▒█");
                        Console.SetCursorPosition(8, 18);
                        Console.WriteLine(@"─────▀▀─────────▀▀");
                        break;
                    }
            }
            Console.SetCursorPosition(0, 22);
        }
    }
}
