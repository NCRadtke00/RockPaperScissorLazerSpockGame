using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLazerSpock
{
    class Battle
    {
        public Battle()
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
            public void RunTwoPlayerMode()
            {

            }
            public void CompareMoves()
            {

            }
        }
    }
}
