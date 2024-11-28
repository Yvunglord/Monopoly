using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Map.Fields
{
    public class WaterWorksField : Field
    {
        public override void LandOn(Player player)
        {
            player.SubtractMoney(50);
            Console.WriteLine("Игрок попал на поле водоснабжения и заплатил 50.");
        }
    }
}
