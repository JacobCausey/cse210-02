using System;


namespace unit02_hilo.Game
{
    
   class Card
    {
        public int value = 0;
        public int previousCardValue = 0;

        public string difference = "";

        public Card()
    {
    }
    public void Flip()
    {  
        Random rand = new Random();
        
        value = rand.Next(0,14);

        if (value > previousCardValue)
        {
            difference = "h";
        }
        else if (value < previousCardValue)
        {    
            difference = "l";
        }

        previousCardValue = value;
        Console.WriteLine(difference);
        Console.WriteLine(value);
        Console.WriteLine(previousCardValue);
    }
    }

}