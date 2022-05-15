using System;
using System.Collections.Generic;

namespace unit02_hilo.Game
{
    public class Director
    {
        bool isPlaying = true;
        PlayerInput playerInput = new();
        Score score = new Score();

        public Director()
        {
        }
        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates(playerInput.cardGuess, Score.playerScore);
                DoOutputs();
            }
        }

        public void GetInputs()
        {
            Console.Write("Higher or Lower [l/h] ");
            playerInput.cardGuess = Convert.ToChar(Console.ReadLine());
        }

        public void DoUpdates(char cardGuess, int score)
        {
            Card card = new();
            
            if (cardGuess == card.difference)
            {
                score += 100;
            }
            else if (cardGuess != card.difference)
            {
                score -= 75;
            }
            if (score <= 0 || playAgain == 'n')
            {
                isPlaying = false;
            }
        }

        public void DoOutputs()
        {
            if (!isPlaying)
            {
                return;
            }

            Console.WriteLine($"Your score is: {score}\n");
            Console.WriteLine("Play Again? [y/n]");
            char playAgain = Convert.ToChar(Console.ReadLine());
        }
    }
}