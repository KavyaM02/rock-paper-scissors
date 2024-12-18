using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace rock_papaer_scissors
{
    internal class UserPlayer
    {
        
        private string userInput;

        public void SetUserInput()
        {
            Console.WriteLine("Hi User, Please put your input");
            userInput = Console.ReadLine();
        }

        public string GetUserInput()
        {
            return userInput;
        }

    }
}
