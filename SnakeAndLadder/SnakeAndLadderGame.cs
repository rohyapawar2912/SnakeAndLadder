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

        public SnakeAndLadderGame()
        {
            currentPlayerPosition = 0;
        }

        public void Play()
        {
            Console.WriteLine("Welcome to Snake and Ladder Game!");

            // Simulate the game logic here

            // Print the final position of the player
            Console.WriteLine("Player position: " + currentPlayerPosition);
        }    
    }
}
