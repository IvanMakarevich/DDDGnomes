using System;

namespace Gnomes.Domain.Entities
{
    public class GnomeAction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ActionPattern ActionPattern { get; set; }
        public Cell TargetCell { get; set; }
        public DateTime? StartDateTime { get; set; }
        public int Position { get; set; }

        public virtual GnomeAction PreviousAction { get; set; }
        public virtual GnomeAction NextAction { get; set; }

        public virtual Gnome Gnome { get; set; }
    }
}