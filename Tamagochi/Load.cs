using System;
using System.IO;
using System.Text;

namespace Tamagochi
{
    class Load
    {
        /// <summary>
        /// This method sets up console for load view.
        /// </summary>
        public void Setup() //not done yet
        {
            Menu menu = new Menu();
            BasicGraphics basicGraphics = new BasicGraphics();
            Color color = new Color();
            FirstOpen firstOpen = new FirstOpen();
            Walking fitnessStat = new Walking();
            Sleeping energyStat = new Sleeping();
            Playing happinessStat = new Playing();
            Hygiene hygieneStat = new Hygiene();
            Food satietyStat = new Food();
            string path1 = @"C:\save1.txt";
            string path2 = @"C:\save2.txt";
            string path3 = @"C:\save3.txt";
            Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│                                                                                                                     │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │           SAVE 1 [1]          │                                           │");
            Console.WriteLine("│                                         └───────────────────────────────┘                                           │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │           SAVE 2 [2]          │                                           │");
            Console.WriteLine("│                                         └───────────────────────────────┘                                           │");
            Console.WriteLine("│                                         ┌───────────────────────────────┐                                           │");
            Console.WriteLine("│                                         │           SAVE 3 [3]          │                                           │");
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
                    case '1':
                        {
                            using (StreamReader streamReader = new StreamReader(path1))
                            {
                                byte[] b = new byte[1024];
                                UTF8Encoding temp = new UTF8Encoding(true);
                                color.SetColor(streamReader.ReadLine());
                                firstOpen.SetAnimalName(streamReader.ReadLine());
                                firstOpen.SetDifficulty(Convert.ToInt32(streamReader.ReadLine()));
                                firstOpen.SetSpeed(Convert.ToInt32(streamReader.ReadLine()));
                                firstOpen.SetDays(Convert.ToInt32(streamReader.ReadLine()));
                                firstOpen.SetHours(Convert.ToInt32(streamReader.ReadLine()));
                                firstOpen.SetMinutes(Convert.ToInt32(streamReader.ReadLine()));
                                firstOpen.SetSeconds(Convert.ToInt32(streamReader.ReadLine()));
                                fitnessStat.SetFitnessStat(Convert.ToInt32(streamReader.ReadLine()));
                                energyStat.SetEnergyStat(Convert.ToInt32(streamReader.ReadLine()));
                                happinessStat.SetHappinessStat(Convert.ToInt32(streamReader.ReadLine()));
                                hygieneStat.SetHygieneStat(Convert.ToInt32(streamReader.ReadLine()));
                                satietyStat.SetSatietyStat(Convert.ToInt32(streamReader.ReadLine()));
                                basicGraphics.SetAnimal(Convert.ToInt32(streamReader.ReadLine()));
                                if (streamReader.ReadLine().ToLower() == "true")
                                {
                                    hygieneStat.SetHygieneToDone();
                                }
                                else
                                {
                                    hygieneStat.SetHygieneToNotDone();
                                }
                                if (streamReader.ReadLine().ToLower() == "true")
                                {
                                    firstOpen.SetWalkingToDone();
                                }
                                else
                                {
                                    firstOpen.SetWalkingToNotDone();
                                }
                            }
                            Console.Clear();
                            firstOpen.FirstOpenSetup();
                            break;
                        }
                    case '2':
                        {
                            using (StreamReader streamReader = new StreamReader(path2))
                            {
                                byte[] b = new byte[1024];
                                UTF8Encoding temp = new UTF8Encoding(true);
                                color.SetColor(streamReader.ReadLine());
                                firstOpen.SetAnimalName(streamReader.ReadLine());
                                firstOpen.SetDifficulty(Convert.ToInt32(streamReader.ReadLine()));
                                firstOpen.SetSpeed(Convert.ToInt32(streamReader.ReadLine()));
                                firstOpen.SetDays(Convert.ToInt32(streamReader.ReadLine()));
                                firstOpen.SetHours(Convert.ToInt32(streamReader.ReadLine()));
                                firstOpen.SetMinutes(Convert.ToInt32(streamReader.ReadLine()));
                                firstOpen.SetSeconds(Convert.ToInt32(streamReader.ReadLine()));
                                fitnessStat.SetFitnessStat(Convert.ToInt32(streamReader.ReadLine()));
                                energyStat.SetEnergyStat(Convert.ToInt32(streamReader.ReadLine()));
                                happinessStat.SetHappinessStat(Convert.ToInt32(streamReader.ReadLine()));
                                hygieneStat.SetHygieneStat(Convert.ToInt32(streamReader.ReadLine()));
                                satietyStat.SetSatietyStat(Convert.ToInt32(streamReader.ReadLine()));
                                basicGraphics.SetAnimal(Convert.ToInt32(streamReader.ReadLine()));
                                if (streamReader.ReadLine().ToLower() == "true")
                                {
                                    hygieneStat.SetHygieneToDone();
                                }
                                else
                                {
                                    hygieneStat.SetHygieneToNotDone();
                                }
                                if (streamReader.ReadLine().ToLower() == "true")
                                {
                                    firstOpen.SetWalkingToDone();
                                }
                                else
                                {
                                    firstOpen.SetWalkingToNotDone();
                                }
                            }
                            Console.Clear();
                            firstOpen.FirstOpenSetup();
                            break;
                        }
                    case '3':
                        {
                            using (StreamReader streamReader = new StreamReader(path3))
                            {
                                byte[] b = new byte[1024];
                                UTF8Encoding temp = new UTF8Encoding(true);
                                color.SetColor(streamReader.ReadLine());
                                firstOpen.SetAnimalName(streamReader.ReadLine());
                                firstOpen.SetDifficulty(Convert.ToInt32(streamReader.ReadLine()));
                                firstOpen.SetSpeed(Convert.ToInt32(streamReader.ReadLine()));
                                firstOpen.SetDays(Convert.ToInt32(streamReader.ReadLine()));
                                firstOpen.SetHours(Convert.ToInt32(streamReader.ReadLine()));
                                firstOpen.SetMinutes(Convert.ToInt32(streamReader.ReadLine()));
                                firstOpen.SetSeconds(Convert.ToInt32(streamReader.ReadLine()));
                                fitnessStat.SetFitnessStat(Convert.ToInt32(streamReader.ReadLine()));
                                energyStat.SetEnergyStat(Convert.ToInt32(streamReader.ReadLine()));
                                happinessStat.SetHappinessStat(Convert.ToInt32(streamReader.ReadLine()));
                                hygieneStat.SetHygieneStat(Convert.ToInt32(streamReader.ReadLine()));
                                satietyStat.SetSatietyStat(Convert.ToInt32(streamReader.ReadLine()));
                                basicGraphics.SetAnimal(Convert.ToInt32(streamReader.ReadLine()));
                                if (streamReader.ReadLine().ToLower() == "true")
                                {
                                    hygieneStat.SetHygieneToDone();
                                }
                                else
                                {
                                    hygieneStat.SetHygieneToNotDone();
                                }
                                if (streamReader.ReadLine().ToLower() == "true")
                                {
                                    firstOpen.SetWalkingToDone();
                                }
                                else
                                {
                                    firstOpen.SetWalkingToNotDone();
                                }
                            }
                            Console.Clear();
                            firstOpen.FirstOpenSetup();
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
