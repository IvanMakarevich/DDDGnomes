using System.Collections.Generic;

namespace GnomesDomain
{
    public class Level
    {
        private readonly List<Cell> _cells = new List<Cell>();
        public int Id { get; set; }
        public List<Cell> Cells
        {
            get { return _cells; }
        }
    }
}