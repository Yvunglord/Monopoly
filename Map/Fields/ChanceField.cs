using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Map.Fields
{
    public class ChanceField : Field
    {
        private readonly Random _random = new Random();

        public override void LandOn(Player player)
        {
            int chance = _random.Next(1, 4); 
            switch (chance)
            {
                case 1:
                    player.AddMoney(100);
                    Console.WriteLine("Player received 100 dollars from Chance.");
                    break;
                case 2:
                    player.SubtractMoney(50);
                    Console.WriteLine("Player lost 50 dollars from Chance.");
                    break;
                case 3:
                    player.MoveTo(0); 
                    Console.WriteLine("Player moved to Go field from Chance.");
                    break;
            }
        }
    }
}
