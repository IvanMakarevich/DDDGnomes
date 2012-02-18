using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gnomes.Application.AppServices;
using Gnomes.Application.AppServices.InstallServices;
using Gnomes.Application.Contracts;
using Gnomes.Domain.Repositories;
using Gnomes.Infrastructure;
using Gnomes.Infrastructure.Repositories;
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
            container.RegisterType<IGnomeActionRepository, GnomeActionRepository>();
            container.RegisterType<IGnomeRepository, GnomeRepository>();
        }

        private void RegisterAppServices(UnityContainer container)
        {
            container.RegisterType<ISeedService, SeedService>();
            container.RegisterType<IGnomeService, GnomeService>();
        }


    }
}
