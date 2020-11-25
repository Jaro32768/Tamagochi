using System;
using System.Threading;

namespace Tamagochi
{
    class Hygiene
    {
        public static bool hygieneDone = false;
        private static int hygieneStat = 50;
        /// <summary>
        /// This method sets up console for hygiene intro view.
        /// </summary>
        public void HygieneIntro()
        {
            string hygienieIntro = "";
            for (int i = 0; i < hygienieIntro.Length; i++)
            {
                Console.Write(hygienieIntro[i]);
                if (hygienieIntro[i] == ' ')
                {
                    Thread.Sleep(50);
                }
                else if (hygienieIntro[i] == ',')
                {
                    Thread.Sleep(75);
                }
                else
                {
                    Thread.Sleep(25);
                    if (hygienieIntro[i] == '.')
                    {
                        Thread.Sleep(50);
                        Console.WriteLine();
                    }
                }

            }
            Console.ReadKey();
            Console.Clear();
            PlayHygieneGame();
        }
        /// <summary>
        /// This method returns value of hygiene.
        /// </summary>
        /// <returns></returns>
        public int GetHygieneStat()
        {
            return hygieneStat;
        }
        /// <summary>
        /// This method sets up value of hygiene.
        /// </summary>
        /// <param name="hygiene"></param>
        public void SetHygieneStat(int hygiene)
        {
            hygieneStat = hygiene;
        }
        /// <summary>
        /// This method increases value of hygiene.
        /// </summary>
        /// <param name="hygieneStat"></param>
        public void PlusHygieneStat(int hygieneStat1)
        {
            hygieneStat += hygieneStat1;
            if (hygieneStat > 100)
            {
                hygieneStat = 100;
            }
        }
        /// <summary>
        /// This method decreases value of hygiene.
        /// </summary>
        /// <param name="hygieneStat"></param>
        public void MinusHygieneStat(int hygieneStat1)
        {
            hygieneStat -= hygieneStat1;
            if (hygieneStat < 0)
            {
                hygieneStat = 0;
            }
        }
        /// <summary>
        /// This method sets hygiene stat to its default value.
        /// </summary>
        public void ResetHygieneStat()
        {
            hygieneStat = 50;
        }
        /// <summary>
        /// This method sets up console for hygiene game.
        /// </summary>
        public void PlayHygieneGame()
        {
            hygieneDone = false;
            int hygwins = 0;
            Random ransign = new Random();

            while (hygwins != 3)
            {
                Console.Clear();
                Console.WriteLine("rock / paper / scissors");
                string player = Console.ReadLine();
                int a = ransign.Next(1, 4);
                if (a == 1)
                {
                    if (player == "rock")
                    {
                        Console.WriteLine(@"    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)");
                        Console.WriteLine("");
                        Console.WriteLine("Tie.");
                        Thread.Sleep(1000);
                    }
                    else if (player == "paper")
                    {
                        Console.WriteLine(@"    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)");
                        Console.WriteLine("");
                        Console.WriteLine("You win");
                        hygwins++;
                        PlusHygieneStat(100);
                        Thread.Sleep(1000);
                    }
                    else if (player == "scissors")
                    {
                        Console.WriteLine(@"    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)");
                        Console.WriteLine("");
                        Console.WriteLine("You lost");
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("Wrong input");
                        Thread.Sleep(1000);
                    }
                }
                else if (a == 2)
                {
                    if (player == "rock")
                    {
                        Console.WriteLine(@"     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)");
                        Console.WriteLine("");
                        Console.WriteLine("You lost");
                        Thread.Sleep(1000);
                    }
                    else if (player == "paper")
                    {
                        Console.WriteLine(@"     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)");
                        Console.WriteLine("");
                        Console.WriteLine("Tie");
                        Thread.Sleep(1000);
                    }
                    else if (player == "scissors")
                    {
                        Console.WriteLine(@"     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)");
                        Console.WriteLine("");
                        Console.WriteLine("You win");
                        hygwins++;
                        PlusHygieneStat(100);
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("Wrong input");
                        Thread.Sleep(1000);
                    }
                }
                else if (a == 3)
                {
                    if (player == "rock")
                    {
                        Console.WriteLine(@"    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)");
                        Console.WriteLine("");
                        Console.WriteLine("You win");
                        hygwins++;
                        PlusHygieneStat(100);
                        Thread.Sleep(1000);
                    }
                    else if (player == "paper")
                    {
                        Console.WriteLine(@"    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)");
                        Console.WriteLine("");
                        Console.WriteLine("You lost");
                        Thread.Sleep(1000);
                    }
                    else if (player == "scissors")
                    {
                        Console.WriteLine(@"    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)");
                        Console.WriteLine("");
                        Console.WriteLine("Tie");
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("Wrong input");
                        Thread.Sleep(1000);
                    }
                }
            }

        }
        /// <summary>
        /// This method returns if hygiene was done.
        /// </summary>
        /// <returns></returns>
        public bool GetHygieneStatus()
        {
            return hygieneDone;
        }
        /// <summary>
        /// This method sets hygiene to done
        /// </summary>
        public void SetHygieneToDone()
        {
            hygieneDone = true;
        }
        /// <summary>
        /// This method sets hygiene to not done
        /// </summary>
        public void SetHygieneToNotDone()
        {
            hygieneDone = false;
        }
    }
}

