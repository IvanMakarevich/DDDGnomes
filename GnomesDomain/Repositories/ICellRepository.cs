using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gnomes.Domain.Entities;

namespace Gnomes.Domain.Repositories
{
    public interface ICellRepository : IRepository<Cell>
    {
        Cell GetByCoord(int x, int y, int z);
    }
}
