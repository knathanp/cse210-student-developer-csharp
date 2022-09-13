using System;
using System.Collections.Generic;
namespace unit02_hilo
{
    public class Card
    {//Responsabilities: Evaulates the guess of the director and changes their score
    //Choose the random numbers and the order of the cards
        public int Value;//it is the card shown 

        public Card(){}
        
        public void MakeCard()
        {   Random random = new Random();
            Value= random.Next(1,14);            
        }
       
        
   
    }
}

        