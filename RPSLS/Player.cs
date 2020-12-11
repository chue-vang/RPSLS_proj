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
            gestures = new List<string>() { "rock", "paper", "scissor", "lizard", "spock" };
            
           
        }

        //member methods (CAN DO)

        //what can a player do??
        //players can use all the gestures
        //a player can win or lose

        // TO DO
        // see a list of gestures
        // choose a gesture
        // gestures can be compared - where will they be compared?

        //rock crushes <i> if <i>=scissors OR lizard, but loses to everything else
        //scissors cuts <i> if <i>=paper OR lizard, but loses to everything else
        //paper covers/disproves <i> if <i>=paper OR Spock, but loses to everything else
        //lizard poinson/eats <i> if <i>=Spock OR paper, but loses to everything else
        //Spock smashes/vaporizes <i> if <i>=scissors OR rok, but loses to everything else





    }
}
