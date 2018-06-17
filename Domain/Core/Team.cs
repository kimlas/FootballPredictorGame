using System;
using System.Collections.Generic;
using Domain.Interfaces;

namespace Domain.Core
{
    public class Team : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Player> Players { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
