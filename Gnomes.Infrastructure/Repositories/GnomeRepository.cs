using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gnomes.Domain.Entities;
using Gnomes.Domain.Repositories;

namespace Gnomes.Infrastructure.Repositories
{
    public class GnomeRepository : Repository<Gnome>, IGnomeRepository
    {
        public GnomeRepository(GnomesContext context) : base(context)
        {
        }

        public Gnome GetByIdIncludeActions(int id)
        {
            var result = Context.Gnomes.Include("GnomeActions").Single(g => g.Id == id);
            return result;
        }
    }
}
