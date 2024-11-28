using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Map.Fields
{
    public abstract class Field : IField
    {
        public abstract void LandOn(Player player);
    }
}
