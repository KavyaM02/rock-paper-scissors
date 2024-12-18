using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_papaer_scissors
{
    internal class RockPaperScissors
    {
        public static void Main(string[] args)
        {
            UserPlayer userplayer = new UserPlayer();
            ComputerPlayer computerplayer = new ComputerPlayer();
            Game game = new Game();
            
            game.PlayGame(userplayer, computerplayer);


       }
    }
}
