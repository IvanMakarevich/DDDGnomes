using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace GnomesDomain.Seed
{
    public class GnomesRecreateAndSeed : DropCreateDatabaseAlways<GnomesContext>
    {
        protected override void Seed(GnomesContext context)
        {
            base.Seed(context);
            Gnome gnome = new Gnome();
            gnome.Name = "Vasya";
            gnome.UserName = "Ivan";
            context.Set<Gnome>().Add(gnome);
            context.SaveChanges();
        }
    }
}
