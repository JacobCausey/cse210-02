using System;
using System.Collections.Generic;

namespace unit02_hilo.Game
{
    public class Director
    {
        public Director()
        {
            for
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
            isPlaying = (cardGuess == "l"|| cardGuess == "h");
        }

        public void DoUpdates()
        {
            if (!isPlaying)
            {
                return;
            }

            score = 0;
            foreach (Card cards in cards)
            {
                card.Flip();
            }
            totalScore += score;
        }

        public void DoOutputs()
        {
            if (!isPlaying)
            {
                return;
            }


            Console.WriteLine($"Your score is: {score}\n");
            isPlaying = (score > 0);
        }
    }
}