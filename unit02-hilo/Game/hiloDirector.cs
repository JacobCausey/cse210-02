using System;
using System.Collections.Generic;

namespace unit02_hilo.Game
{
    public class Director
    {
        bool isPlaying = true;
        int score = 0;

        public Director()
        {
        }
        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        public void GetInputs()
        {
            Console.Write("Higher or Lower [l/h] ");
            string cardGuess = Console.ReadLine();
        }

        public void DoUpdates(string cardGuess, int score, string Card.difference)
        {
            if (cardGuess == Card.difference)
            {
                score += 100;
            }
            else if (cardGuess != Card.difference)
            {
                score -= 75;
            }
            if (score >= 0 || DoOutputs.playAgain == 'n')
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
            string playAgain = Console.ReadLine();
        }
    }
}