using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gnomes.Domain.Entities;

namespace Gnomes.Domain.DomainServices
{
    public class GnomeActionService
    {
        public void AddActionToEnd(Gnome gnome, GnomeAction actionToAdd, GnomeAction lastAction)
        {
            gnome.GnomeActions.Add(actionToAdd);
            actionToAdd.PreviousAction = lastAction;
        }
    }
}
