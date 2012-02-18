using System;

namespace Gnomes.Domain.Repositories
{
    public interface IRepository<T> where T: class , new()
    {
        IUnitOfWork UnitOfWork { get; }
        void Add(T entity);
        void Delete(T entity);

    }
}