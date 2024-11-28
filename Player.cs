using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Map.GameProperties;

namespace Monopoly
{
    public class Player
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public bool IsInJail { get; set; } = false;
        public int Position { get; set; }
        public List<PropertyComponent> OwnedProperties { get; set; }
        public int JailTurns { get; set; }

        public Player(string name, int startingMoney)
        {
            Name = name;
            Money = startingMoney;
            IsInJail = false;
            Position = 0;
            OwnedProperties = new List<PropertyComponent>();
            JailTurns = 0;
        }

        public void MoveTo(int newPosition)
        {
            Position = newPosition;
        }

        public void AddMoney(int amount)
        {
            Money += amount;
        }

        public void SubtractMoney(int amount)
        {
            Money -= amount;
        }

        public void GoToJail()
        {
            IsInJail = true;
            JailTurns = 3; 
            MoveTo(10); 
        }

        public void LeaveJail()
        {
            IsInJail = false;
            JailTurns = 0;
        }

        public void BuyProperty(PropertyComponent property)
        {
            OwnedProperties.Add(property);
            SubtractMoney(property.Price);
            Console.WriteLine($"{Name} купил {property.Name} за {property.Price} долларов.");
        }

        public void PayRent(Player owner, int rent)
        {
            SubtractMoney(rent);
            owner.AddMoney(rent);
            Console.WriteLine($"{Name} paid {rent} dollars rent to {owner.Name}.");
        }

        public void PassGo()
        {
            AddMoney(200);
        }

        public bool TryToLeaveJail(Dice dice)
        {
            int roll1 = dice.Roll();
            int roll2 = dice.Roll();
            Console.WriteLine($"{Name} rolled {roll1} and {roll2} to try to leave jail.");

            if (roll1 == roll2)
            {
                LeaveJail();
                Console.WriteLine($"{Name} rolled a double and leaves jail.");
                return true;
            }
            else
            {
                JailTurns--;
                if (JailTurns <= 0)
                {
                    LeaveJail();
                    Console.WriteLine($"{Name} has served their jail time and leaves jail.");
                    return true;
                }
                else
                {
                    Console.WriteLine($"{Name} remains in jail for {JailTurns} more turns.");
                    return false;
                }
            }
        }
    }
}
