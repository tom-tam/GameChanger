using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameChanger.Models
{
    public class Match
    {
        public GameType GameType { get; set; }
        public PlayerScore Score1 { get; set; }
        public PlayerScore Score2 { get; set; }

        internal PlayerScore GetOtherPlayerScore(PlayerScore scoreToIgnore)
        {
            return Score1 == scoreToIgnore
                ? Score2
                : Score1;
        }
    }
}