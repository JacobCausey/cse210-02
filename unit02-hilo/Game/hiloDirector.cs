using System;
using System.Collections.Generic;

namespace unit02_hilo.Game
{
    public class Director
    {
        List<Card> cards = new List<cards>();
        bool isPlaying = true;
        int score = 300;
        int totalScore = 300;

        public Director()
        {
            for (int i = 0; i < 5; i++)
            {
                Card card = new Card();
                card.Add(card[cardSelection]);
            }
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
            Console.Write("Roll dice? [y/n] ");
            string rollDice = Console.ReadLine();
            isPlaying = (rollDice == "y");
        }

        /// <summary>
        /// Updates the player's score.
        /// </summary>
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

            string values = "";
            foreach (Card cards in card)
            {
            }

            Console.WriteLine($"Your score is: {score}\n");
            isPlaying = (score > 0);
        }
    }
}