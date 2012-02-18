using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gnomes.Domain.Entities;

namespace Gnomes.Domain.Repositories
{
    public interface IGnomeRepository: IRepository<Gnome>
    {
        Gnome GetByIdIncludeActions(int id);
    }
}
