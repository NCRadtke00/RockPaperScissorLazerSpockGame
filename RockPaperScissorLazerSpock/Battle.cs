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
        public void PickAttackMove()
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
        public void CompareMoves()
        {
            if (rock > scissors)
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
            else if (Rock > Lizard)
            {
                Console.WriteLine("Rock crushes Lizard");
            }
            else if (Lizard > Spock)
            {
                Console.WriteLine("Lizard poisons Spock");
            }
            else if (Spock > Scissors)
            {
                Console.WriteLine("Spock smashes Scissors");
            }
            else if (Scissors > Lizard)
            {
                Console.WriteLine("Scissors decapitates Lizard");
            }
            else if (Lizard > Paper)
            {
                Console.WriteLine("Lizard eats Paper");
            }
            else if (Paper > Spock)
            {
                Console.WriteLine("Paper disproves Spock");
            }
            else if (Spock > Rock)
            {
                Console.WriteLine("Spock vaporizes Rock");
            }
            else
            {
                CompareMoves();
            }
        }
        public void DisplayWinner()
        {
                //best of 3
        }
    }

}   
