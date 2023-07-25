using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class ComputerPlayer : Player
    {
        Random rnd = new Random();
        int number;
        public ComputerPlayer(string name) : base(name)
        {
        }

        public override void ChooseGesture()
        {
            number = rnd.Next(0, 5);

            if (number == 0)
            {
                chosenGesture = gestures[0];
                Console.WriteLine($"{name} chooses {chosenGesture}");
            }
            else if (number == 1)
            {
                chosenGesture = gestures[1];
                Console.WriteLine($"{name} chooses {chosenGesture}");
            }
            else if (number == 2)
            {
                chosenGesture = gestures[2];
                Console.WriteLine($"{name} chooses {chosenGesture}");
            }
            else if (number == 3)
            {
                chosenGesture = gestures[3];
                Console.WriteLine($"{name} chooses {chosenGesture}");
            }
            else if (number == 4)
            {
                chosenGesture = gestures[4];
                Console.WriteLine($"{name} chooses {chosenGesture}");
            }
        }
    }
}
