using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Map.Fields
{
    public class GoField : Field
    {
        public override void LandOn(Player player)
        {
            player.AddMoney(200);
            Console.WriteLine("Игрок получает 200 долларов");
        }
    }
}
