﻿using DToLayer.Dtos.AnnouncementDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AnnouncementValidationRules
{
    public class AnnouncementUpdateValidator : AbstractValidator<AnnouncementUpdateDto>
    {
        public AnnouncementUpdateValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen başlık giriniz...*");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfeb duyuru içeriğinini giriniz...*");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen en az 5 karakter giriniz...*");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("Lütfen en az 20 karakter giriniz...*");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter giriniz...*");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Lütfen en fazla 500 karakter giriniz...*");
        }
    }
}
