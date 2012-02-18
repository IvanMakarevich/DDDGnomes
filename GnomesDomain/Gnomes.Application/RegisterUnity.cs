using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gnomes.Domain.Repositories;
using Gnomes.Infrastructure;
using Gnomes.Infrastructure.Repositories;
using Gnomes.Infrastructure.Seed;
using Microsoft.Practices.Unity;

namespace Gnomes.Application
{
    class RegisterUnity
    {
        public void InitializeUnity()
        {
            var container = Register();
            // TODO store container in static field.
        }

        public UnityContainer Register()
        {
            UnityContainer container = new UnityContainer();
            
            container.RegisterType<ICellRepository, CellRepository>();
            return container;
        }
    }
}
