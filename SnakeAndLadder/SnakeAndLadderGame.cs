using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeAndLadderGame
    {
        private int currentPlayerPosition;
        private Random random;

        public SnakeAndLadderGame()
        {
            currentPlayerPosition = 0;
            random = new Random();
        }

        public void Play()
        {
            Console.WriteLine("Welcome to Snake and Ladder Game!");

            // Roll the die
            int dieRoll = random.Next(1, 7);
            Console.WriteLine("Die roll: " + dieRoll);

            // Determine the player's option (No Play, Ladder, or Snake) using random number generation
            int option = random.Next(0, 3);

            switch (option)
            {
                case 0: // No Play
                    Console.WriteLine("No Play - Player stays in the same position");
                    break;
                case 1: // Ladder
                    Console.WriteLine("Ladder - Player moves ahead by " + dieRoll + " positions");
                    currentPlayerPosition += dieRoll;
                    break;
                case 2: // Snake
                    Console.WriteLine("Snake - Player moves behind by " + dieRoll + " positions");
                    currentPlayerPosition -= dieRoll;
                    break;
            }

            // Print the final position of the player
            Console.WriteLine("Player position: " + currentPlayerPosition);
        }
    }
}
