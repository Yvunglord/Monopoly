using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Map.Fields
{
    public class TaxField : Field
    {
        public override void LandOn(Player player)
        {
            player.SubtractMoney(100);
            Console.WriteLine("Игрок заплатил 100 за налог.");
        }
    }
}
