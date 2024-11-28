using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Map.GameProperties
{
    public class HouseDecorator : PropertyDecorator
    {
        public override int Rent => component.Rent + 50; // Увеличиваем ренту на 50

        public override void LandOn(Player player)
        {
            component.LandOn(player);
            Console.WriteLine($"Бонус дома: Рента увеличена до {Rent}");
        }
    }
}
