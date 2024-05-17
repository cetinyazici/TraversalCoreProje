using DataAccessLayer.Concrete;
using MediatR;
using TraversalCoreProje.CQRS.Commands.GuideCommands;

namespace TraversalCoreProje.CQRS.Handlers.GuideHandlers
{
    public class UpdateGuideCommandHandler : IRequestHandler<UpdateGuideCommand>
    {
        private readonly Context _context;

        public UpdateGuideCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateGuideCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.GuideId);
            values.Name = request.Name;
            values.Description = request.Description;
            _context.SaveChanges();
            return Unit.Value;
        }
    }
}
