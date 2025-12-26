using System;
using System.Collections.Generic;
using System.Text;

namespace BondeSpelet
{
    internal class Cards
    {
        Random rnd = new Random();
        int PickedCard = 0;
        public void DrawSpringCard(Player player)
        {
            PickedCard = rnd.Next(0,10);
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
