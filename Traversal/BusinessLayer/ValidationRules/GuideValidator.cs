﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Rehber adını giriniz...!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen rehber açıklamsını seçiniz..!");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen rehber görselini giriniz..!");
            RuleFor(x => x.Name).MinimumLength(10).WithMessage("Lütfen en az 10 karakterlik bir isim giriniz...");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen 30 karakterden kısa bir isim giriniz ....");
        }
    }
}
