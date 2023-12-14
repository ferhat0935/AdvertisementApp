using AdvertisementApp.Common.Enums;
using AdvertisementApp.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Bussiness.ValidationRules.AdvertisementAppUserValidator
{
    public class AdvertisementAppUserCreateDtoValidator: AbstractValidator<AdvertisementAppUserCreateDto>
    {
        public AdvertisementAppUserCreateDtoValidator()
        {
            this.RuleFor(x=>x.AdvertisementAppUserStatusId).NotEmpty();
            this.RuleFor(x=>x.AdvertisementId).NotEmpty();
            this.RuleFor(x=>x.AppUserId).NotEmpty();    
            this.RuleFor(x=>x.CvPath).NotEmpty().WithMessage("Bir dosya seçiniz");
            this.RuleFor(x => x.EndDate).NotEmpty().When(x => x.MilitaryStatusId == (int)MilitaryStatusType.Tecilli).WithMessage("Tecil tarihi giriniz");
           
        }
    }
}
