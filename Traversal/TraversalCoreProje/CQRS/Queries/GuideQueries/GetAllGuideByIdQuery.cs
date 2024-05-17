using MediatR;
using TraversalCoreProje.CQRS.Results.GuideResults;

namespace TraversalCoreProje.CQRS.Queries.GuideQueries
{
    public class GetAllGuideByIdQuery : IRequest<GetGuideByIdQueryResult>
    {
        public int Id { get; set; }

        public GetAllGuideByIdQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
