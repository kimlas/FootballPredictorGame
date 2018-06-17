using Domain.Core;
using Microsoft.AspNetCore.Hosting;

namespace Persistence.Persisters
{
    public class PlayerRepositoryPersister : RepositoryPersister<Player>, IPlayerRepositoryPersister
    {
        public PlayerRepositoryPersister(IHostingEnvironment hostingEnvironment) : base(hostingEnvironment)
        {
            
        }
    }
}
