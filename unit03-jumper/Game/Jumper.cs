using System;
using System.Collections.Generic;

namespace jumper
{   
    public class Jumper
    {
        //atributes
        public List<bool> parachute = new List<bool>{true,true,true,true};
        public char guess;
        public int life=3;


        //init
        public Jumper(){}
        
        public void ReadGuess()
        {
            guess = char.Parse(Console.ReadLine());
        }
        
        public void ChangeParachute(bool evaluation)
        {
            if(evaluation==false)
            {
                parachute[3-life] = false;
                life = life-1;
            }
        }

   }
}
