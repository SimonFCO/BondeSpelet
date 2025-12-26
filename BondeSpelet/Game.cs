using System;
using System.Collections.Generic;
using System.Text;

namespace BondeSpelet
{
    public class Game
    {
        public static int AmmountOfPlayers = 0; 
        public static List<Player>PlayerList = new List<Player>();
        public static void RunGame()
        {
            Menu.Ascii();
            Menu.StartMenu();
            MenuLogic.StartMenuLogic();
            Menu.PrintAllPlayersStats();
        }

        public static void CheckBoardEvents(Player player)
        {
            switch (player.BoardSpot)
            {
                case 0:
                    Cards.DrawSpringCard(player);
                    break;
            }
        }
    }
}
