using System;
using System.Data.Entity;

namespace GnomesDomain
{
    public class GnomesContext : DbContext
    {
        public DbSet<Gnome> Gnomes { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Cell> Cells { get; set; }
        public DbSet<ActionPattern> ActionPatterns { get; set; }
        public DbSet<GnomeAction> GnomeActions { get; set; }
    }
}
