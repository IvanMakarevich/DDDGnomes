using System.Data.Entity;
using System.Linq;
using Gnomes.Application.Contracts;
using Gnomes.Domain.Entities;
using Gnomes.Infrastructure;
using Microsoft.Practices.ServiceLocation;

namespace Gnomes.Mvc3Site
{
    public class GnomesRecreateAndSeed : DropCreateDatabaseAlways<GnomesContext>
    {
        protected override void Seed(GnomesContext context)
        {
            base.Seed(context);
            var seed = ServiceLocator.Current.GetInstance<ISeedService>();
            seed.MakeSeed();
        }

    }
}
