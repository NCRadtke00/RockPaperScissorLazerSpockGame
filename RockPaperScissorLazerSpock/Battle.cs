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
        Player playerOne;
        Player playerTwo;
        Computer computer;
        int playerOneScore;
        int playerTwoScore;
        int computerScore;
        Random rand;

        public Battle()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
            computerScore = 0;
            rand = new Random();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Do we have one person playing or two?");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------- ( 1 ) ----------------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------- ( 2 ) ----------------");
            Console.WriteLine("-------------------------------------");
            string playerResult = Console.ReadLine();
            if (playerResult == "1")
            {
                playerOne = new Player();
                playerTwo = new Player();
                while (playerOneScore < 2 && playerTwoScore < 2)
                {
                    int playerOneGesture = playerOne.PickGesture();
                    int playerTwoGesture = Player.PickGesture();
                    CompareGestures(playerOneGesture, playerTwoGesture);
                }
            }
            else if (playerResult == "2")
            {
                playerOne = new Player();
                computer = new Computer();
                while (playerOneScore < 2 && computerScore < 2)
                {
                    int playerOneGester = playerOne.PickGesture();
                    int playerTwoGester = playerTwo.PickGesture();
                    CompareGestures(playerOne.gesture, playerTwo.gesture);
                }
            }

        }


        public void CompareGestures()
        {
            if (playerOne.gesture == playerTwo.gesture)
            {
                Console.WriteLine("Draw, pick new gestures!");
            }
            else if (playerOne.gesture == "rock")
            {
                if (playerTwo.gesture == "scissors" || playerTwo.gesture == "lizard")
                {
                    playerOneScore++;
                    Console.WriteLine($"Player 1 picked: {playerOne.gesture}. Player 2 picked: {playerTwo.gesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                }
                else
                {
                    playerTwoScore++;
                }
            }
            else if (playerOne.gesture == "scissors")
            {
                if (playerTwo.gesture == "paper" || playerTwo.gesture == "lizard")
                { 
                    playerOneScore++;
                Console.WriteLine($"Player 1 picked: {playerOne.gesture}. Player 2 picked: {playerTwo.gesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                }
                else
                {
                    playerTwoScore++;
                }
            }
            else if (playerOne.gesture == "paper")
            {
                if (playerTwo.gesture == "rock" || playerTwo.gesture == "spock")
                {
                    playerOneScore++;
                    Console.WriteLine($"Player 1 picked: {playerOne.gesture}. Player 2 picked: {playerTwo.gesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                }
                else
                {
                    playerTwoScore++;
                }
            }
            else if (playerOne.gesture == "lizard")
            {
                if (playerTwo.gesture == "spock" || playerTwo.gesture == "paper")
                {
                    playerOneScore++;
                    Console.WriteLine($"Player 1 picked: {playerOne.gesture}. Player 2 picked: {playerTwo.gesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                }
                else
                {
                    playerTwoScore++;
                }
            }
            else if (playerOne.gesture == "spock")
            {
                if (playerTwo.gesture == "scissors" || playerTwo.gesture == "rock")
                {
                    playerOneScore++;
                    Console.WriteLine($"Player 1 picked: {playerOne.gesture}. Player 2 picked: {playerTwo.gesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                }
                else
                {
                    playerTwoScore++;
                }
            }

        }
        public void DisplayWinner()
        {
            if (playerOneScore > playerTwoScore)
            {
                Console.WriteLine("Player 1 wins!");
            }
            else
            {
                Console.WriteLine("Player 2 wins!");
            }
        }
    }
}   
