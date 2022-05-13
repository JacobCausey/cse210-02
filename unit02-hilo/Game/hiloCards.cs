using System;


namespace unit02_hilo.Game
{
    // TODO: Implement the Card class.
    // 1) Add the class declaration.
    class Card 
    {
        public int value = 0;
        public int points = 0;

    // 2) Create the class constructor. Use the following method comment.

        /// <summary>
        /// Constructs a new instance of Die.
        /// </summary>
    public Card()
    {
    }
    
    // 3) Create the Roll() method. Use the following method comment.
    public void Flip()
    {
        Random random = new Random();
        value = random.Next(1, 13);

        if (value == 5)
        {
        points = 50;
        }
        else if (value == 1)
        {
            points = 100;
        }
        else
        {
            points = 0;
        }
    }    
        /// <summary>
        /// Generates a new random value and calculates the points for the die. Fives are 
        /// worth 50 points, ones are worth 100 points, everything else is worth 0 points.
        /// </summary>
    }     
}