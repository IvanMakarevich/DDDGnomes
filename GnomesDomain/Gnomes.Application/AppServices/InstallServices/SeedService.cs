using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gnomes.Application.Contracts;
using Gnomes.Domain.DomainServices;
using Gnomes.Domain.Entities;
using Gnomes.Domain.Repositories;

namespace Gnomes.Application.AppServices.InstallServices
{
    public class SeedService : ISeedService
    {
        private readonly ICellRepository _cellRepository;

        private readonly IGnomeRepository _gnomeRepository;

        private readonly IGnomeActionRepository _gnomeActionRepository;

        private ICellRepository CellRepository
        {
            get { return _cellRepository; }
        }

        public IGnomeRepository GnomeRepository
        {
            get { return _gnomeRepository; }
        }

        public IGnomeActionRepository GnomeActionRepository
        {
            get { return _gnomeActionRepository; }
        }

        public SeedService(ICellRepository cellRepository, IGnomeRepository gnomeRepository, IGnomeActionRepository gnomeActionRepository)
        {
            _cellRepository = cellRepository;
            _gnomeRepository = gnomeRepository;
            _gnomeActionRepository = gnomeActionRepository;
        }

        public void MakeSeed()
        {
            GenerateSmallArea();
            MakeOneGnome();
            AddSampleAction();
        }

        public void GenerateSmallArea()
        {
            foreach (int yCoord in Enumerable.Range(-10, 20))
            {
                foreach (int xCoord in Enumerable.Range(-10, 20))
                {
                    Cell cell = new Cell{XCoord = xCoord, YCoord = yCoord, ZCoord = 0};
                    CellRepository.Add(cell);
                }
            }
            CellRepository.UnitOfWork.SaveChanges();
        }

        public void MakeOneGnome()
        {
            Cell position = CellRepository.GetByCoord(0, 0, 0);
            Gnome gnome = new Gnome { Name = "Vasya", UserName = "Ivan", Position = position };
            GnomeRepository.Add(gnome);
            GnomeRepository.UnitOfWork.SaveChanges();
        }

        public void AddSampleAction()
        {
            Gnome gnome = GnomeRepository.GetByIdIncludeActions(1);
            ActionPattern pattern = new ActionPattern { Name = "Default", BaseDuration = 10 };
            Cell cell = CellRepository.GetByCoord(1, 0, 0);
            GnomeAction gnomeActionToAdd = new GnomeAction { ActionPattern = pattern, Name = "DigAction", TargetCell = cell};
            GnomeAction last = GnomeActionRepository.FindLastGnomeAction(1);
            GnomeActionService gnomeActionService = new GnomeActionService();
            gnomeActionService.AddActionToEnd(gnome, gnomeActionToAdd, last);
            GnomeRepository.UnitOfWork.SaveChanges();
        }
    }
}
