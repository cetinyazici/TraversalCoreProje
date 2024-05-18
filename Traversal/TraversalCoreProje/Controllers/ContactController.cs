using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DToLayer.Dtos.ContactDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IContactUsService _contactUsService;
        private readonly IMapper _mapper;

        public ContactController(IMapper mapper, IContactUsService contactUsService)
        {
            _mapper = mapper;
            _contactUsService = contactUsService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SendMessageDto model)
        {
            if (ModelState.IsValid)
            {
                _contactUsService.TAdd(new ContactUs()
                {
                    Name = model.Name,
                    Mail = model.Mail,
                    Subject = model.Subject,
                    MessageBody = model.MessageBody
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
