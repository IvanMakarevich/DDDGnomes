using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gnomes.Domain.Entities;
using Gnomes.Domain.Repositories;

namespace Gnomes.Infrastructure.Repositories
{
    public class GnomeActionRepository : Repository<GnomeAction>, IGnomeActionRepository
    {
        public GnomeActionRepository(GnomesContext context) : base(context)
        {
        }

        public GnomeAction FindLastGnomeAction(int gnomeId)
        {
            GnomeAction result = Context.GnomeActions.FirstOrDefault(a => a.Gnome.Id == gnomeId && a.NextAction == null);
            return result;
        }
    }
}
