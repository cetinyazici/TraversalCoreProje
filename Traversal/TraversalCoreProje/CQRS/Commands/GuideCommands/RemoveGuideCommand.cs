using MediatR;

namespace TraversalCoreProje.CQRS.Commands.GuideCommands
{
    public class RemoveGuideCommand : IRequest
    {
        public int id { get; set; }

        public RemoveGuideCommand(int id)
        {
            this.id = id;
        }
    }
}
