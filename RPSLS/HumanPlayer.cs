using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
        {
            
        }
        public override void ChooseGesture()
        {
            Console.WriteLine($"\n{name}, chooses an options: ");
            while (true)
            {
                for (int i = 0; i < gestures.Count; i++)
                {
                    Console.WriteLine($"Press: {i + 1} for {gestures[i]}");
                }
                string tempGesture = Console.ReadLine();

                if (tempGesture == "1")
                {
                    chosenGesture = gestures[0];
                    Console.WriteLine($"{name} chooses {chosenGesture.name}");
                    break;
                }
                else if (tempGesture == "2")
                {
                    chosenGesture = gestures[1];
                    Console.WriteLine($"{name} chooses {chosenGesture.name}");
                    break;
                }
                else if (tempGesture == "3")
                {
                    chosenGesture = gestures[2];
                    Console.WriteLine($"{name} chooses {chosenGesture.name}");
                    break;
                }
                else if (tempGesture == "4")
                {
                    chosenGesture = gestures[3];
                    Console.WriteLine($"{name} chooses {chosenGesture.name}");
                    break;
                }
                else if (tempGesture == "5")
                {
                    chosenGesture = gestures[4];
                    Console.WriteLine($"{name} chooses {chosenGesture.name}");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input, try again");
                }
            }
        }
    }
}
