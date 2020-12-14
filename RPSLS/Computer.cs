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

        public override void SelectGesture()
        {
            Random random = new Random();
            chosenGesture = gestures[random.Next(0, 4)];
            Console.WriteLine("Computer selects " + chosenGesture);
        }      
    }
}

