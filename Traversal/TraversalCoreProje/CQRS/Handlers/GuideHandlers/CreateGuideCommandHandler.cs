﻿using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using MediatR;
using NuGet.Protocol.Plugins;
using TraversalCoreProje.CQRS.Commands.GuideCommands;

namespace TraversalCoreProje.CQRS.Handlers.GuideHandlers
{
    public class CreateGuideCommandHandler : IRequestHandler<CreateGuideCommand>
    {
        private readonly Context _context;

        public CreateGuideCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
            _context.Add(new Guide
            {
                Name = request.Name,
                Description = request.Description,
                Status = false,
                Image = "/soft-ui-dashboard/assets/img/team-1.jpg"
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
