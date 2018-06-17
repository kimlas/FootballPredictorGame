using System.Collections.Generic;
using Domain.Bases;

namespace Persistence.Persisters
{
    public interface IRepositoryPersister<T> where T : Entity
    {
        List<T> Load();
        void Persist(List<T> entities);
    }
}
