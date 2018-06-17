using System;
using System.Collections.Generic;
using Domain.Interfaces;

namespace Domain.Core
{
    public class Group : IEntity
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public List<Team> Teams { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
