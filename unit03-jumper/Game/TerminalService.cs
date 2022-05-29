using System;
using System.Collections.Generic;
namespace jumper
{
    public class TerminalService
    {
        //atributes
        public TerminalService(){}
        public void PrintPerson()
        {
            Console.WriteLine(@"  /|\");
            Console.WriteLine(@"  / \");
            Console.WriteLine("");
            Console.WriteLine(@"^^^^^^^");
        }
        public void PrintParachute(List<bool> parachute)
        {   
            List<string> RealParachute = new List<string>{"  ___  ",@" /___\ ",@" \   / ",@"  \0/  "};
            List<string> DeadParachute = new List<string>{"","","","   x   "};
            for(int i=0;i<4;i++)
            {   if(parachute[i]==true)
                {   
                    Console.WriteLine(RealParachute[i]);
                }
                else
                {
                    Console.WriteLine(DeadParachute[i]);
                }
            }
            
        }
        public void PrintGuess(string guess)
        {
            Console.WriteLine(guess);
        }
    }
}
