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

            userInput = player1.GetUserInput().ToLower();
            computerInput = player2.GetComputerInput();

            if (userInput != computerInput)
            {
                if (userInput == "scissors" && computerInput == "paper")
                {
                    Console.WriteLine("User wins");
                }

                else if (userInput == "scissors" && computerInput == "rock")
                {
                    Console.WriteLine("Computer wins");
                }

                else if (userInput == "paper" && computerInput == "scissors")
                {
                    Console.WriteLine("Computer wins");
                }

                else if (userInput == "paper" && computerInput == "rock")
                {
                    Console.WriteLine("User wins");
                }

                else if (userInput == "rock" && computerInput == "scissors")
                {
                    Console.WriteLine("User wins");
                }
                else if (userInput == "rock" && computerInput == "paper")
                {
                    Console.WriteLine("Computer wins");
                }
            }
            else
            {
                Console.WriteLine("Its a Draw, please Replay");
                player1.SetUserInput();
                PlayGame(player1, player2);
            }
        }
    }
}
