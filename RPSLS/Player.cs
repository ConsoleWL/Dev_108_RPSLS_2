using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal abstract class Player
    {
        //Member Variabes (HAS A)
        public string name;
        public int score;
        public Gesture chosenGesture;

        public List<Gesture> gestures = new List<Gesture>();
        public Gesture rock = new Gesture("rock");
        public Gesture paper = new Gesture("paper");
        public Gesture scissors = new Gesture("scissors");
        public Gesture lizard = new Gesture("lizard");
        public Gesture spock = new Gesture("spock");

        //Constructor
        public Player(string name)
        {
            this.name = name;
            score = 0;

            gestures.Add(rock);
            gestures.Add(paper);
            gestures.Add(scissors);
            gestures.Add(lizard);
            gestures.Add(spock);
        }

        //Member Methods (CAN DO)
        //This abstract method must be overridden by the child Player classes
        public abstract void ChooseGesture();
    }
}
