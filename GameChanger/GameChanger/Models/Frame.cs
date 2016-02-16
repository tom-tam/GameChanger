using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameChanger.Models
{
    public class Frame
    {
        public DateTime StartDate { get; set; }
        public PlayerScore Score1 { get; set; }
        public PlayerScore Score2 { get; set; }
        public Player Winner { get; set; }

        internal PlayerScore GetOtherPlayerScore(PlayerScore scoreToIgnore)
            => Score1 == scoreToIgnore
                ? Score2
                : Score1;
    }
}