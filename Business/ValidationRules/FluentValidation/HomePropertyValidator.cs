using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class HomePropertyValidator:AbstractValidator<HomeProperty>
    {
        public HomePropertyValidator()
        {
            RuleFor(x => x.ApartmentType).NotEmpty().WithMessage("Bu kısmı boş geçemezsiniz");
            RuleFor(x => x.NumberOfRoom).NotEmpty().WithMessage("Bu kısmı boş geçemezsiniz");
            RuleFor(x => x.NumberOfBath).NotEmpty().WithMessage("Bu kısmı boş geçemezsiniz");
            RuleFor(x => x.AgeOfApartment).NotEmpty().WithMessage("Bu kısmı boş geçemezsiniz");
            RuleFor(x => x.WhichFloor).NotEmpty().WithMessage("Bu kısmı boş geçemezsiniz");
            RuleFor(x => x.DeedStatus).NotEmpty().WithMessage("Bu kısmı boş geçemezsiniz");
            RuleFor(x => x.WarmType).NotEmpty().WithMessage("Bu kısmı boş geçemezsiniz");
            RuleFor(x => x.Facede).NotEmpty().WithMessage("Bu kısmı boş geçemezsiniz");
            RuleFor(x => x.FurnitureStatus).NotEmpty().WithMessage("Bu kısmı boş geçemezsiniz");
            RuleFor(x => x.Lift).NotEmpty().WithMessage("Bu kısmı boş geçemezsiniz");
            RuleFor(x => x.CarPark).NotEmpty().WithMessage("Bu kısmı boş geçemezsiniz");
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
