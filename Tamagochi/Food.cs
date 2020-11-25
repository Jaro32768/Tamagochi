using System;
using System.Collections.Generic;
using System.Threading;

namespace Tamagochi
{
    class Food
    {
        readonly private static List<string> foodList = new List<string>();
        readonly private static List<string> junkList = new List<string>();
        private static int satietyStat = 50;
        /// <summary>
        /// This method sets up console for food intro view.
        /// </summary>
        public void FoodIntro()
        {
            BasicGraphics basicGraphics = new BasicGraphics();
            if (satietyStat <= 50)
            {
                string foodIntro = "Your goal in this minigame is to guess which item is edable.If you guess correctly you will gain food, but if you guess incorrectly you lose food.";
                for (int i = 0; i < foodIntro.Length; i++)
                {
                    Console.Write(foodIntro[i]);
                    if (foodIntro[i] == ' ')
                    {
                        Thread.Sleep(50);
                    }
                    else if (foodIntro[i] == ',')
                    {
                        Thread.Sleep(75);
                    }
                    else
                    {
                        Thread.Sleep(25);
                        if (foodIntro[i] == '.')
                        {
                            Thread.Sleep(50);
                            Console.WriteLine();
                        }
                    }

                }
                Console.ReadKey();
                Console.Clear();
                PlayFoodGame();
            }
            else
            {
                Console.WriteLine("You are not hungry enough!");
                Console.ReadKey();
                basicGraphics.Setup();
            }

        }
        /// <summary>
        /// This method returns value of satiety.
        /// </summary>
        /// <returns></returns>
        public int GetSatietyStat()
        {
            return satietyStat;
        }
        /// <summary>
        /// This method sets up value of satiety.
        /// </summary>
        /// <param name="satiety"></param>
        public void SetSatietyStat(int satiety)
        {
            satietyStat = satiety;
        }
        /// <summary>
        /// This method increases value of satiety.
        /// </summary>
        /// <param name="satietyStat"></param>
        public void PlusSatietyStat(int satietyStat1)
        {
            satietyStat += satietyStat1;
            if (satietyStat > 100)
            {
                satietyStat = 100;
            }
        }
        /// <summary>
        /// This method decreases value of satiety.
        /// </summary>
        /// <param name="satietyStat"></param>
        public void MinusSatietyStat(int satietyStat1)
        {
            satietyStat -= satietyStat1;
            if (satietyStat < 0)
            {
                satietyStat = 0;
            }
        }
        /// <summary>
        /// This method sets satiety stat to its default value.
        /// </summary>
        public void ResetSatietyStat()
        {
            satietyStat = 50;
        }
        /// <summary>
        /// This method sets up lists to its value.
        /// </summary>
        public void SetLists()
        {
            foodList.Add(@"
  ,--./,-.
 /        \ 
|          |
 \        /
  `._,._,'
");
            foodList.Add(@"
\
 ()()
()()()
 ()()
  ()
");
            foodList.Add(@"
   \||/
 .<><><>.
.<><><><>.
'<><><><>'
 '<><><>
");
            foodList.Add(@"
  \/_
 _/        
(,;)
(,.)
(,/
|/
");
            junkList.Add(@"
     ()=()
     ('Y')  
     q . p 
     ()_()
");
            junkList.Add(@"
  ________
 (_]----[_)
.~ |.''.|
~. |'..'|
 `~`----`
");
            junkList.Add(@"
     _
    | |
 ___| |
(    .'
 )  ( 
");
            junkList.Add(@"
 _,-,
T_  |
||`-'
||
||
");
            junkList.Add(@"
>>>>>________________\`-._
>>>>>                /.-'
");
            junkList.Add(@"
   _
 _|#|_
| (O) |
 -----
");
            junkList.Add(@"
    _______
   /      /,
  /      //
 /______//
(______(/
");
            junkList.Add(@"
  _/\______\\__
 / ,-. -|-  ,-.`-.
 ( o )----( o )-'
  `-'      `-'
");
            junkList.Add(@"
   ,
.-/c-.,:: 
(_)'==(_)
");
            junkList.Add(@"
 __|_
|____|
|    |
|    |
\____/
");
            junkList.Add(@"
   ,
__/ \__
\     /
/_   _\
  \ /
");
            junkList.Add(@"
____
|DD|____T_
|_ |_____|<
  @-@-@-oo\
");
        }
        /// <summary>
        /// This method sets up console for food game.
        /// </summary>
        public void PlayFoodGame()
        {

            Console.WriteLine("Which item is edable?");
            Random random = new Random();
            BasicGraphics basicGraphics = new BasicGraphics();
            int a = random.Next(0, 4);
            int b = random.Next(0, 4);
            int c = random.Next(0, 12);
            int d = random.Next(0, 12);
            int e = random.Next(0, 12);
            if (a == c || a == d || a == e)
            {
                a++;
            }
            else if (d == c || d == a || d == e)
            {
                d++;
            }
            else if (e == c || e == a || e == d)
            {
                e++;
            }
            if (a == 0)
            {
                Console.WriteLine("1" + foodList[b]);
                Console.WriteLine("2" + junkList[c]);
                Console.WriteLine("3" + junkList[d]);
                Console.WriteLine("4" + junkList[e]);
                Console.ReadLine();
                string foodchoice = Console.ReadLine();
                if (foodchoice == "1")
                {
                    Console.WriteLine("Hmmmmm, it was tasty!");
                    PlusSatietyStat(50);
                }
                else if (foodchoice == "2")
                {
                    Console.WriteLine("You can't eat this!");
                    MinusSatietyStat(5);
                }
                else if (foodchoice == "3")
                {
                    Console.WriteLine("You can't eat this!");
                    MinusSatietyStat(5);
                }
                else if (foodchoice == "4")
                {
                    Console.WriteLine("You can't eat this!");
                    MinusSatietyStat(5);
                }
                else
                {
                    Console.WriteLine("Wrong input");
                    Console.Clear();
                    PlayFoodGame();
                }
            }
            else if (a == 1)
            {
                Console.WriteLine("1" + junkList[c]);
                Console.WriteLine("2" + foodList[b]);
                Console.WriteLine("3" + junkList[d]);
                Console.WriteLine("4" + junkList[e]);
                Console.ReadLine();
                string foodchoice = Console.ReadLine();
                if (foodchoice == "1")
                {
                    Console.WriteLine("You can't eat this!");
                    MinusSatietyStat(5);
                }
                else if (foodchoice == "2")
                {
                    Console.WriteLine("Hmmmmm, it was tasty!");
                    PlusSatietyStat(50);
                }
                else if (foodchoice == "3")
                {
                    Console.WriteLine("You can't eat this!");
                    MinusSatietyStat(5);
                }
                else if (foodchoice == "4")
                {
                    Console.WriteLine("You can't eat this!");
                    MinusSatietyStat(5);
                }
                else
                {
                    Console.WriteLine("Wrong input");
                    Console.Clear();
                    PlayFoodGame();
                }
            }
            else if (a == 2)
            {
                Console.WriteLine("1" + junkList[c]);
                Console.WriteLine("2" + junkList[d]);
                Console.WriteLine("3" + foodList[b]);
                Console.WriteLine("4" + junkList[e]);
                Console.ReadLine();
                string foodchoice = Console.ReadLine();
                if (foodchoice == "1")
                {
                    Console.WriteLine("You can't eat this!");
                    MinusSatietyStat(5);
                }
                else if (foodchoice == "2")
                {
                    Console.WriteLine("You can't eat this!");
                    MinusSatietyStat(5);
                }
                else if (foodchoice == "3")
                {
                    Console.WriteLine("Hmmmmm, it was tasty!");
                    PlusSatietyStat(50);
                }
                else if (foodchoice == "4")
                {
                    Console.WriteLine("You can't eat this!");
                    MinusSatietyStat(5);
                }
                else
                {
                    Console.WriteLine("Wrong input");
                    Console.Clear();
                    PlayFoodGame();
                }
            }
            else
            {
                Console.WriteLine("1" + junkList[c]);
                Console.WriteLine("2" + junkList[d]);
                Console.WriteLine("3" + junkList[e]);
                Console.WriteLine("4" + foodList[b]);
                Console.ReadLine();
                string foodchoice = Console.ReadLine();
                if (foodchoice == "1")
                {
                    Console.WriteLine("You can't eat this!");
                    MinusSatietyStat(5);
                }
                else if (foodchoice == "2")
                {
                    Console.WriteLine("You can't eat this!");
                    MinusSatietyStat(5);
                }
                else if (foodchoice == "3")
                {
                    Console.WriteLine("You can't eat this!");
                    MinusSatietyStat(5);
                }
                else if (foodchoice == "4")
                {
                    Console.WriteLine("Hmmmmm, it was tasty!");
                    PlusSatietyStat(50);
                }
                else
                {
                    Console.WriteLine("Wrong input");
                    Console.Clear();
                    PlayFoodGame();
                }
            }
            Console.ReadKey();
            Console.Clear();
            basicGraphics.Setup();




        }

    }
}
