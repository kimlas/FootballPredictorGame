using Domain.Core;
using Domain.Interfaces;

namespace Domain.MatchEvents
{
    public abstract class MatchEvent : IEntity
    {
        public int Id { get; set; }
        public int Minute { get; set; }
        public Player Player { get; set;  }
    }
}
