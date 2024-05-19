namespace SignalRApi.DAL
{
    public enum ECity
    {
        Diyarbakır = 1,
        İstanbul = 2,
        Ankara = 3,
        Erzurum = 4,
        Edirne = 5,
    }
    public class Visitor
    {
        public int VisitorID { get; set; }
        public ECity City { get; set; }
        public int CityVisitorCount { get; set; }
        public DateTime VisitorDate { get; set; }
    }
}
