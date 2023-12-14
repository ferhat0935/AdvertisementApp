﻿using AdvertisementApp.Bussiness.Interfaces;
using AdvertisementApp.DataAccess.UnitOfWork;
using AdvertisementApp.Dto;
using AdvertisementApp.Entities;
using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Bussiness.Service
{
    public class ProvidedServiceService:Service<ProvidedServiceCreateDto, ProvidedServiceUpdateDto, ProvidedServiceListDto,ProvidedService>,IProvidedServiceService
    {
        public ProvidedServiceService(IMapper mapper,IValidator<ProvidedServiceCreateDto> createDtoValidator,IValidator<ProvidedServiceUpdateDto> updateDtoValidator,IUow uow):base(mapper, createDtoValidator, updateDtoValidator, uow)
        {
            
        }
    }
}
