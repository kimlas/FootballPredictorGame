using System.Collections.Generic;
using Domain.Interfaces;

namespace Persistence.Persisters
{
    public interface IRepositoryPersister<T> where T : IEntity
    {
        List<T> Load();
        void Persist(List<T> entities);
    }
}
