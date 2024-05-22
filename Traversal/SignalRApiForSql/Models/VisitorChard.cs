namespace SignalRApiForSql.Models
{
    public class VisitorChard
    {
        public VisitorChard()
        {
            Counts = new List<int>();
        }
        public string VisitDate { get; set; }
        public List<int> Counts { get; set; }
    }
}
