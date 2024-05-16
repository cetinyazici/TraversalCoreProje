namespace TraversalCoreProje.CQRS.Commands.DestinationCommands
{
    public class CreateDestinationCommand
    {
        public string City { get; set; }
        public string DayNighy { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }
    }
}
