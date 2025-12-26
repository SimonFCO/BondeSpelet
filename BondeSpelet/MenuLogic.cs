using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace BondeSpelet
{
    internal class MenuLogic
    {
        Random rnd = new Random();
        int[] GreenDice = { 1, 1, 1, 2, 2, 3 };
        public int RoleDiceInput(bool isGreen)
        {
            int DiceResult = 0;
            if (isGreen)
            {
                DiceResult = rnd.Next(0, 6);
                DiceResult = GreenDice[DiceResult];
            }
            else
            {
                DiceResult = rnd.Next(0, 6);
            }
            return DiceResult;
        }
        public static void StartMenuLogic()
        {
            int answer = Utilities.GetUserNumber(0, 2);
            if (answer == 1) // Play
            {
                Console.Clear();
                Menu.PickPlayerAmmount();
                Game.AmmountOfPlayers = Utilities.GetUserNumber(0, 6);
                Console.Clear();

                for(int i = 0; i< Game.AmmountOfPlayers; i++)
                {
                    CreatePlayerLogic();
                }
            }
            else // Quit
            {
                Console.WriteLine("Goodbye!");
                Thread.Sleep(1500);
            }
        }
        public static void CreatePlayerLogic()
        {
            Menu.CreatePlayer(1);
            int answer = Utilities.GetUserNumber(0,2);
            Console.Clear();

            if (answer == 1) // Real player
            {
                Menu.CreatePlayer(2);
                string name = Console.ReadLine();
                Player player = new Player(name, false);
                Game.PlayerList.Add(player);
                Menu.PlayerSuccesfullyCreated(name);
                Thread.Sleep(1500);
                Console.Clear();


            }
            else // Computer Creation
            {
                Random rnd = new Random();
                string[] names = { "Bob", "Rutger", "Sten", "Bengt", "Stefan", "Olof" };
                string name = names[rnd.Next(0, 6)];
                Player player = new Player(name, false);
                Game.PlayerList.Add(player);
                Menu.PlayerSuccesfullyCreated(name);
                Thread.Sleep(1500);
                Console.Clear();
            }
        }

        public static void PrintOutPlayerStatsLogic()
        {
            for(int i = 0; i < Game.PlayerList.Count; i++)
            {
                Console.WriteLine($"{Game.PlayerList[i].Name,-25} {Game.PlayerList[i].BoardSpot,-22} {Game.PlayerList[i].Balance,-19} {Game.PlayerList[i].FarmLevel,-16} {Game.PlayerList[i].ForestValue,-13} {Game.PlayerList[i].AnimalAmmount,-10}");
            }
        }
    }
}
