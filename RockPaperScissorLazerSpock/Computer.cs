using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLazerSpock
{
    class Computer : Player
    {
        public int score;
        public Computer()
        {
           
        }
        public override void PickGesture()
        {
            int randomNumber = RandomNumber(0, 4);
            gesture = gestures[randomNumber];
        }
        int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
