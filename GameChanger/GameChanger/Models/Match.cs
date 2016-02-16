using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameChanger.Models
{
    public class Match
    {
        public int BestOf { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Player Winner { get; set; }
        public ICollection<Frame> Frames { get; set; }
    }
}