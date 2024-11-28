using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Map.Fields
{
    public class InJailField : Field
    {
        public override void LandOn(Player player)
        {
            if (!player.IsInJail)
            {
                Console.WriteLine("Игорк на экскурсии.");
            }
            else
            {
                Console.WriteLine("Игрок в тюрьме.");
            }
        }
    }
}
