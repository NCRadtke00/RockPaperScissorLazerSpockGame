using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLazerSpock
{
    public abstract class  Player
    {
        public string name;
        public int score;
        public string gesture;
        public List<Gesture> moves;

        //public Gestures gesture;
        public Player()
        {
            PickGesture();
        } 
        public void Gestures()
        {
            moves = new List<Gesture>();
            moves.Add(new Gesture("rock"));
            moves.Add(new Gesture("paper"));
            moves.Add(new Gesture("scissors"));
            moves.Add(new Gesture("lizard"));
            moves.Add(new Gesture("spock"));
        }
        public abstract void PickGesture()
        {

            Console.WriteLine("--------------------------------------------------------------------------------------------------------"); Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine("-------------------------   Which move would you like to use first?   ----------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine("------------------------------   ( 1 ) Rock               ----------------------------------------------");
            Console.WriteLine("------------------------------       ( 2 ) Paper          ----------------------------------------------");
            Console.WriteLine("------------------------------           ( 3 ) Scissors   ----------------------------------------------");
            Console.WriteLine("------------------------------       ( 4 ) Lizard         ----------------------------------------------");
            Console.WriteLine("------------------------------   ( 5 ) Spock              ----------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            //// not sure how to get line below to pull from list of Gestures
            ////int result = int.Parse(Console.ReadLine()) - 1;
            //if (output == "1")
            //{
            //    //rock
            //}
            //else if (output == "2")
            //{
            //    //paper
            //}
            //else if (output == "3")
            //{
            //    //scissors
            //}
            //else if (output == "4")
            //{
            //    //lizard
            //}
            //else if (output == "5")
            //{
            //    //spock
            //}
            //else
            //{
            //    Console.WriteLine("You must make a move!");
            //}
        }

    }
}
