﻿using AdvertisementApp.Dto;
using AdvertisementApp.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Bussiness.Mappings.AutoMapper
{
    public class ProvidedServiceProfile:Profile
    {
        public ProvidedServiceProfile()
        {
            CreateMap<ProvidedServiceCreateDto,ProvidedService>().ReverseMap();
            CreateMap<ProvidedServiceListDto, ProvidedService>().ReverseMap();
            CreateMap<ProvidedServiceUpdateDto, ProvidedService>().ReverseMap();

        }
    }
}
