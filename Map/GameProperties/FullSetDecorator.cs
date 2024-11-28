using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Map.GameProperties
{
    public class FullSetDecorator : PropertyDecorator
    {
        public override int Rent => component.Rent * 2; // Увеличиваем ренту вдвое

        public override void LandOn(Player player)
        {
            component.LandOn(player);
            Console.WriteLine($"Бонус отеля: Рента увеличена до {Rent}");
        }
    }

}
