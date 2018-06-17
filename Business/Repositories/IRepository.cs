using System.Collections.Generic;
using Domain.Bases;

namespace Business.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}
