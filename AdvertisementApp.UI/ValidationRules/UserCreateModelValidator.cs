using AdvertisementApp.UI.Models;
using FluentValidation;
using System;

namespace AdvertisementApp.UI.ValidationRules
{
    public class UserCreateModelValidator : AbstractValidator<UserCreateModel>
    {
        public UserCreateModelValidator()
        {
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre giriniz");
            RuleFor(x => x.Password).MinimumLength(3).WithMessage("Şifre en az 3 karakter olmalı");
            RuleFor(x => x.Password).Equal(x => x.ConfirmPassword).WithMessage("Şifreler uyuşmuyor");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı giriniz");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Kullanıcı adı en az 3 karakter olmalı");
            RuleFor(x => x.GenderId).NotEmpty().WithMessage("Cinsiyet seçiniz");
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("İsim giriniz");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Soyisim giriniz");

        }


    }
}
