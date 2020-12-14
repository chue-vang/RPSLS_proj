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

        public void RandomComputerChoice()
        {
            Random random = new Random();
            chosenGesture = gestures[random.Next(0, 4)];
            Console.WriteLine("Computer throws " + chosenGesture);
        }

        //public int GenerateRandomNumber()
        //{
        //    int genRandom = rand.Next(1, 5);
        //    //Console.WriteLine("random number = " +genRandom);
        //    return genRandom;
        //}
      
    }
}

