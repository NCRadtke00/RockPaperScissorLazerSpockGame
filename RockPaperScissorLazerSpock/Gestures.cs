using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLazerSpock
{
    class Gestures
    {
        public List<Gesture> moves;
        public Gestures()
        {
            moves = new List<Gesture>();
            moves.Add(new Gesture("rock"));
            moves.Add(new Gesture("paper"));
            moves.Add(new Gesture("scissors"));
            moves.Add(new Gesture("lizard"));
            moves.Add(new Gesture("spock"));
        }
    }
}
}
