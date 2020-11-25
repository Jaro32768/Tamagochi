using System;

namespace Tamagochi
{
    class Program
    {
        /// <summary>
        /// This method starts program.
        /// </summary>
        static void Main()
        {
            Food food = new Food();
            food.SetLists();
            Console.Title = "Tamagochi";
            Intro intro = new Intro();
            intro.PlayIntro();
        }
    }
}
