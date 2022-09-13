using System;
using System.Collections.Generic;
namespace jumper
{
    public class Director
    {   
        public bool KeepPlaying = true;
        private Word word = new Word();
        private Jumper jumper = new Jumper();
        private TerminalService display = new TerminalService();
        public Director(){}


        //methods
        public void PlayGame()
        {   while(KeepPlaying)
            {   
                DoInputs();
                DoUpdates();
                DoOutputs();
                
            }
            if(!KeepPlaying)
            {
                display.PrintGuess(word.RightGuess);
                display.PrintParachute(jumper.parachute);
                display.PrintPerson();
            }
        }
        public void DoInputs()
        {   
            display.PrintGuess(word.RightGuess);
            display.PrintParachute(jumper.parachute);
            display.PrintPerson();
            Console.WriteLine("Write a guess [a-z]");
            jumper.ReadGuess();
            Console.WriteLine("\n");
        }
        public void DoUpdates()
        {
            word.UpdateWord(jumper.guess);
            jumper.ChangeParachute(word.EvaluateGuess(jumper.guess));
        }
        public void DoOutputs()
        {
            KeepPlaying = Stop(jumper.life);
        }

        public bool Stop(int life)
        {   
            List<bool> Dead = new List<bool>{false,false,false,false};
            if(life+1==0)
            {
                return false;
            }
            else if(word.StopPlaying(word.RightGuess))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
