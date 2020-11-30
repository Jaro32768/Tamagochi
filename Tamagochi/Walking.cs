using System;
using System.Threading;


namespace Tamagochi
{
    class Walking
    {
        private static int fitnessStat = 50;
        /// <summary>
        /// This method sets up console for fitness intro view.
        /// </summary>
        public void FitnessIntro()
        {
            string fitnessIntro = "Your goal in this minigame to choose the path which suits the animals current mood.After your done you need to do Hygiene in less then an hour or you suffer a penalty.";
            for (int i = 0; i < fitnessIntro.Length; i++)
            {
                Console.Write(fitnessIntro[i]);
                if (fitnessIntro[i] == ' ')
                {
                    Thread.Sleep(50);
                }
                else if (fitnessIntro[i] == ',')
                {
                    Thread.Sleep(75);
                }
                else
                {
                    Thread.Sleep(25);
                    if (fitnessIntro[i] == '.')
                    {
                        Thread.Sleep(50);
                        Console.WriteLine();
                    }
                }

            }
            Console.ReadKey();
            Console.Clear();
            PlayFitnessGame();
        }
        /// <summary>
        /// This method returns value of fitness.
        /// </summary>
        /// <returns></returns>
        public int GetFitnessStat()
        {
            return fitnessStat;
        }
        /// <summary>
        /// This method sets up value of satiety.
        /// </summary>
        /// <param name="satiety"></param>
        public void SetFitnessStat(int fitness)
        {
            fitnessStat = fitness;
        }
        /// <summary>
        /// This method increases value of fitness
        /// </summary>
        /// <param name="fitnessStat"></param>
        public void PlusFitnessStat(int fitnessStat1)
        {
            fitnessStat += fitnessStat1;
            if (fitnessStat > 100)
            {
                fitnessStat = 100;
            }
        }
        /// <summary>
        /// This method decreases value of firness.
        /// </summary>
        /// <param name="fitnessStat"></param>
        public void MinusFitnessStat(int fitnessStat1)
        {
            fitnessStat -= fitnessStat1;
            if (fitnessStat < 0)
            {
                fitnessStat = 0;
            }
        }
        /// <summary>
        /// This method sets fitness stat to its default value.
        /// </summary>
        public void ResetFitnessStat()
        {
            fitnessStat = 50;
        }
        /// <summary>
        /// This method sets up console for fitness game.
        /// </summary>
        public void PlayFitnessGame()
        {
            Hygiene hygiene = new Hygiene();
            FirstOpen firstOpen = new FirstOpen();
            BasicGraphics basicGraphics = new BasicGraphics();
            DeathScreen deathScreen = new DeathScreen();
            string animalName = firstOpen.GetAnimalName();
            Console.WriteLine();
            Random mood = new Random();
            Console.ReadLine();
            Console.Clear();
            hygiene.SetHygieneToNotDone();
            new Thread(() =>
            {
                Thread.Sleep(3600000);
                if (hygiene.GetHygieneStatus() == false)
                {
                    deathScreen.Setup();
                }

            }).Start();

            int charmood = mood.Next(1, 4);
            if (charmood == 1)
            {
                Console.WriteLine($"{animalName} wants to be under shade of the trees.");
            }
            else if (charmood == 2)
            {
                Console.WriteLine($"{animalName} wants a challenge.");
            }
            else if (charmood == 3)
            {
                Console.WriteLine($"{animalName} wants to meet people.");
            }
            Thread.Sleep(2000);
            Console.WriteLine(@"    /\/\/\  /\         /\    /\        _   _
 /\/ / /  \/  \       /\*\  /\*\      |.|-|.|
/  \  /    \   \       ||    ||       |.|.|.|");
            Console.WriteLine("Which path do you want to choose? left/straight/right");
            string pathchoice = Console.ReadLine();
            Console.Clear();
            if (pathchoice == "left")
            {
                Console.WriteLine(@"                      _
                     /#\
                    /###\     /\
                   /  ###\   /##\  /\
                  /      #\ /####\/##\
                 /  /      /   # /  ##\             _       /\
               // //  /\  /    _/  /  #\ _         /#\    _/##\    /\
              // /   /  \     /   /    #\ \      _/###\_ /   ##\__/ _\
             /  \   / .. \   / /   _   { \ \   _/       / //    /    \\
     /\     /    /\  ...  \_/   / / \   } \ | /  /\  \ /  _    /  /    \ /\
  _ /  \  /// / .\  ..%:.  /... /\ . \ {:  \\   /. \     / \  /   ___   /  \
 /.\ .\.\// \/... \.::::..... _/..\ ..\:|:. .  / .. \\  /.. \    /...\ /  \ \
/...\.../..:.\. ..:::::::..:..... . ...\{:... / %... \\/..%. \  /./:..\__   \
 .:..\:..:::....:::;;;;;;::::::::.:::::.\}.....::%.:. \ .:::. \/.%:::.:..\
::::...:::;;:::::;;;;;;;;;;;;;;:::::;;::{:::::::;;;:..  .:;:... ::;;::::..
;;;;:::;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;];;;;;;;;;;::::::;;;;:.::;;;;;;;;:..
;;;;;;;;;;;;;;ii;;;;;;;;;;;;;;;;;;;;;;;;[;;;;;;;;;;;;;;;;;;;;;;:;;;;;;;;;;;;;
;;;;;;;;;;;;;;;;;;;iiiiiiii;;;;;;;;;;;;;;};;ii;;iiii;;;;i;;;;;;;;;;;;;;;ii;;;
iiii;;;iiiiiiiiiiIIIIIIIIIIIiiiiiIiiiiii{iiIIiiiiiiiiiiiiiiii;;;;;iiiilliiiii
IIIiiIIllllllIIlllIIIIlllIIIlIiiIIIIIIIIIIIIlIIIIIllIIIIIIIIiiiiiiiillIIIllII
IIIiiilIIIIIIIllTIIIIllIIlIlIIITTTTlIlIlIIIlIITTTTTTTIIIIlIIllIlIlllIIIIIIITT
IIIIilIIIIITTTTTTTIIIIIIIIIIIIITTTTTIIIIIIIIITTTTTTTTTTIIIIIIIIIlIIIIIIIITTTT
IIIIIIIIITTTTTTTTTTTTTIIIIIIIITTTTTTTTIIIIIITTTTTTTTTTTTTTIIIIIIIIIIIIIITTTTT");
                Console.ReadKey();
                Console.Clear();
                firstOpen.SetWalkingToDone();
                if (charmood == 1)
                {
                    PlusFitnessStat(35);
                }
                else if (charmood == 2)
                {
                    PlusFitnessStat(50);
                }
                else if (charmood == 3)
                {
                    PlusFitnessStat(20);
                }
                basicGraphics.Setup();
            }
            else if (pathchoice == "straight")
            {
                Console.WriteLine(@".. ........... .............  ........... . ..... ........ .......
 ......  ....................%.... .... ..... .........%............
 .@@@ ........ @@.... @@@@  . ............................  *  .....
 ....@@ ..... @ .... @ .............   ....... .....; .... *** .....
 .....\@\....@ .... @ ............................. #  .. *****  ...
  @@@.. @@@@@  @@@@@@___.. ....... ...%..... ...  {###}  *******
 ....@-@..@ ..@......@@@\...... %...... ....... <## ####>********
   @@@@\...@ @ ........\@@@@ ..... ...... ....... {###}***********
 ....%..@  @@ /@@@@@ . ....... ...............<###########> *******
 ...... .@-@@@@ ...V......     .... %.......... {#######}******* ***
 ...... .  @@ .. ..v.. .. . { } ............<###############>*******
 ......... @@ .... ........ {^^,     .......   {## ######}***** ****
 ..%..... @@ .. .%.... . .. (   `-;   ... <###################> ****
 . .... . @@ . .... .. _  .. `;;~~ ......... {#############}********
 .... ... @@ ... ..   /(______); .. ....<################  #####>***
 . .... ..@@@ ...... (         (  .........{##################}*****
 ......... @@@  ....  |:------( )  .. <##########################>**
  @@@@ ....@@@  ... _// ...... \\ ...... {###   ##############}*****
 @@@@@@@  @@@@@ .. / /@@@@@@@@@ vv  <##############################>
 @@@@@@@ @@@@@@@ @@@@@@@@@@@@@@@@@@@ ..... @@@@@@  @@@@@@@  @@@@
 @@@@@@###@@@@@### @@@@@@@@@@@@@@@@@@ @@@@@@@@@@@@@@@@@@@@@@@@@@@@@
 @@@@@@@@###@##@@ @@@@@@@@@@@@@@@@@@@@@ @@@@@   @@@@@@@@@@@@@@@@@@@
 @@@@@@@@@@@### @@@@@@@@@@@@@@@@@@@@@@@@@@ @@@@@@@@@@@@@@@@@@@@@@@@
 -@@@@@@@@@#####@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                Console.ReadKey();
                Console.Clear();
                firstOpen.SetWalkingToDone();
                if (charmood == 1)
                {
                    PlusFitnessStat(50);
                }
                else if (charmood == 2)
                {
                    PlusFitnessStat(20);
                }
                else if (charmood == 3)
                {
                    PlusFitnessStat(35);
                }
                basicGraphics.Setup();
            }
            else if (pathchoice == "right")
            {
                Console.WriteLine(@"/:///_/_/_/_/:\/::\ \:/__  __ /:/____/\  / \\:\/:/ _____  ____/\  /\  / /  \/
:///_/_/_/_//\::/\:\///_/ /_//:/____/\:\____\\::/ /____/ /___/  \/  \/+/\  /\
///_/_/_/_/:\/::\ \:/__  __ /:/____/\:\/____/\\/____________/\  /\  / /  \/  \
//_/_/_/_//\::/\:\///_/ /_//::::::/\:\/____/  /----/----/--/  \/  \/+/\  /\  /
/_/_/_/_/:\/::\ \:/__  __ /\:::::/\:\/____/ \/____/____/__/\  /\  / /  \/  \/_
_/_/_/_//\::/\:\///_/ /_//\:\::::\:\/____/ \_____________/  \/  \/+/\  /\  /
/_/_/_/:\/::\ \:/__  __ /\:\:\::::\/____/   \ _ _ _ _ _ /\  /\  / /  \/  \/___
_/_/_//\::/\:\///_/ /_//\:\:\:\              \_________/  \/  \/+/\  /\  /   /
/_/_/:\/::\ \:/__  __ /\:\:\:\:\______________\       /\  /\  / /  \/  \/___/_
_/_//\::/\:\///_/ /_//::\:\:\:\/______________/      /  \/  \/+/\  /\  /   /
/_/:\/::\ \:/__  __ /::::\:\:\/______________/\     /\  /\  / /  \/  \/___/___
_//\::/\:\///_/ /_//:\::::\:\/______________/  \   /  \/  \/+/\  /\  /   /   /
/:\/::\ \:/__  __ /:\:\::::\/______________/    \ /\  /\  / /  \/  \/___/___/
/\::/\:\///_/ /_//:\:\:\                         \  \/\\\/+/\  /\  /   /   /+/
\/::\ \:/__  __ /:\:\:\:\_________________________\ ///\\\/  \/  \/___/___/ /_
::/\:\///_/ /_//:\:\:\:\/_________________________////::\\\  /\  /   /   /+/
::\ \:/__  __ /:\:\:\:\/_________________________/:\/____\\\/  \/___/___/ /___
/\:\///_/ /_//:\:\:\:\/_________________________/:::\    /\/\  /   /   /+/   /
\ \:/__  __ /:\:\:\:\/_________________________/:::::\  ///  \/___/___/ /___/_
:\///_/ /_//:\:\:\:\/_________________________/:\:::::\///\  /   /  __________
\:/__  __ /:\:\:\:\/_________________________/:::\:::::\/  \/___/__/\
///_/ /_//:\:\:\:\/_________________________/:\:::\:::::\  /   /  /::\
/__  __ /\::\:\:\/_________________________/_____::\:::::\/___/__/:/\:\
/_/ /_//::\::\:\/_____________________/\/_/_/_/_/\  \           /::\ \:\
_  __ /:\::\:8\/_____________________/\/\   /\_\\/\  \ 8       /:/\:\ \:\
/ /_//\     \|______________________//\\/\::\/__\\/\  \|______/::\ \:\ \:\
 __ /  \  \                        /:\/:\/\_______\/\        /:/\:\ \:\/::\
/_//    8      -8  --  --  --  -- //\::/\\/_/_/_/_/_/ --  --/::\ \:\ \::/\:\
_ /     |\  \   |________________/:\/::\///__/ /__//_______/:/\:\ \:\/::\ \:\
__________\     \               //\::/\:/___  ___ /       /::\ \:\ \::/\:\ \:\
::::::::::\\  \  \             /:\/::\///__/ /__//       /:/\:\ \:\/::\ \:\ \:");
                Console.ReadKey();
                Console.Clear();
                firstOpen.SetWalkingToDone();
                if (charmood == 1)
                {
                    PlusFitnessStat(20);
                }
                else if (charmood == 2)
                {
                    PlusFitnessStat(35);
                }
                else if (charmood == 3)
                {
                    PlusFitnessStat(50);
                }
                basicGraphics.Setup();
            }
            else
            {
                Console.WriteLine("Wrong input, try again.");
                PlayFitnessGame();
            }
            

        }
        


    }

}

