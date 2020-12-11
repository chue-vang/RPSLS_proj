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
    }
}
