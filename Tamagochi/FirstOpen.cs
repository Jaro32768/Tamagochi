using System;
using System.Threading;

namespace Tamagochi
{
    /// <summary>
    /// This method sets up console for first open view.
    /// </summary>
    class FirstOpen
    {

        private static bool walkingDone = false;
        private static int sec = -1;
        private static int min = 0;
        private static int hour = 0;
        private static int day = 0;
        private static int gameDifficulty = 1;
        private static int gameSpeed = 1000;
        private static string animalName;
        public void FirstOpenSetup()
        {
            Walking fitnessStat = new Walking();
            Sleeping energyStat = new Sleeping();
            Playing happinessStat = new Playing();
            Food satietyStat = new Food();
            Hygiene hygieneStat = new Hygiene();
            BasicGraphics basicGraphics = new BasicGraphics();
            DeathScreen deathScreen = new DeathScreen();
            if (animalName == "+ľščťžýáíé+ľščťžýáíé+ľščťžýáíé")
            {
                Console.Write("Enter name of your animal with max lenght 32 characters: ");
                Console.ReadLine();
                animalName = Console.ReadLine();
                if (animalName.Length > 32)
                {
                    animalName = animalName.Substring(0, 32);
                }
                Console.Write("Pick your animal! (bat/bear/monkey/frog/patrick)");
                switch(Console.ReadLine().ToLower())
                {
                    case "bat":
                        {
                            basicGraphics.SetAnimal(1);
                            break;
                        }
                    case "bear":
                        {
                            basicGraphics.SetAnimal(2);
                            break;
                        }
                    case "monkey":
                        {
                            basicGraphics.SetAnimal(3);
                            break;
                        }
                    case "frog":
                        {
                            basicGraphics.SetAnimal(4);
                            break;
                        }
                    case "patrick":
                        {
                            basicGraphics.SetAnimal(5);
                            break;
                        }
                    default:
                        {
                            basicGraphics.SetAnimal(1);
                            break;
                        }

                }
                Console.Clear();
            }
            new Thread(() =>
            {


                while (true)
                {
                    Thread.Sleep(gameSpeed);
                    sec++;
                    if (sec == 60)
                    {
                        sec = 0;
                        min++;
                    }
                    if (min == 60)
                    {
                        min = 0;
                        hour++;
                    }
                    if (hour == 24)
                    {
                        hour = 0;
                        day++;
                        if (walkingDone == false)
                        {
                            satietyStat.MinusSatietyStat(20);
                            happinessStat.MinusHappinessStat(20);
                            energyStat.MinusEnergyStat(20);
                            fitnessStat.MinusFitnessStat(20);
                            hygieneStat.MinusHygieneStat(20);
                        }
                        SetWalkingToNotDone();
                    }
                }
            }).Start();
            new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(gameSpeed * 3600);
                    if (gameDifficulty == 0)
                    {
                        satietyStat.MinusSatietyStat(5);
                        happinessStat.MinusHappinessStat(3);
                        energyStat.MinusEnergyStat(3);
                        fitnessStat.MinusFitnessStat(2);
                        hygieneStat.MinusHygieneStat(2);
                    }
                    else if (gameDifficulty == 1)
                    {
                        satietyStat.MinusSatietyStat(10);
                        happinessStat.MinusHappinessStat(6);
                        energyStat.MinusEnergyStat(6);
                        fitnessStat.MinusFitnessStat(4);
                        hygieneStat.MinusHygieneStat(4);
                    }
                    else
                    {
                        satietyStat.MinusSatietyStat(20);
                        happinessStat.MinusHappinessStat(12);
                        energyStat.MinusEnergyStat(12);
                        fitnessStat.MinusFitnessStat(8);
                        hygieneStat.MinusHygieneStat(8);
                    }
                }
            }).Start();
            basicGraphics.SetAnimalName(animalName);
        }
        /// <summary>
        /// This method returns difficulty level.
        /// </summary>
        /// <returns></returns>
        public int GetDifficulty()
        {
            return gameDifficulty;
        }
        /// <summary>
        /// This method sets up difficulty level.
        /// </summary>
        /// <param name="difficulty"></param>
        public void SetDifficulty(int difficulty)
        {
            gameDifficulty = difficulty;
        }
        /// <summary>
        /// This method returns speed level.
        /// </summary>
        /// <returns></returns>
        public int GetSpeed()
        {
            return gameSpeed;
        }
        /// <summary>
        /// This method sets up speed level.
        /// </summary>
        /// <param name="speed"></param>
        public void SetSpeed(int speed)
        {
            gameSpeed = speed;
        }
        /// <summary>
        /// This method adds hours to current time.
        /// </summary>
        /// <param name="hours"></param>
        public void AddHours(int hours)
        {
            hour += hours;
        }
        /// <summary>
        /// This method returns number of days.
        /// </summary>
        /// <returns></returns>
        public int GetDays()
        {
            return day;
        }
        /// <summary>
        /// This method returns number of hours.
        /// </summary>
        /// <returns></returns>
        public int GetHours()
        {
            return hour;
        }
        /// <summary>
        /// This method returns number of minutes.
        /// </summary>
        /// <returns></returns>
        public int GetMinutes()
        {
            return min;
        }
        /// <summary>
        /// This method returns number of seconds.
        /// </summary>
        /// <returns></returns>
        public int GetSeconds()
        {
            return sec;
        }
        /// <summary>
        /// This method resets time to 00:00:00.
        /// </summary>
        public void ResetTime()
        {
            hour = 0;
            min = 0;
            sec = 0;
        }
        /// <summary>
        /// This method returns name of animal.
        /// </summary>
        /// <returns></returns>
        public string GetAnimalName()
        {
            return animalName;
        }
        /// <summary>
        /// This method sets up name of animal.
        /// </summary>
        /// <param name="animalName1"></param>
        public void SetAnimalName(string animalName1)
        {
            animalName = animalName1;
        }
        /// <summary>
        /// This method sets up value of days.
        /// </summary>
        public void SetDays(int days)
        {
            day = days;
        }
        /// <summary>
        /// This method sets up value of hours.
        /// </summary>
        public void SetHours(int hours)
        {
            hour = hours;
        }
        /// <summary>
        /// This method sets up value of minutes.
        /// </summary>
        public void SetMinutes(int mins)
        {
            min = mins;
        }
        /// <summary>
        /// This method sets up value of seconds.
        /// </summary>
        public void SetSeconds(int secs)
        {
            sec = secs;
        }
        /// <summary>
        /// This method resets animal name.
        /// </summary>
        public void ResetAnimalName()
        {
            animalName = "+ľščťžýáíé+ľščťžýáíé+ľščťžýáíé";
        }
        /// <summary>
        /// This method returns if walking was done.
        /// </summary>
        /// <returns></returns>
        public bool GetWalkingStatus()
        {
            return walkingDone;
        }
        /// <summary>
        /// This method sets walking to done.
        /// </summary>
        public void SetWalkingToDone()
        {
            walkingDone = true;
        }
        /// <summary>
        /// This method sets walking to not done.
        /// </summary>
        public void SetWalkingToNotDone()
        {
            walkingDone = false;
        }
    }
}
