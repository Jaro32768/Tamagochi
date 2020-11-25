using System;

namespace Tamagochi
{
    class Menu
    {
        /// <summary>
        /// This method sets up console for menu view.
        /// </summary>
        public void Setup()
        {
            Credits credits = new Credits();
            HowToPlay howToPlay = new HowToPlay();
            FirstOpen firstOpen = new FirstOpen();
            Load load = new Load();
            Options options = new Options();
            Walking fitnessStat = new Walking();
            Sleeping energyStat = new Sleeping();
            Playing happinessStat = new Playing();
            Food satietyStat = new Food();
            Hygiene hygieneStat = new Hygiene();
            Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │           NEW GAME [N]        │                                           │");
            Console.WriteLine("│                                         └───────────────────────────────┘                                           │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │          LOAD GAME [L]        │                                           │");
            Console.WriteLine("│                                         └───────────────────────────────┘                                           │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │           OPTIONS [O]         │                                           │");
            Console.WriteLine("│                                         └───────────────────────────────┘                                           │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │           CREDITS [C]         │                                           │");
            Console.WriteLine("│                                         └───────────────────────────────┘                                           │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │        HOW TO PLAY [H]        │                                           │");
            Console.WriteLine("│                                         └───────────────────────────────┘                                           │");
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
                    case 'C':
                    case 'c':
                        {
                            Console.Clear();
                            credits.Setup();
                            break;
                        }
                    case 'N':
                    case 'n':
                        {
                            Console.Clear();
                            firstOpen.ResetAnimalName();
                            firstOpen.ResetTime();
                            fitnessStat.ResetFitnessStat();
                            energyStat.ResetEnergyStat();
                            happinessStat.ResetHappinessStat();
                            satietyStat.ResetSatietyStat();
                            hygieneStat.ResetHygieneStat();
                            firstOpen.FirstOpenSetup();
                            break;
                        }
                    case 'L':
                    case 'l':
                        {
                            Console.Clear();
                            load.Setup();
                            break;
                        }
                    case 'O':
                    case 'o':
                        {
                            Console.Clear();
                            options.Setup();
                            break;
                        }
                    case 'H':
                    case 'h':
                        {
                            Console.Clear();
                            howToPlay.Setup();
                            break;
                        }
                    case 'X':
                    case 'x':
                        {
                            Environment.Exit(0);
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
