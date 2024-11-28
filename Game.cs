using Monopoly.Map;
using Monopoly.Map.GameProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Game
    {
        private Player[] players;
        private Dice dice;
        private int currentPlayerIndex;

        public Game()
        {
            players = new Player[]
            {
            new Player("Егор", 1500),
            new Player("Миша", 1500)
            };
            dice = new Dice();
            currentPlayerIndex = 0;
            GameBoard.InitializeBoard();
        }

        public void Play()
        {
            while (true)
            {
                Player currentPlayer = players[currentPlayerIndex];

                if (currentPlayer.IsInJail)
                {
                    if (!currentPlayer.TryToLeaveJail(dice))
                    {
                        currentPlayerIndex = (currentPlayerIndex + 1) % players.Length;
                        continue;
                    }
                }

                int roll = dice.Roll();
                Console.WriteLine($"{currentPlayer.Name} походил на {roll}");

                int newPosition = (currentPlayer.Position + roll) % 40;
                currentPlayer.MoveTo(newPosition);

                if (newPosition < currentPlayer.Position)
                {
                    currentPlayer.PassGo();
                }

                IGameElement field = GameBoard.GetField(newPosition);
                field.LandOn(currentPlayer);

                Console.WriteLine($"{currentPlayer.Name} сейчас на {field.GetType().Name}. Позиция: {newPosition}");

                if (currentPlayer.Money <= 0)
                {
                    Console.WriteLine($"{currentPlayer.Name} банкрот. Игра закончена.");
                    break;
                }

                if (AreAllPropertiesOwned())
                {
                    Console.WriteLine("Все собственности куплены. Игра закончена");
                    Console.WriteLine($"Победил {GetWinner().Name}!");
                    break;
                }

                currentPlayerIndex = (currentPlayerIndex + 1) % players.Length;
            }
        }

        private bool AreAllPropertiesOwned()
        {
            foreach (var field in GameBoard.GetAllFields())
            {
                if (field is PropertyComponent property && property.Owner == null)
                {
                    return false;
                }
            }
            return true;
        }

        private Player GetWinner()
        {
            Player winner;
            winner = players[0].Money >= players[1].Money ? players[0] : players[1];
            return winner;
        }
    }

}
