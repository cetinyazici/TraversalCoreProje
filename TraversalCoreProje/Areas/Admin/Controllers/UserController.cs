using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IAppUserService _userService;
        private readonly IReservationService _reservationService;
        private readonly ICommentService _commentService;

        public UserController(IAppUserService userService,
                              IReservationService reservationService,
                              ICommentService commentService)
        {
            _userService = userService;
            _reservationService = reservationService;
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var values = _userService.GetList();
            return View(values);
        }

        public IActionResult DeleteUser(int id)
        {
            var values = _userService.TGetById(id);
            _userService.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var values = _userService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditUser(AppUser appUser)
        {

            _userService.TUpdate(appUser);
            return RedirectToAction("Index");

        }

        public IActionResult CommentUser(int id)
        {
            //usera göre değil destinationa göre geliyor mantık hatası var düzenlenecek.
            var values = _commentService.TGetDestinationById(id);
            return View(values);
        }

        public IActionResult ReservationUser(int id)
        {
            var values = _reservationService.GetListWithReservationByAccepted(id);
            return View(values);
        }

    }
}
