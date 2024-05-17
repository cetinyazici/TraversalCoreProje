using DataAccessLayer.Concrete;
using MediatR;
using TraversalCoreProje.CQRS.Commands.GuideCommands;

namespace TraversalCoreProje.CQRS.Handlers.GuideHandlers
{
    public class RemoveGuideCommandHandler : IRequestHandler<RemoveGuideCommand>
    {
        private readonly Context _context;

        public RemoveGuideCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(RemoveGuideCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.id);
            _context.Remove(values);
            _context.SaveChanges();
            return Unit.Value;
        }
    }
}
