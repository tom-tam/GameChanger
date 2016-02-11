using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameChanger.Models
{
    public class Break
    {
        public PlayerScore Score { get; set; }
        public ICollection<Pot> Pots { get; set; }
        public Ball FoulBall { get; set; }
        public int Value { get { return Pots.Sum(p => p.Ball.Value); } }
    }
}