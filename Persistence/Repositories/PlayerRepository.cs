using Business.Repositories;
using Domain.Core;
using Persistence.Persisters;

namespace Persistence.Repositories
{
    public class PlayerRepository : Repository<Player>, IPlayerRepository
    {
        public PlayerRepository(IPlayerRepositoryPersister repositoryPersister) : base(repositoryPersister)
        {
            
        } 
    }
}
