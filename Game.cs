using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//don't mind me, just making a random edit here.

namespace NewLab2
{
    public class Game
    {
        public String team1 { get; set; }

        public int team1Score { get; set; }

        public String team2 { get; set; }

        public int team2Score { get; set; }

        public Game()
        {

        }

        public Game(String team1, int team1Score, String team2, int team2Score)
        {
            this.team1 = team1;
            this.team2 = team2;
            this.team1Score = team1Score;
            this.team2Score = team2Score;
        }

        public override string ToString()
        {
            return String.Format("{0} ({1}) - {2} ({3})", team1, team1Score, team2, team2Score);
        }
    }
}
