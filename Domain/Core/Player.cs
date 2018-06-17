using Domain.Interfaces;

namespace Domain.Core
{
    public class Player : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ShirtNumber { get; set; }
    }
}
