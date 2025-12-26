using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
