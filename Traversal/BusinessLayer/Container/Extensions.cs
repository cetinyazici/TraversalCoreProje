using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DToLayer.Dtos.AnnouncementDtos;
using EntityLayer.Concrete;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extensions
    {

        public static void ConfigureRepositoryRegistration(this IServiceCollection services)
        {
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<IExcelService, ExcelManager>();
            services.AddScoped<IPdfReportService, PdfReportManager>();
            services.AddScoped<IContactUsService, ContactUsManager>();
            services.AddScoped<IAnnouncementService, AnnouncementManager>();

        }

        public static void ConfigureServiceRegistration(this IServiceCollection services)
        {
            services.AddScoped<ICommentDal, EfCommentDal>();
            services.AddScoped<IDestinationDal, EfDestinationDal>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();
            services.AddScoped<IReservationDal, EfReservationDal>();
            services.AddScoped<ICommentDal, EfCommentDal>();
            services.AddScoped<IGuideDal, EfGuideDal>();
            services.AddScoped<IContactUsDal, EfContactUsDal>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
        }

        public static void CustomerValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAddDto>, AnnouncementValidator>();
        }

    }
}
