using System.Collections.Generic;

namespace Gnomes.Domain.Entities
{
    public class Gnome
    {
        public Gnome()
        {
            _gnomeActions = new List<GnomeAction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }

        public virtual Cell Position { get; set; }

        public virtual GnomeAction CurrentAction { get; set; }

        private ICollection<GnomeAction> _gnomeActions;
        public virtual ICollection<GnomeAction> GnomeActions
        {
            get { return _gnomeActions; }
            set { _gnomeActions = value; }
        }
    }
}