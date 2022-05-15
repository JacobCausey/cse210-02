using System;


namespace unit02_hilo.Game
{
    
   public class Card
    {
        public int value = 0;
        public int previousCardValue = 0;

        public char difference = ' ';

        public Card()
    {
    }

    public void Flip()
    {  
        Random rand = new Random();
        
        value = rand.Next(0,14);

        // guess = 'h'
        // value = 4
        // previousCardValue = 6

        if (value > previousCardValue)
        {
            difference = 'h';
        }
        else if (value < previousCardValue)
        {    
            difference = 'l';
        }

        previousCardValue = value;
    }
    }

}