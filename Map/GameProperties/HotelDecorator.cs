using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Map.GameProperties
{
    public class HotelDecorator : PropertyDecorator
    {
        public override int Rent => component.Rent + 100; // Увеличиваем ренту на 100

        public override void LandOn(Player player)
        {
            component.LandOn(player);
            Console.WriteLine($"Бонус отеля: Рента увеличена до {Rent}");
        }
    }
}
