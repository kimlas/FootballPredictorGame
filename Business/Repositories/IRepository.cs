using System.Collections.Generic;
using Domain.Interfaces;

namespace Business.Repositories
{
    public interface IRepository<T> where T : IEntity
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}
