using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Map.GameProperties
{
    public class Railroad : PropertyComponent
    {
        public override string Name { get; }
        public override string Color => "Railroad";
        public override int Price { get; }
        public override int Rent { get; }
        public int OwnedCount { get; set; }
        public override Player Owner { get; set; }

        public Railroad(string name, int price, int rent)
        {
            Name = name;
            Price = price;
            Rent = rent;
            OwnedCount = 0;
        }

        public override void LandOn(Player player)
        {
            if (Owner == null)
            {
                if (player.Money >= Price)
                {
                    player.BuyProperty(this);
                    Owner = player;
                    OwnedCount++;
                }
                else
                {
                    Console.WriteLine($"{player.Name} не имеет возможности купить {Name}.");
                }
            }
            else if (Owner != player)
            {
                int currentRent = Rent * (int)Math.Pow(2, OwnedCount - 1);
                Console.WriteLine($"Player landed on {Name}. Rent: {currentRent}");
                player.PayRent(Owner, currentRent);
            }
            else
            {
                Console.WriteLine($"{player.Name} уже владеет {Name}.");
            }
        }
    }
}
