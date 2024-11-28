using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Map.GameProperties
{
    public class PropertyDecorator : PropertyComponent
    {
        public PropertyComponent component;

        public void SetComponent(PropertyComponent component)
        {
            this.component = component;
        }

        public override string Name => component.Name;
        public override string Color => component.Color;
        public override int Price => component.Price;
        public override int Rent => component.Rent;
        public override Player Owner { get; set; }

        public override void LandOn(Player player)
        {
            if (component != null)
            {
                component.LandOn(player);
            }
        }
    }
}
