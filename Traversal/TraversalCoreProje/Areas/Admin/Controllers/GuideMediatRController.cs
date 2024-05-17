using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.CQRS.Commands.GuideCommands;
using TraversalCoreProje.CQRS.Queries.GuideQueries;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class GuideMediatRController : Controller
    {
        private readonly IMediator _mediator;

        public GuideMediatRController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllGuideQuery());
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> GetGuide(int id)
        {
            var values = await _mediator.Send(new GetAllGuideByIdQuery(id));
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> GetGuide(UpdateGuideCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddGuide(CreateGuideCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteGuide(int id)
        {
            await _mediator.Send(new RemoveGuideCommand(id));
            return RedirectToAction("Index");
        }

    }
}
