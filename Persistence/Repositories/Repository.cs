using System;
using System.Collections.Generic;
using System.Linq;
using Business.Repositories;
using Domain.Interfaces;
using Persistence.Persisters;

namespace Persistence.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : IEntity
    {
        private readonly IRepositoryPersister<T> _repositoryPersister;
        private readonly List<T> _entities;

        protected Repository(IRepositoryPersister<T> repositoryPersister)
        {
            _repositoryPersister = repositoryPersister;
            _entities = _repositoryPersister.Load();
        }

        public List<T> GetAll()
        {
            return _entities;
        }

        public T Get(int id)
        {
            return _entities.FirstOrDefault(p => p.Id == id);
        }

        public void Add(T entity)
        {
            if (entity.Id != 0)
            {
                throw new Exception("Cannot add entity with already set id");
            }

            entity.Id = GetNextId();

            _entities.Add(entity);
            Persist();
        }

        private int GetNextId()
        {
            if (_entities.Count == 0)
            {
                return 1;
            }

            return _entities.Select(p => p.Id).Max() + 1;
        }

        public void Update(T entity)
        {
            if (entity.Id != 0)
            {
                throw new Exception("Cannot update entity with id == 0");
            }

            if (Get(entity.Id) == null)
            {
                throw new Exception($"Cannot update entity with id {entity.Id}. Not found.");
            }

            Remove(entity);
            Add(entity);

            Persist();
        }

        public void Remove(T entity)
        {
            if (entity.Id != 0)
            {
                throw new Exception("Cannot remove entity with id == 0");
            }

            if (Get(entity.Id) == null)
            {
                throw new Exception($"Cannot remove entity with id {entity.Id}. Not found.");
            }

            for (int i = _entities.Count - 1; i >= 0; i--)
            {
                if (_entities[i].Id == entity.Id)
                {
                    _entities.RemoveAt(i);
                }
            }

            Persist();
        }

        private void Persist()
        {
            _repositoryPersister.Persist(_entities);
        }
    }
}
