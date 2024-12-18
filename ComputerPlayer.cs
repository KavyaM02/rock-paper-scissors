using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_papaer_scissors
{
    internal class ComputerPlayer
    {
       
         public string GetComputerInput()
         {

            List<string> inputs = new List<string>();
            inputs.Add("Rock");
            inputs.Add("Paper");
            inputs.Add("Scissors");

            Random randomComputerInput = new Random();

            int index = randomComputerInput.Next(inputs.Count);
            
            string input = inputs[index].ToLower();
           
            Console.WriteLine("Computer Input:" + input);
            return input;
         }

    }
}
