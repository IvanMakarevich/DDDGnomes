using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gnomes.Domain;
using Gnomes.Domain.Repositories;

namespace Gnomes.Infrastructure.Repositories
{
    public class Repository<T> where T:class, new ()
    {
        private readonly GnomesContext _context;

        public IUnitOfWork UnitOfWork
        {
            get { return _context; }
        }

        protected GnomesContext Context
        {
            get { return _context; }
        }

        public Repository(GnomesContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
        }

        public void Attach(T entity)
        {
            Context.Set<T>().Attach(entity);
        }
    }
}
