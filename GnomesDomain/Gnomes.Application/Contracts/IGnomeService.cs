using Gnomes.Domain.Entities;

namespace Gnomes.Application.Contracts
{
    public interface IGnomeService
    {
        Gnome LoadGnomeById(int id);
    }
}