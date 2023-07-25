using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class ListOfGestures
    {
        public List<Gesture> gestures = new List<Gesture>();

        public Gesture rock = new Gesture("rock");
        public Gesture paper = new Gesture("paper");
        public Gesture scissors = new Gesture("scissors");
        public Gesture lizard = new Gesture("lizard");
        public Gesture spock = new Gesture("spock");
        public ListOfGestures()
        {
            gestures.Add(rock);
            gestures.Add(paper);
            gestures.Add(scissors);
            gestures.Add(lizard);
            gestures.Add(spock);
        }
    }
}
