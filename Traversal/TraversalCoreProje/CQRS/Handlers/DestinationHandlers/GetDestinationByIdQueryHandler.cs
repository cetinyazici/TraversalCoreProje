using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using TraversalCoreProje.CQRS.Queries.DestinationQueries;
using TraversalCoreProje.CQRS.Results.DestinationResults;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetAllDestinationByIdQueryResult Handle(GetDestinationByIdQuery query)
        {
            var values = _context.Destinations.Find(query.id);
            return new GetAllDestinationByIdQueryResult
            {
                DestinationID = values.DestinationId,
                City = values.City,
                Daynight = values.DayNighy,
                Price = values.Price
            };
        }
    }
}
