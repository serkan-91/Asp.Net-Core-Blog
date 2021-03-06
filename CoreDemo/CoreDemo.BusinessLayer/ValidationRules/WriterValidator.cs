using CoreDemo.Shared.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adi soyadi kismi bos gecilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi bos gecilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Sifre bos gecilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lutfen en az 2 karakter veri girisi yapin");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lutfen en fazla 50 karakter veri girisi yapin");
        }
    }
}
