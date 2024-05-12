using DToLayer.Dtos.AppUserDtos;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Alanı boş geçilemez...*");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad Alanı boş geçilemez...*");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Alanı boş geçilemez...*");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı Alanı boş geçilemez...*");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Alanı Boş geçilemez...*");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre Tekrar Alanı boş geçilemez...*");
            RuleFor(x => x.UserName).MinimumLength(5).WithMessage("Lütfen En Az 5 Karakter Veri Girişi Sağlanız...*");
            RuleFor(x => x.UserName).MaximumLength(20).WithMessage("Lütfen En Fazla 20 Karakter Veri Girişi Sağlanız...*");
            RuleFor(x => x.Password).Equal(y=>y.ConfirmPassword).WithMessage("Şifreler Birbiriyle Uyuşmuyor...*");
        }
    }
}
