using Domain.MatchEvents;
using System;
using System.Collections.Generic;
using Domain.Interfaces;

namespace Domain.Core
{
    public class Match : IEntity
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public List<MatchEvent> MatchEvents { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
