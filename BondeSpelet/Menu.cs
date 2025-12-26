using System;
using System.Collections.Generic;
using System.Text;

namespace BondeSpelet
{
    internal class Menu
    {
        public static void Ascii()
        {
            Console.WriteLine("Ascii WIP");
        }

        public static void StartMenu()
        {
            Console.WriteLine("[1]: Play");
            Console.WriteLine("[2]: Quit");
        }

        public static void PickPlayerAmmount()
        {
            Console.WriteLine("How many players should there be?");
        }

        public static void CreatePlayer(int step)
        {
            if (step == 1)
            {
                Console.WriteLine("Real or CPU?");
                Console.WriteLine("[1]: Real");
                Console.WriteLine("[2]: CPU");
            }else if(step == 2)
            {
                Console.WriteLine("What is your name?");
            }

        }

        public static void PlayerSuccesfullyCreated(string name)
        {
            Console.WriteLine($"New Player {name} Has been successfully added to the game");
        }

        public static void PrintAllPlayersStats()
        {
            Console.Clear();
            Console.WriteLine($"{"Name",-25} {"BoardSpot",-22} {"Money",-19} {"FarmLvl",-16} {"ForestValue",-13} {"AnimalLvl",-10}");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
            MenuLogic.PrintOutPlayerStatsLogic();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
        }
        public static void RoleDice()
        {

        }

        public static void PrintPlayerNameTurn(Player player)
        {
            Console.WriteLine($"It is {player.Name} turn, please pick a option!");
            Console.WriteLine($"[1]: Roll Dice");
            Console.WriteLine($"[2]: Buy Forest");
            Console.WriteLine($"[3]: Sell Forest");
            Console.WriteLine($"[4]: Send Money");
            MenuLogic.PrintPlayerNameTurnLogic(player);
        }

        public static void CardAnimation(string Season)
        {
            Console.WriteLine("You Got a Card! (Card Animation WIP)");
        }

        public static void DiceAnimation(int result)
        {
            Console.Clear();
            Console.WriteLine("# # # # #\r\n# # # # #\r\n# # * # #\r\n# # # # #\r\n# # # # #");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("# # # # #\r\n# # * # #\r\n# # # # #\r\n# # * # #\r\n# # # # #");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("# # # # #\r\n# * # # #\r\n# # * # #\r\n# # # * #\r\n# # # # #");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("# # # # #\r\n# * # * #\r\n# # # # #\r\n# * # * #\r\n# # # # #");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("# # # # #\r\n# * # * #\r\n# # * # #\r\n# * # * #\r\n# # # # #");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("# # # # #\r\n# * # * #\r\n# * # * #\r\n# * # * #\r\n# # # # #");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine($"You got {result}");
            switch (result)
            {
                case 1:
                    Console.WriteLine("# # # # #\r\n# # # # #\r\n# # * # #\r\n# # # # #\r\n# # # # #");
                    break;
                case 2:
                    Console.WriteLine("# # # # #\r\n# # * # #\r\n# # # # #\r\n# # * # #\r\n# # # # #");
                    break;
                case 3:
                    Console.WriteLine("# # # # #\r\n# * # # #\r\n# # * # #\r\n# # # * #\r\n# # # # #");
                    break;
                case 4:
                    Console.WriteLine("# # # # #\r\n# * # * #\r\n# # # # #\r\n# * # * #\r\n# # # # #");
                    break;
                case 5:
                    Console.WriteLine("# # # # #\r\n# * # * #\r\n# # * # #\r\n# * # * #\r\n# # # # #");
                    break;
                case 6:
                    Console.WriteLine("# # # # #\r\n# * # * #\r\n# * # * #\r\n# * # * #\r\n# # # # #");
                    break;
            }
            Thread.Sleep(1000);
            Console.Clear();


        }
    }
}
