using System;
using System.IO;
using System.Text;

namespace Tamagochi
{
    class Save
    {
        /// <summary>
        /// This method sets up console for load view.
        /// </summary>
        public void Setup() //not done yet
        {
            BasicGraphics basicGraphics = new BasicGraphics();
            FirstOpen firstOpen = new FirstOpen();
            Color color = new Color();
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
                            if (File.Exists(path1))
                            {
                                File.Delete(path1);
                            }
                            using (FileStream fileStream = File.Create(path1))
                            {
                                AddText(fileStream, $"{color.GetColor()}\n");
                                AddText(fileStream, $"{firstOpen.GetAnimalName()}\n");
                                AddText(fileStream, $"{firstOpen.GetDifficulty()}\n");
                                AddText(fileStream, $"{firstOpen.GetSpeed()}\n");
                                AddText(fileStream, $"{firstOpen.GetDays()}\n");
                                AddText(fileStream, $"{firstOpen.GetHours()}\n");
                                AddText(fileStream, $"{firstOpen.GetMinutes()}\n");
                                AddText(fileStream, $"{firstOpen.GetSeconds()}\n");
                                AddText(fileStream, $"{fitnessStat.GetFitnessStat()}\n");
                                AddText(fileStream, $"{energyStat.GetEnergyStat()}\n");
                                AddText(fileStream, $"{happinessStat.GetHappinessStat()}\n");
                                AddText(fileStream, $"{hygieneStat.GetHygieneStat()}\n");
                                AddText(fileStream, $"{satietyStat.GetSatietyStat()}\n");
                                AddText(fileStream, $"{basicGraphics.GetAnimal()}\n");
                                AddText(fileStream, $"{hygieneStat.GetHygieneStatus()}\n");
                                AddText(fileStream, $"{firstOpen.GetWalkingStatus()}\n");
                            }
                            Console.Clear();
                            Setup();
                            break;
                        }
                    case '2':
                        {
                            if (File.Exists(path2))
                            {
                                File.Delete(path2);
                            }
                            using (FileStream fileStream = File.Create(path2))
                            {
                                AddText(fileStream, $"{color.GetColor()}\n");
                                AddText(fileStream, $"{firstOpen.GetAnimalName()}\n");
                                AddText(fileStream, $"{firstOpen.GetDifficulty()}\n");
                                AddText(fileStream, $"{firstOpen.GetSpeed()}\n");
                                AddText(fileStream, $"{firstOpen.GetDays()}\n");
                                AddText(fileStream, $"{firstOpen.GetHours()}\n");
                                AddText(fileStream, $"{firstOpen.GetMinutes()}\n");
                                AddText(fileStream, $"{firstOpen.GetSeconds()}\n");
                                AddText(fileStream, $"{fitnessStat.GetFitnessStat()}\n");
                                AddText(fileStream, $"{energyStat.GetEnergyStat()}\n");
                                AddText(fileStream, $"{happinessStat.GetHappinessStat()}\n");
                                AddText(fileStream, $"{hygieneStat.GetHygieneStat()}\n");
                                AddText(fileStream, $"{satietyStat.GetSatietyStat()}\n");
                                AddText(fileStream, $"{basicGraphics.GetAnimal()}\n");
                                AddText(fileStream, $"{hygieneStat.GetHygieneStatus()}\n");
                                AddText(fileStream, $"{firstOpen.GetWalkingStatus()}\n");
                            }
                            Console.Clear();
                            Setup();
                            break;
                        }
                    case '3':
                        {
                            if (File.Exists(path3))
                            {
                                File.Delete(path3);
                            }
                            using (FileStream fileStream = File.Create(path3))
                            {
                                AddText(fileStream, $"{color.GetColor()}\n");
                                AddText(fileStream, $"{firstOpen.GetAnimalName()}\n");
                                AddText(fileStream, $"{firstOpen.GetDifficulty()}\n");
                                AddText(fileStream, $"{firstOpen.GetSpeed()}\n");
                                AddText(fileStream, $"{firstOpen.GetDays()}\n");
                                AddText(fileStream, $"{firstOpen.GetHours()}\n");
                                AddText(fileStream, $"{firstOpen.GetMinutes()}\n");
                                AddText(fileStream, $"{firstOpen.GetSeconds()}\n");
                                AddText(fileStream, $"{fitnessStat.GetFitnessStat()}\n");
                                AddText(fileStream, $"{energyStat.GetEnergyStat()}\n");
                                AddText(fileStream, $"{happinessStat.GetHappinessStat()}\n");
                                AddText(fileStream, $"{hygieneStat.GetHygieneStat()}\n");
                                AddText(fileStream, $"{satietyStat.GetSatietyStat()}\n");
                                AddText(fileStream, $"{basicGraphics.GetAnimal()}\n");
                                AddText(fileStream, $"{hygieneStat.GetHygieneStatus()}\n");
                                AddText(fileStream, $"{firstOpen.GetWalkingStatus()}\n");
                            }
                            Console.Clear();
                            Setup();
                            break;
                        }
                    case 'X':
                    case 'x':
                        {
                            Console.Clear();
                            basicGraphics.Setup();
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
        /// This method writes data to file.
        /// </summary>
        /// <param name="fileStream"></param>
        /// <param name="value"></param>
        private static void AddText(FileStream fileStream, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fileStream.Write(info, 0, info.Length);
        }
    }
}
