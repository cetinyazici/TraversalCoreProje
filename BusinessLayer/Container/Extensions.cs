using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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
        }

        public static void ConfigureServiceRegistration(this IServiceCollection services)
        {
            services.AddScoped<ICommentDal, EfCommentDal>();
            services.AddScoped<IDestinationDal, EfDestinationDal>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();
            services.AddScoped<IReservationDal, EfReservationDal>();
            services.AddScoped<ICommentDal, EfCommentDal>();
            services.AddScoped<IGuideDal, EfGuideDal>();
        }

    }
}
