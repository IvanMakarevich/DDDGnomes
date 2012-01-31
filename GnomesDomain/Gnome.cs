using System.Collections.Generic;

namespace GnomesDomain
{
    public class Gnome
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }

        public Cell Position { get; set; }

        public GnomeAction CurrentAction { get; set; }
        public List<GnomeAction> PlannedActions { get; set; }


    }
}