using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gnomes.Domain.Repositories;
using Gnomes.Infrastructure;
using Gnomes.Infrastructure.Repositories;
using Gnomes.Infrastructure.Seed;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;

namespace Gnomes.Application
{
    public class ApplicationUnityRegistrator
    {
        public void Register(UnityContainer container)
        {
            RegisterInfrastructure(container);
            RegisterAppServices(container);
        }

        private void RegisterInfrastructure(UnityContainer container)
        {
            container.RegisterType<ICellRepository, CellRepository>();
        }

        private void RegisterAppServices(UnityContainer container)
        {

        }


    }
}
