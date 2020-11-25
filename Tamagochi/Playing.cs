using System;
using System.Collections.Generic;
using System.Threading;


namespace Tamagochi
{
    class Playing
    {
        private static int happinessStat = 50;
        readonly private static char[] charArray = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        /// <summary>
        /// This method sets up console for happiness intro view.
        /// </summary>
        public void HappinsessIntro()
        {
            if (happinessStat < 70)
            {
                string happinessIntro = "Your goal in this minigame is to write the letter that appears on your screen.";
                for (int i = 0; i < happinessIntro.Length; i++)
                {
                    Console.Write(happinessIntro[i]);
                    if (happinessIntro[i] == ' ')
                    {
                        Thread.Sleep(50);
                    }
                    else if (happinessIntro[i] == ',')
                    {
                        Thread.Sleep(75);
                    }
                    else
                    {
                        Thread.Sleep(25);
                        if (happinessIntro[i] == '.')
                        {
                            Thread.Sleep(50);
                            Console.WriteLine();
                        }
                    }

                }
                Console.ReadKey();
                Console.Clear();
                PlayHappinessGame();
            }
            else
            {
                BasicGraphics basicGraphics = new BasicGraphics();
                Console.WriteLine("Your pet is lazy now, it played enough for now!");
                Console.ReadKey();
                basicGraphics.Setup();
            }
            
        }
        /// <summary>
        /// This method returns value of happiness.
        /// </summary>
        /// <returns></returns>
        public int GetHappinessStat()
        {
            return happinessStat;
        }
        /// <summary>
        /// This method sets up value of happiness.
        /// </summary>
        /// <param name="happiness"></param>
        public void SetHappinessStat(int happiness)
        {
            happinessStat = happiness;
        }
        /// <summary>
        /// This method increases value of happiness.
        /// </summary>
        /// <param name="happinessStat"></param>
        public void PlusHappinessStat(int happinessStat1)
        {
            happinessStat += happinessStat1;
            if (happinessStat > 100)
            {
                happinessStat = 100;
            }
        }
        /// <summary>
        /// this method decreases value of happiness.
        /// </summary>
        /// <param name="happinessStat"></param>
        public void MinusHappinessStat(int happinessStat1)
        {
            happinessStat -= happinessStat1;
            if (happinessStat < 0)
            {
                happinessStat = 0;
            }
        }
        /// <summary>
        /// This method sets happiness stat to its default value.
        /// </summary>
        public void ResetHappinessStat()
        {
            happinessStat = 50;
        }
        /// <summary>
        /// This method sets up console for happiness game.
        /// </summary>
        public void PlayHappinessGame()
        {
            BasicGraphics basicGraphics = new BasicGraphics();
            FirstOpen firstOpen = new FirstOpen();
            Random random = new Random();
            
                Console.Clear();
                Console.WriteLine(@""); 
                int sec = firstOpen.GetSeconds();
                int foodscore = 0;
                int a = sec + 30;
                if (a > 60)
                {
                    a -= 60;
                }
                while (a != firstOpen.GetSeconds())
                {
                    
                    int i = random.Next(0,26);
                    Console.WriteLine(charArray[i]);
                    if (charArray[i] == Convert.ToChar(Console.Read()))
                    {
                        PlusHappinessStat(1);
                        Console.WriteLine();
                        foodscore++;
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
                Console.WriteLine($"You ran {foodscore} meters, so you were added {foodscore}%.");
                Console.WriteLine(@"      _.-'''''-._
    .'  _     _  '.
   /   (_)   (_)   \
  |  ,           ,  |
  |  \`.       .`/  |
   \  '.`'´´'´`.'  /
    '.  `'-- - '`.'
      '-._____.-'");
                Console.ReadKey();
                basicGraphics.Setup();


            
            //23 0
        }
    }
}
