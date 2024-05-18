using DToLayer.Dtos.AnnouncementDtos;
using DToLayer.Dtos.ContactDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.ContactUs
{
    public class SendContectUsValiator: AbstractValidator<SendMessageDto>
    {
        public SendContectUsValiator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfeb isim giriniz...*");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Lütfeb mail giriniz...*");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Lütfeb konu bilgisini giriniz...*");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Lütfeb mesajınızı giriniz...*");
            RuleFor(x => x.MessageBody).MinimumLength(5).WithMessage("Lütfen en az 5 karakter giriniz...*");
            RuleFor(x => x.MessageBody).MaximumLength(500).WithMessage("Lütfen en fazla 500 karakter giriniz...*");
        }
    }
}
