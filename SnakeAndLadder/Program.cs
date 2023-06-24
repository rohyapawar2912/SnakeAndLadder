using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game!");

            // Create a new instance of the dice
            SnakeAndLadderGame snakeandladdergame = new SnakeAndLadderGame();

            // Roll the dice
            int rollResult = snakeandladdergame.Roll();
            Console.WriteLine("Dice roll: " + rollResult);
        }
    }
}
