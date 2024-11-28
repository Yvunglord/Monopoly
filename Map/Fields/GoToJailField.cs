using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Map.Fields
{
    public class GoToJailField : Field
    {
        public override void LandOn(Player player)
        {
            player.GoToJail();
            Console.WriteLine("Игрок отправляется в тюрьму.");
        }
    }
}
