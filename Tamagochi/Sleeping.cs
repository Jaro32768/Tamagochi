using System;
using System.Threading;


namespace Tamagochi
{
    class Sleeping
    {
        private static int energyStat = 50;
        /// <summary>
        /// This method sets up console for energy intro view.
        /// </summary>
        public void EnergyIntro()
        {
            string energyIntro = "Your goal in this minigame is to solve math problems.For every right answer you sleep for 1 hour.Make sure to sleep at least 6 hours and no more then 10.";
            for (int i = 0; i < energyIntro.Length; i++)
            {
                Console.Write(energyIntro[i]);
                if (energyIntro[i] == ' ')
                {
                    Thread.Sleep(50);
                }
                else if (energyIntro[i] == ',')
                {
                    Thread.Sleep(75);
                }
                else
                {
                    Thread.Sleep(25);
                    if (energyIntro[i] == '.')
                    {
                        Thread.Sleep(50);
                        Console.WriteLine();
                    }
                }

            }
            Console.ReadKey();
            Console.Clear();
            PlayEnergyGame();
        }
        /// <summary>
        /// This method returns value of energy.
        /// </summary>
        /// <returns></returns>
        public int GetEnergyStat()
        {
            return energyStat;
        }
        /// <summary>
        /// This method sets up value of satiety.
        /// </summary>
        /// <param name="energy"></param>
        public void SetEnergyStat(int energy)
        {
            energyStat = energy;
        }
        /// <summary>
        /// This method increases value of energy
        /// </summary>
        /// <param name="energyStat"></param>
        public void PlusEnergyStat(int energyStat1)
        {
            energyStat += energyStat1;
            if (energyStat > 100)
            {
                energyStat = 100;
            }
        }
        /// <summary>
        /// This method decreases value of energy.
        /// </summary>
        /// <param name="energyStat"></param>
        public void MinusEnergyStat(int energyStat1)
        {
            energyStat -= energyStat1;
            if (energyStat < 0)
            {
                energyStat = 0;
            }
        }
        /// <summary>
        /// This method sets energy stat to its default value.
        /// </summary>
        public void ResetEnergyStat()
        {
            energyStat = 50;
        }
        /// <summary>
        /// This method sets up console for energy game.
        /// </summary>
        public void PlayEnergyGame()
        {
            FirstOpen firstOpen = new FirstOpen();
            Random random = new Random();
            BasicGraphics basicGraphics = new BasicGraphics();
            Walking fitnessStat = new Walking();
            Playing happinessStat = new Playing();
            Food satietyStat = new Food();
            Console.ReadLine();
            Console.Clear();
            int a = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Do you want to skip an hour? y / n");
                string math = Console.ReadLine();

                if (math == "n" || math == "N")
                {
                    Console.Clear();
                    Console.WriteLine(@"  ()___
()//__/)_________________()
||(___)//#/_/#/_/#/_/#()/||
||----|#| |#|_|#|_|#|_|| ||
||____|_|#|_|#|_|#|_|#||/||
||    |#|_|#|_|#|_|#|_||");
                    Console.WriteLine();
                    Console.WriteLine($"You slept {a} hours");
                    if (a < 6)
                    {
                        MinusEnergyStat(20);
                        Console.WriteLine("You didnt sleep enough you will lost extra energy.");
                    }
                    else if (a > 10)
                    {
                        satietyStat.MinusSatietyStat(10);
                        fitnessStat.MinusFitnessStat(10);
                        Console.WriteLine("You slept for too long you will lose extra satiety and walking.");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    basicGraphics.Setup();
                }
                else if (math == "y" || math == "Y")
                {
                    int answer = 0;
                    int num1 = random.Next(-100, 100);
                    int num2 = random.Next(0, 100);
                    int choice = random.Next(1, 4);
                    switch (choice)
                    {
                        case 1:
                            {
                                answer = num1 + num2;
                                Console.WriteLine($"{num1} + {num2} = ?");
                                break;
                            }
                        case 2:
                            {
                                answer = num1 - num2;
                                Console.WriteLine($"{num1} - {num2} = ?");
                                break;
                            }
                        case 3:
                            {
                                answer = num1 * num2;
                                Console.WriteLine($"{num1} * {num2} = ?");
                                break;
                            }
                    }
                    int myAnswer = Convert.ToInt32(Console.ReadLine());
                    if (myAnswer == answer)
                    {
                        firstOpen.AddHours(1);


                        PlusEnergyStat(0);
                        Console.WriteLine("Good Answer");
                        if (firstOpen.GetDifficulty() == 0)
                        {
                            satietyStat.MinusSatietyStat(1);
                            happinessStat.MinusHappinessStat(1);
                            PlusEnergyStat(1);
                            fitnessStat.MinusFitnessStat(1);
                            a++;
                        }
                        else if (firstOpen.GetDifficulty() == 1)
                        {
                            satietyStat.MinusSatietyStat(2);
                            happinessStat.MinusHappinessStat(2);
                            PlusEnergyStat(2);
                            fitnessStat.MinusFitnessStat(2);
                            a++;
                        }
                        else
                        {
                            satietyStat.MinusSatietyStat(4);
                            happinessStat.MinusHappinessStat(4);
                            PlusEnergyStat(4);
                            fitnessStat.MinusFitnessStat(4);
                            a++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
                Console.ReadKey();
            }
        }
    }
}
