using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        //member variables(HAS A)



        //constructor
        public Computer()
        {

        }

        //member methods(CAN DO)

        //what can a computer player do??
        //it can use random gestures

        public void ComputerSelectGesture()
        {
            Console.WriteLine("Computer, please select your gesture from the list: Rock=1, Paper=2, Scissor=3, Lizard=4, Spock=5");
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine((i + 1) + " " + gestures[i]);
            }


            //method not complete
            //need to generate a random number from 1 - 5
        }

    }
}
