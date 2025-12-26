using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace BondeSpelet
{
    public class Game
    {
        public static int AmmountOfPlayers = 0; 
        public static List<Player>PlayerList = new List<Player>();
        public static bool GameIsOn = true;
        public static int playersTurn = 0;
        public static void RunGame()
        {
            Menu.Ascii();
            Menu.StartMenu();
            MenuLogic.StartMenuLogic();
            Menu.PrintAllPlayersStats();
            while (GameIsOn)
            {
                Menu.PrintAllPlayersStats();
                Menu.PrintPlayerNameTurn(PlayerList[playersTurn]);
                CheckBoardEvents(PlayerList[playersTurn]);

                if (playersTurn < PlayerList.Count-1)
                {
                    playersTurn += 1;
                }
                else
                {
                    playersTurn = 0;
                }
            }
        }

        public static void CheckBoardEvents(Player player)
        {
            switch (player.BoardSpot)
            {
                case 1:
                    Cards.DrawSpringCard(player);
                    break;
                case 4:
                    Cards.DrawSpringCard(player);
                    break;
                case 12:
                    Cards.DrawSpringCard(player);
                    break;
                case 18:
                    Cards.DrawSpringCard(player);
                    break;
                case 24:
                    Cards.DrawSpringCard(player);
                    break;
            }
        }
    }
}
