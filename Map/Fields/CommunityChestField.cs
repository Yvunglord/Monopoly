using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Map.Fields
{
    public class CommunityChestField : Field
    {
        private readonly Random _random = new Random();

        public override void LandOn(Player player)
        {
            int chance = _random.Next(1, 4); 
            switch (chance)
            {
                case 1:
                    player.AddMoney(50);
                    Console.WriteLine("Player received 50 dollars from Community Chest.");
                    break;
                case 2:
                    player.SubtractMoney(25);
                    Console.WriteLine("Player lost 25 dollars from Community Chest.");
                    break;
                case 3:
                    player.MoveTo(10); 
                    Console.WriteLine("Player moved to another field from Community Chest.");
                    break;
            }
        }
    }
}
