using Domain.MatchEvents;
using System;
using System.Collections.Generic;
using Domain.Bases;

namespace Domain.Core
{
    public class Match : Entity
    {
        public DateTime StartDate { get; set; }
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }

        public List<MatchEvent> MatchEvents { get; set; }

    }
}
