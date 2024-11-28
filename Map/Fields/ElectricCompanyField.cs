using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Map.Fields
{
    public class ElectricCompanyField : Field
    {
        public override void LandOn(Player player)
        {
            player.SubtractMoney(100);
            Console.WriteLine("Игрок попал на электростанцию и должен заплатить 100");
        }
    }
}
