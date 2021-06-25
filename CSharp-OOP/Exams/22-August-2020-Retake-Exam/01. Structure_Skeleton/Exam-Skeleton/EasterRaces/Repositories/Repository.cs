using EasterRaces.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Repositories
{
    public abstract class Repository<T> : IRepository<T>
    {
        public List<T> Models { get; private set; }

        public Repository()
        {
            Models = new List<T>();
        }

        public void Add(T model)
        {
            Models.Add(model);
        }

        public IReadOnlyCollection<T> GetAll()
        {
            IReadOnlyCollection<T> colection = Models;

            return colection;
        }

        public T GetByName(string name)
        {
            T model = Models.FirstOrDefault(m => m.GetType().Name == name);

            return model;
        }

        public bool Remove(T model)
        {
            bool removed = Models.Remove(model);

            return removed;
        }
    }
}
