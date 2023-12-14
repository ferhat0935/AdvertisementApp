using AdvertisementApp.Bussiness.Interfaces;
using AdvertisementApp.Bussiness.Mappings.AutoMapper;
using AdvertisementApp.Bussiness.Service;
using AdvertisementApp.Bussiness.ValidationRules;
using AdvertisementApp.Bussiness.ValidationRules.AdvertisementAppUserValidator;
using AdvertisementApp.Bussiness.ValidationRules.AdvertisementValidator;
using AdvertisementApp.Bussiness.ValidationRules.AppUserValidator;
using AdvertisementApp.Bussiness.ValidationRules.GenderValidator;
using AdvertisementApp.Bussiness.ValidationRules.ProvidedServiceValidator;
using AdvertisementApp.DataAccess.Context;
using AdvertisementApp.DataAccess.UnitOfWork;
using AdvertisementApp.Dto;
using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace AdvertisementApp.Bussiness.DependencyResolvers.Microsoft
{
    public static class DependencyExtention
    {
        public static void AdDependencies(this IServiceCollection service)
        {
            service.AddDbContext<AdvertisementContext>(opt =>
            {
                opt.UseSqlServer("Server=FERHATSOLMAZZ\\SQLEXPRESS; Database=AdDB; User Id=ferhat; Password=ferhat0935; TrustServerCertificate=True");
                
            });
       
            service.AddScoped<IUow, Uow>();
            service.AddTransient<IValidator<ProvidedServiceCreateDto>,ProvidedServiceCreateDtoValidator>();
            service.AddTransient<IValidator<ProvidedServiceUpdateDto>,ProvidedServiceUpdateDtoValidator>();
            service.AddTransient<IValidator<AdvertisementCreateDto>, AdvertisementCreateDtoValidator>();
            service.AddTransient<IValidator<AdvertisementUpdateDto>,AdvertisementUpdateDtoValidator>();
            service.AddTransient<IValidator<AppUserCreateDto>, AppUserCreateDtoValidator>();
            service.AddTransient<IValidator<AppUserUpdateDto>,AppUserUpdateDtoValidator>();
            service.AddTransient<IValidator<AppUserLogInDto>, AppUserLogInDtoValidator>();
            service.AddTransient<IValidator<GenderCreateDto>, GenderCreateDtoValidator>();
            service.AddTransient<IValidator<GenderUpdateDto>, GenderUpdateDtoValidator>();
            service.AddTransient<IValidator<AdvertisementAppUserCreateDto>, AdvertisementAppUserCreateDtoValidator>();

            service.AddScoped<IProvidedServiceService, ProvidedServiceService>();
            service.AddScoped<IAdvertisementService, AdvertisementService>();
            service.AddScoped<IAppUserService, AppUserService>();
            service.AddScoped<IGenderService, GenderService>();
            service.AddScoped<IAdvertisementAppUserService,AdvertisementAppUserService>();

        }
       

    }
}
