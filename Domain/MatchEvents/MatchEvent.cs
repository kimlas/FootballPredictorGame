using Domain.Bases;
using Domain.Core;

namespace Domain.MatchEvents
{
    public abstract class MatchEvent : Entity
    {
        public int Minute { get; set; }
        public Player Player { get; set;  }
    }
}
