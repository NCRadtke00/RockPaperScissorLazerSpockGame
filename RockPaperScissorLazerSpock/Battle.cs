using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLazerSpock
{
    class Battle
    {
        public Battle()
        {

            Console.WriteLine("Do we have one person playing or two?");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------- ( 1 ) ----------------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------- ( 2 ) ----------------");
            Console.WriteLine("-------------------------------------");
            string playerResult = Console.ReadLine();
            if (playerResult == "1")
            {
                RunSinglePlayerMode()
                }
            else if (playerResult == "2")
            {
                RunTwoPlayerMode();
            }
        }
        public void RunSinglePlayerMode()
        {

        }
        public string SetPlayerOneGesture(string gesture)
        {

        }
        public string SetPlayerTwoGesture(string playerTwoGesture)
        {
            if (playerTwo = true)
            {
                //same guts as SetPlayerOneGesture
            }
             else
            {
                return rand.Next(Gesture.moves[0]);
            }
        }
        public void PickGesture(string gesture)
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
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
            string output = Console.ReadLine();
            if (output == "1")
            {

            }
            else if (output == "2")
            {

            }
            else if (output == "3")
            {

            }
            else if (output == "4")
            {

            }
            else if (output == "5")
            {

            }
            else
            {
                PickAttackMove();
            }
        }
        public void RunTwoPlayerMode()
        {

        }
        public void CompareGestures()
        {
            if (playerOneGesture == playerTwoGesture)
            {
                Console.WriteLine("Draw, pick new gestures!");
            }
            else if (playerOneGesture > playerTwoGesture)
            {
                Console.WriteLine($"Player 1 picked: {playerOneGesture}. Player 2 picked: {playerTwoGesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                playerOneScore++;
                Console.WriteLine("Player one out rolled player two!");
            }
            else
            {
                Console.WriteLine($"Player 2 picked: {playerTwoGesture}. Player 1 picked: {playerOneGesture}. Player 2 score is currently: {playerTwoScore}. Player 1 score is currently: {playerOneScore}.");
                playerTwoScore++;
                Console.WriteLine("Player two out rolled player one!");
            }
        }
        public void RulesOfBattle(string rock, string scissors, string paper, string lizard, string spock)
        {
            if (rock == rock || lizard == lizard || paper == paper || scissors == scissors || spock == spock)
            {
                Console.WriteLine("Draw Try again!");
            }
            else if (rock > scissors)
            {
                Console.WriteLine("Rock crushes Scissors");
            }
            else if (scissors > paper)
            {
                Console.WriteLine("Scissors cuts Paper!");
            }
            else if (paper > rock)
            {
                Console.WriteLine("Paper covers Rock!");
            }
            else if (rock > lizard)
            {
                Console.WriteLine("Rock crushes Lizard");
            }
            else if (lizard > spock)
            {
                Console.WriteLine("Lizard poisons Spock");
            }
            else if (spock > scissors)
            {
                Console.WriteLine("Spock smashes Scissors");
            }
            else if (scissors > lizard)
            {
                Console.WriteLine("Scissors decapitates Lizard");
            }
            else if (lizard > paper)
            {
                Console.WriteLine("Lizard eats Paper");
            }
            else if (paper > spock)
            {
                Console.WriteLine("Paper disproves Spock");
            }
            else if (spock > rock)
            {
                Console.WriteLine("Spock vaporizes Rock");
            }

        }
        public void DisplayWinner()
        {
                //best of 3
        }
    }

}   
