using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        //member variables (HAS A)
        public int computerPlayerTwo;


        //constructor
        public Computer(int ComputerPlayerTwo)
        {
            this.computerPlayerTwo = ComputerPlayerTwo;
        }
        
        //member methods (CAN DO)

        //what can a computer player do??
        //it can use random gestures

        public void ComputerSelectGesture (Player randomGesture)
        {
            Console.WriteLine("Computer player, please select your gesture from the list: Rock=0, Paper=2, Scissor=3, Lizard=4, Spock=5");
            foreach(string gestures in gestures)
                Console.WriteLine(gestures);
            //
            //method not complete
            //need to generate a random number from 0-4
        }

    }
}
