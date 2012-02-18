using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gnomes.Application.Contracts;
using Gnomes.Domain.Entities;
using Gnomes.Domain.Repositories;

namespace Gnomes.Application.AppServices
{
    public class GnomeService : IGnomeService
    {
        private readonly IGnomeRepository _gnomeRepository;

        public IGnomeRepository GnomeRepository
        {
            get { return _gnomeRepository; }
        }

        public GnomeService(IGnomeRepository gnomeRepository)
        {
            _gnomeRepository = gnomeRepository;
        }

        public Gnome LoadGnomeById(int id)
        {
            Gnome result = GnomeRepository.GetByIdIncludeActions(id);
            return result;
        }
    }
}
