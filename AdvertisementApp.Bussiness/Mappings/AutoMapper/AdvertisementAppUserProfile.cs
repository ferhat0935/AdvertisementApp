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
    public class AdvertisementAppUserProfile:Profile
    {
        public AdvertisementAppUserProfile()
        {
            CreateMap<AdvertisementAppUser,AdvertisementAppUserCreateDto>().ReverseMap();
            CreateMap<AdvertisementAppUser, AdvertisementAppUserListDto>().ReverseMap();
        }
    }
}
