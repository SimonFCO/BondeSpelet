using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BondeSpelet
{
    internal class Cards
    {
        Random rnd = new Random();
        int PickedCard = 0;
        public static void DrawSpringCard(Player player)
        {
            Random rnd = new Random();
            int PickedCard = rnd.Next(0,10);
            Console.Clear();
            Menu.CardAnimation("Spring");
            Thread.Sleep(750);
            Console.WriteLine("-----------------------------------------------");
            switch (PickedCard)
            {
                case 0:
                    Console.WriteLine("Good Card");
                    player.Balance += 10000;
                    Thread.Sleep(1500);
                    break;
                case 1:
                    Console.WriteLine("Good Card");
                    player.Balance += 25000;
                    Thread.Sleep(1500);
                    break;
                case 2:
                    Console.WriteLine("Good Card");
                    player.Balance += 100000;
                    Thread.Sleep(1500);
                    break;
                case 3:
                    Console.WriteLine("Bad Card");
                    player.Balance -= 10000;
                    Thread.Sleep(1500);
                    break;
                case 4:
                    Console.WriteLine("Bad Card");
                    player.Balance -= 50000;
                    Thread.Sleep(1500);
                    break;
                case 5:
                    Console.WriteLine("Bad Card");
                    player.Balance -= 100000;
                    Thread.Sleep(1500);
                    break;
                case 6:
                    Console.WriteLine("Bad Card");
                    player.Balance -= 100000;
                    Thread.Sleep(1500);
                    break;
                case 7:
                    Console.WriteLine("Bad Card");
                    player.Balance -= 100000;
                    Thread.Sleep(1500);
                    break;
                case 8:
                    Console.WriteLine("Bad Card");
                    player.Balance -= 100000;
                    Thread.Sleep(1500);
                    break;
                case 9:
                    Console.WriteLine("Bad Card");
                    player.Balance -= 100000;
                    Thread.Sleep(1500);
                    break;
            }
        }

        public void DrawSummerCard(Player player)
        {
            PickedCard = rnd.Next(0, 10);
            switch (PickedCard)
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:

                    break;
                case 9:

                    break;
            }
        }

        public void DrawAutumnCard(Player player)
        {
            PickedCard = rnd.Next(0, 10);
            switch (PickedCard)
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:

                    break;
                case 9:

                    break;
            }
        }

        public void DrawWinterCard(Player player)
        {
            PickedCard = rnd.Next(0, 10);
            switch (PickedCard)
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:

                    break;
                case 9:

                    break;
            }
        }
    }
}
