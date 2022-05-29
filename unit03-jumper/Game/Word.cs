using System;
using System.Collections.Generic;
using System.Text;

namespace jumper
{   /// <summary>
    /// <para>The person hiding from the Seeker.</para>
    /// <para>
    /// The responsibility of Guessed is to keep track of the letters typed and evaluate the Guessed.
    /// </para>
    /// </summary>
    public class Word
    {
        //atributes
        public bool evaluation;
        public string RightGuess = "_____";
        private string word="";
        public Word()
        {
            //random wordGetWord();
            word = "seven";
        }

        /// <summary>
        /// Whether or not the guesser has guess right.
        /// </summary>
        /// <returns> a string with the correct guesses</returns>
        public void UpdateWord(char guess)
        {   
            for(int i=0;i<5;i++)
            {   
                if(word[i]==guess)
                {
                    char replacement = guess;
                    char[] chars = RightGuess.ToCharArray();
                    chars[i] = replacement;
                    RightGuess = new string(chars);
 
                }
            }
        }
        
        public bool EvaluateGuess(char guess)
        {            
            for(int i=0;i<5;i++)
            {   
                if(word[i]==guess)
                {
                   return true; 
                }                
            }
            return false;
        }
        /// <summary>
        /// Choose a random word that will be guessed
        /// </summary>
        /// <returns> a string with a 5 letter word</returns>

        public bool StopPlaying(string CurrentWord)
        {   if(CurrentWord==word)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void GetWord()
        {   Random random = new Random();
            int Value = random.Next(1,212); 
            List<string> ListWords = new List<string>();
            ListWords.Add("abuse");
            ListWords.Add("adult");
            ListWords.Add("agent");
            ListWords.Add("anger");
            ListWords.Add("apple");
            ListWords.Add("award");
            ListWords.Add("basis");
            ListWords.Add("beach");
            ListWords.Add("birth");
            ListWords.Add("block");
            ListWords.Add("blood");
            ListWords.Add("board");
            ListWords.Add("brain");
            ListWords.Add("bread");
            ListWords.Add("break");
            ListWords.Add("brown");
            ListWords.Add("buyer");
            ListWords.Add("Cause");
            ListWords.Add("chain");
            ListWords.Add("chair");
            ListWords.Add("chest");
            ListWords.Add("chief");
            ListWords.Add("child");
            ListWords.Add("china");
            ListWords.Add("claim");
            ListWords.Add("class");
            ListWords.Add("clock");
            ListWords.Add("coach");
            ListWords.Add("coast");
            ListWords.Add("court");
            ListWords.Add("cover");
            ListWords.Add("cream");
            ListWords.Add("crime");
            ListWords.Add("cross");
            ListWords.Add("crowd");
            ListWords.Add("crown");
            ListWords.Add("cycle");
            ListWords.Add("cance");
            ListWords.Add("ceath");
            ListWords.Add("cepth");
            ListWords.Add("doubt");
            ListWords.Add("draft");
            ListWords.Add("drama");
            ListWords.Add("dream");
            ListWords.Add("dress");
            ListWords.Add("drink");
            ListWords.Add("drive");
            ListWords.Add("earth");
            ListWords.Add("enemy");
            ListWords.Add("entry");
            ListWords.Add("error");
            ListWords.Add("event");
            ListWords.Add("faith");
            ListWords.Add("fault");
            ListWords.Add("field");
            ListWords.Add("fight");
            ListWords.Add("final");
            ListWords.Add("floor");
            ListWords.Add("focus");
            ListWords.Add("force");
            ListWords.Add("frame");
            ListWords.Add("frank");
            ListWords.Add("front");
            ListWords.Add("fruit");
            ListWords.Add("Glass");
            ListWords.Add("grant");
            ListWords.Add("grass");
            ListWords.Add("green");
            ListWords.Add("group");
            ListWords.Add("guide");
            ListWords.Add("heart");
            ListWords.Add("henry");
            ListWords.Add("horse");
            ListWords.Add("hotel");
            ListWords.Add("house");
            ListWords.Add("image");
            ListWords.Add("index");
            ListWords.Add("input");
            ListWords.Add("issue");
            ListWords.Add("japan");
            ListWords.Add("jones");
            ListWords.Add("judge");
            ListWords.Add("knife");
            ListWords.Add("laura");
            ListWords.Add("layer");
            ListWords.Add("level");
            ListWords.Add("lewis");
            ListWords.Add("light");
            ListWords.Add("limit");
            ListWords.Add("lunch");
            ListWords.Add("major");
            ListWords.Add("march");
            ListWords.Add("match");
            ListWords.Add("metal");
            ListWords.Add("model");
            ListWords.Add("money");
            ListWords.Add("month");
            ListWords.Add("motor");
            ListWords.Add("mouth");
            ListWords.Add("music");
            ListWords.Add("night");
            ListWords.Add("noise");
            ListWords.Add("north");
            ListWords.Add("novel");
            ListWords.Add("nurse");
            ListWords.Add("offer");
            ListWords.Add("order");
            ListWords.Add("other");
            ListWords.Add("owner");
            ListWords.Add("panel");
            ListWords.Add("paper");
            ListWords.Add("party");
            ListWords.Add("peace");
            ListWords.Add("peter");
            ListWords.Add("phase");
            ListWords.Add("phone");
            ListWords.Add("piece");
            ListWords.Add("pilot");
            ListWords.Add("pitch");
            ListWords.Add("place");
            ListWords.Add("plane");
            ListWords.Add("plant");
            ListWords.Add("plate");
            ListWords.Add("point");
            ListWords.Add("pound");
            ListWords.Add("power");
            ListWords.Add("press");
            ListWords.Add("price");
            ListWords.Add("pride");
            ListWords.Add("prize");
            ListWords.Add("proof");
            ListWords.Add("queen");
            ListWords.Add("radio");
            ListWords.Add("range");
            ListWords.Add("ratio");
            ListWords.Add("reply");
            ListWords.Add("right");
            ListWords.Add("river");
            ListWords.Add("round");
            ListWords.Add("route");
            ListWords.Add("rugby");
            ListWords.Add("scale");
            ListWords.Add("scene");
            ListWords.Add("scope");
            ListWords.Add("score");
            ListWords.Add("sense");
            ListWords.Add("shape");
            ListWords.Add("share");
            ListWords.Add("sheep");
            ListWords.Add("sheet");
            ListWords.Add("shift");
            ListWords.Add("shirt");
            ListWords.Add("shock");
            ListWords.Add("sight");
            ListWords.Add("simon");
            ListWords.Add("skill");
            ListWords.Add("sleep");
            ListWords.Add("smile");
            ListWords.Add("smith");
            ListWords.Add("smoke");
            ListWords.Add("sound");
            ListWords.Add("south");
            ListWords.Add("space");
            ListWords.Add("speed");
            ListWords.Add("spite");
            ListWords.Add("sport");
            ListWords.Add("squad");
            ListWords.Add("staff");
            ListWords.Add("stage");
            ListWords.Add("start");
            ListWords.Add("state");
            ListWords.Add("steam");
            ListWords.Add("steel");
            ListWords.Add("stock");
            ListWords.Add("stone");
            ListWords.Add("store");
            ListWords.Add("study");
            ListWords.Add("stuff");
            ListWords.Add("style");
            ListWords.Add("sugar");
            ListWords.Add("table");
            ListWords.Add("taste");
            ListWords.Add("terry");
            ListWords.Add("theme");
            ListWords.Add("thing");
            ListWords.Add("title");
            ListWords.Add("total");
            ListWords.Add("touch");
            ListWords.Add("tower");
            ListWords.Add("track");
            ListWords.Add("trade");
            ListWords.Add("train");
            ListWords.Add("trend");
            ListWords.Add("trial");
            ListWords.Add("trust");
            ListWords.Add("truth");
            ListWords.Add("uncle");
            ListWords.Add("union");
            ListWords.Add("unity");
            ListWords.Add("value");
            ListWords.Add("video");
            ListWords.Add("visit");
            ListWords.Add("voice");
            ListWords.Add("waste");
            ListWords.Add("watch");
            ListWords.Add("water");
            ListWords.Add("while");
            ListWords.Add("white");
            ListWords.Add("whole");
            ListWords.Add("woman");
            ListWords.Add("world");
            ListWords.Add("youth"); 
            word = ListWords[Value];
        }

    }
}
