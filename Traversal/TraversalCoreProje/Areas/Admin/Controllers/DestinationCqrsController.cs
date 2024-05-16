using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.CQRS.Handlers.DestinationHandlers;
using TraversalCoreProje.CQRS.Queries.DestinationQueries;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class DestinationCqrsController : Controller
    {
        private readonly GetAllDestinationQueryHandler _getAllDestinationQueryHandler;
        private readonly GetDestinationByIdQueryHandler _getDestinationByIdQueryHandler;
        public DestinationCqrsController(GetAllDestinationQueryHandler handler, GetDestinationByIdQueryHandler handlerr)
        {
            _getAllDestinationQueryHandler = handler;
            _getDestinationByIdQueryHandler = handlerr;
        }

        public IActionResult Index()
        {
            var values = _getAllDestinationQueryHandler.Handle();
            return View(values);
        }

        public IActionResult GetDestination(int id)
        {
            var values = _getDestinationByIdQueryHandler.Handle(new GetDestinationByIdQuery(id));
            return View(values);
        }
    }
}
