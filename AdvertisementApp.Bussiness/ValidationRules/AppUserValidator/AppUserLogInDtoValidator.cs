using AdvertisementApp.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Bussiness.ValidationRules.AppUserValidator
{
    public class AppUserLogInDtoValidator:AbstractValidator<AppUserLogInDto>
    {
        public AppUserLogInDtoValidator()
        {
            RuleFor(x=>x.UserName).NotEmpty().WithMessage("Kullanıcı adı giriniz");  
            RuleFor(x=>x.Password).NotEmpty().WithMessage("Şifre giriniz");
        }
    }
}
