using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class LandPropertyValidator:AbstractValidator<LandProperty>
    {
        public LandPropertyValidator()
        {
            RuleFor(x => x.Precedent).NotEmpty().WithMessage("Bu kısmı boş geçemezsiniz");
            RuleFor(x => x.Template).NotEmpty().WithMessage("Bu kısmı boş geçemezsiniz");
            RuleFor(x => x.DeedStatus).NotEmpty().WithMessage("Bu kısmı boş geçemezsiniz");
            RuleFor(x => x.LandType).NotEmpty().WithMessage("Bu kısmı boş geçemezsiniz");
            RuleFor(x => x.ExchangeStatus).NotEmpty().WithMessage("Bu kısmı boş geçemezsiniz");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Bu kısmı boş geçemezsiniz");
            RuleFor(x => x.Picture).NotEmpty().WithMessage("Bu kısmı boş geçemezsiniz");
            RuleFor(x => x.Video).NotEmpty().WithMessage("Bu kısmı boş geçemezsiniz");
            RuleFor(x => x.AdvertNo).NotEmpty().WithMessage("Bu kısmı boş geçemezsiniz");
            RuleFor(x => x.AdvertState).NotEmpty().WithMessage("Bu kısmı boş geçemezsiniz");
            RuleFor(x => x.Square).NotEmpty().WithMessage("Bu kısmı boş geçemezsiniz");
            RuleFor(x => x.City).NotEmpty().WithMessage("Bu kısmı boş geçemezsiniz");
            RuleFor(x => x.District).NotEmpty().WithMessage("Bu kısmı boş geçemezsiniz");
            RuleFor(x => x.Street).NotEmpty().WithMessage("Bu kısmı boş geçemezsiniz");
        }
    }
}
