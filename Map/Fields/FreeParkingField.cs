using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Map.Fields
{
    public class FreeParkingField : Field
    {
        public override void LandOn(Player player)
        {
            Console.WriteLine("Игрок на бесплатной стоянке. Ничего не произошло.");
        }
    }
}
