using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace rock_papaer_scissors
{
    internal class Game
    {
        private string userInput;
        private string computerInput;
        public void PlayGame(UserPlayer player1, ComputerPlayer player2)
        {

            userInput = player1.GetUserInput();
            computerInput = player2.GetComputerInput();

            if (userInput != computerInput)
            {
                if (userInput == "Scissors" && computerInput == "Paper")
                {
                    Console.WriteLine("User wins");
                }

                else if (userInput == "Scissors" && computerInput == "Rock")
                {
                    Console.WriteLine("Computer wins");
                }

                else if (userInput == "Paper" && computerInput == "Scissors")
                {
                    Console.WriteLine("Computer wins");
                }

                else if (userInput == "Paper" && computerInput == "Rock")
                {
                    Console.WriteLine("User wins");
                }

                else if (userInput == "Rock" && computerInput == "Scissors")
                {
                    Console.WriteLine("User wins");
                }
                else if (userInput == "Rock" && computerInput == "Paper")
                {
                    Console.WriteLine("Computer wins");
                }
            }
            else
            {
                Console.WriteLine("Replay");
                player1.SetUserInput();
                PlayGame(player1, player2);
            }
        }
    }
}
