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

            while (currentPlayerPosition != 100)
            {
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
                        if (currentPlayerPosition < 0)
                            currentPlayerPosition = 0;
                        break;
                }

                // Check if the player's position goes above 100
                if (currentPlayerPosition > 100)
                {
                    Console.WriteLine("Player cannot move beyond position 100. Stay in the previous position.");
                    currentPlayerPosition -= dieRoll;
                }

                // Print the current position of the player
                Console.WriteLine("Player position: " + currentPlayerPosition);
            }

            Console.WriteLine("Congratulations! Player reached the exact winning position of 100.");
        }
    }
}
