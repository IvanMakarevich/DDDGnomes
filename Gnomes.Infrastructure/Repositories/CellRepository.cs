using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gnomes.Domain;
using Gnomes.Domain.Entities;
using Gnomes.Domain.Repositories;

namespace Gnomes.Infrastructure.Repositories
{
    public class CellRepository : Repository<Cell>, ICellRepository
    {
        public CellRepository(GnomesContext context) : base(context)
        {
        }

        public Cell GetByCoord(int x, int y, int z)
        {
            var result = Context.Cells.Single(c => c.XCoord == x && c.YCoord == y && c.ZCoord == z);
            return result;
        }
    }
}
