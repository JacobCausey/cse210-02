using System;
using System.Collections.Generic;


namespace unit02_hilo.Game
{
    public class Director
    {
        List<Card> cards = new List<Card>();
        bool isPlaying = true;
        int score = 300;
        int totalScore = 0;

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            for (int i = 0; i < 13; i++)
            {
                Card card = new Card();
                cards.Add(card);
            }
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Asks the user if they want to roll.
        /// </summary>
        public void GetInputs()
        {
            Console.Write("Higher or Lower? [h/l] ");
            string flipCard = Console.ReadLine();
            isPlaying = (cardGuess == "h" || cardGuess == "l");
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
            foreach (Card card in cards)
            {
                card.Roll();
                score += card.points;
            }
            totalScore += score;
        }

        /// <summary>
        /// Displays the dice and the score. Also asks the player if they want to roll again. 
        /// </summary>
        public void DoOutputs()
        {
            if (!isPlaying)
            {
                return;
            }

            string values = "";
            foreach (Card card in cards)
            {
                values += $"{card.value} ";
            }

            Console.WriteLine($"Your score: {values}");
            isPlaying = (score > 0);
        }
    }
}