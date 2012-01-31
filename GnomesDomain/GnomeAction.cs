namespace GnomesDomain
{
    public class GnomeAction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ActionPattern ActionPattern { get; set; }
        public Cell TargetCell { get; set; }
    }
}