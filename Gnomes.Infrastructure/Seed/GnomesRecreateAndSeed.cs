using System.Data.Entity;
using System.Linq;
using Gnomes.Domain;
using Gnomes.Domain.Entities;

namespace Gnomes.Infrastructure.Seed
{
    public class GnomesRecreateAndSeed : DropCreateDatabaseAlways<GnomesContext>
    {
        protected override void Seed(GnomesContext context)
        {
            base.Seed(context);
            SeedLevel(context);

            Cell position = context.Cells.Single(c => c.XCoord == 0 && c.YCoord == 0 && c.ZCoord == 0);
            Gnome gnome = new Gnome {Name = "Vasya", UserName = "Ivan", Position = position};
            context.Set<Gnome>().Add(gnome);
            context.SaveChanges();

            
            SeedActions(context);
        }

        private void SeedLevel(GnomesContext context)
        {
            var xRange = Enumerable.Range(-20, 20);
            var yRange = Enumerable.Range(-20, 20);
            foreach (var y in yRange)
            {
                foreach (var x in xRange)
                {
                    Cell cell = new Cell {XCoord = x, YCoord = y};
                    context.Set<Cell>().Add(cell);
                }
            }
            context.SaveChanges();
        }

        private void SeedActions(GnomesContext context)
        {
            ActionPattern pattern = new ActionPattern {Name = "Default", BaseDuration = 10};
            context.Set<ActionPattern>().Add(pattern);
            GnomeAction gnomeAction = new GnomeAction {ActionPattern = pattern, Name = "DigAction"};
            Cell targetCell = context.Cells.Single(c => c.XCoord == 1 && c.YCoord == 0 && c.ZCoord == 0);
            gnomeAction.TargetCell = targetCell;
            context.Set<GnomeAction>().Add(gnomeAction);
            gnomeAction.Position = 1;


            Gnome gnome = context.Gnomes.First();
            GnomeAction action =
                context.GnomeActions.FirstOrDefault(ga => ga.Gnome.Id == gnome.Id && ga.NextAction == null);
            if (action != null)
            {
                action.NextAction = gnomeAction;
                gnomeAction.Gnome = gnome;
            }
            else
            {
                gnome.GnomeActions.Add(gnomeAction);
            }
            

            context.SaveChanges();
        }
    }
}
