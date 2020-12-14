using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        //member variables (HAS A)
        public List<string> gestures;
        public int score;
        public string chosenGesture;

        //constructor
        public Player()
        {           
            gestures = new List<string>() { "ROCK", "PAPER", "SCISSOR", "LIZARD", "SPOCK" };                 
        }

        //member methods (CAN DO)

        public virtual void SelectGesture()
        {

        }
    }
}
