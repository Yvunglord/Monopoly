using Monopoly.Map.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Map.GameProperties
{
    public abstract class PropertyComponent : IGameElement
    {
        public abstract string Name { get; }
        public abstract string Color { get; }
        public abstract int Price { get; }
        public abstract int Rent { get; }
        public abstract void LandOn(Player player);
        public abstract Player Owner { get; set; }
    }
}
