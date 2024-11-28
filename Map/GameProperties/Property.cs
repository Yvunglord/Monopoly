using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Map.GameProperties
{
    public class Property : PropertyComponent
    {
        public override string Name { get; }
        public override string Color { get; }
        public override int Price { get; }
        public override int Rent { get; }
        public bool HasFullSet { get; set; }
        public int HouseCount { get; set; }
        public int[] HousePrices { get; set; }
        public int HotelPrice { get; set; }
        public int[] HouseRents { get; set; }
        public int HotelRent { get; set; }
        public override Player Owner { get; set; }

        public Property(string name, string color, int price, int rent, int[] housePrices, int hotelPrice, int[] houseRents, int hotelRent)
        {
            Name = name;
            Color = color;
            Price = price;
            Rent = rent;
            HasFullSet = false;
            HouseCount = 0;
            HousePrices = housePrices;
            HotelPrice = hotelPrice;
            HouseRents = houseRents;
            HotelRent = hotelRent;
        }

        public override void LandOn(Player player)
        {
            if (Owner == null)
            {
                if (player.Money >= Price)
                {
                    player.BuyProperty(this);
                    Owner = player;
                }
                else
                {
                    Console.WriteLine($"{player.Name} cannot afford to buy {Name}.");
                }
            }
            else if (Owner != player)
            {
                PropertyComponent decoratedProperty = this;

                if (HasFullSet)
                {
                    decoratedProperty = new FullSetDecorator { component = decoratedProperty };
                }

                if (HouseCount > 0)
                {
                    decoratedProperty = new HouseDecorator { component = decoratedProperty };
                }

                if (HouseCount == 4)
                {
                    decoratedProperty = new HotelDecorator { component = decoratedProperty };
                }

                player.PayRent(Owner, decoratedProperty.Rent);
            }

            else
            {
                Console.WriteLine($"{player.Name} already owns {Name}.");
            }
        }
    }
}
