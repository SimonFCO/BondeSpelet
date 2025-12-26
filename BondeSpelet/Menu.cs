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

        public static void RoleDice()
        {

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
    }
}
