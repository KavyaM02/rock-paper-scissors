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
        private int flag1 = 0;
        private int flag2 = 0;
        public void PlayGame(UserPlayer player1, ComputerPlayer player2)
        {


            for (int i = 0; i < 3; i++)
            {
                userInput = player1.SetUserInput().ToLower();
                computerInput = player2.GetComputerInput();

                if (userInput != computerInput)
                {
                    if (userInput == "scissors" && computerInput == "paper")
                    {
                        Console.WriteLine("User wins");
                        flag1++;
                    }

                    else if (userInput == "scissors" && computerInput == "rock")
                    {
                        Console.WriteLine("Computer wins");
                        flag2++;
                    }

                    else if (userInput == "paper" && computerInput == "scissors")
                    {
                        Console.WriteLine("Computer wins");
                        flag2++;
                    }

                    else if (userInput == "paper" && computerInput == "rock")
                    {
                        Console.WriteLine("User wins");
                        flag1++;
                    }

                    else if (userInput == "rock" && computerInput == "scissors")
                    {
                        Console.WriteLine("User wins");
                        flag1++;
                    }
                    else if (userInput == "rock" && computerInput == "paper")
                    {
                        Console.WriteLine("Computer wins");
                        flag2++;
                    }
                }

                else
                {
                    Console.WriteLine("Its a Draw, please Replay");
                    --i;
                }
            }
            if(flag1 > 2 || flag2 < 2)
            {
                Console.WriteLine("Final Result: User wins");
                Console.WriteLine("UserScore: " + flag1);
                Console.WriteLine("ComputerScore: " + flag2);
            }                            
            else
            {
                Console.WriteLine("Final Result: Computer wins");
                Console.WriteLine("ComputerScore: " + flag2);
                Console.WriteLine("UserScore: " + flag1);
            }
                

        }
    }
}
