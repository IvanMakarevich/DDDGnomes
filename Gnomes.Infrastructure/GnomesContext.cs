using System.Data.Entity;
using Gnomes.Domain;
using Gnomes.Domain.Entities;
using Gnomes.Domain.Repositories;

namespace Gnomes.Infrastructure
{
    public class GnomesContext : DbContext, IUnitOfWork
    {
        public DbSet<Gnome> Gnomes { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Cell> Cells { get; set; }
        public DbSet<ActionPattern> ActionPatterns { get; set; }
        public DbSet<GnomeAction> GnomeActions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<GnomeAction>().HasRequired(ga => ga.Owner).WithMany(g => g.GnomeActions);
            modelBuilder.Entity<Gnome>().HasMany(g => g.GnomeActions).WithRequired(ga => ga.Gnome);


            modelBuilder.Entity<GnomeAction>().HasOptional(ga => ga.PreviousAction).WithOptionalDependent(
                ga => ga.NextAction);

            //base.OnModelCreating(modelBuilder);
        }

        public void BeginTransaction()
        {
            throw new System.NotImplementedException();
        }

        public void CommitTransaction()
        {
            throw new System.NotImplementedException();
        }

        public void RollbackTransaction()
        {
            throw new System.NotImplementedException();
        }

        void IUnitOfWork.SaveChanges()
        {
            SaveChanges();
        }
    }
}
