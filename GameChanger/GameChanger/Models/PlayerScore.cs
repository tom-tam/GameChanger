using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameChanger.Models
{
    public class PlayerScore
    {
        public Match Match { get; set; }
        public Player Player { get; set; }
        public ICollection<Break> Breaks { get; set; }

        public int Value => Breaks.Sum(b => b.Value) + (Match.GetOtherPlayerScore(this).FoulValue);

        public int FoulValue => Breaks.Sum(b => b.FoulBall?.Value ?? 0);
    }
}