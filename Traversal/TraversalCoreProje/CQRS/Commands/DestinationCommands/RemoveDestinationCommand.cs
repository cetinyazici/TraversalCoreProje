namespace TraversalCoreProje.CQRS.Commands.DestinationCommands
{
    public class RemoveDestinationCommand
    {
        public int ıd { get; set; }

        public RemoveDestinationCommand(int ıd)
        {
            this.ıd = ıd;
        }
    }
}
