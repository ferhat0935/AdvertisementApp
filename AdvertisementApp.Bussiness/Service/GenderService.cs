using AdvertisementApp.Bussiness.Interfaces;
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
    public class GenderService:Service<GenderCreateDto,GenderUpdateDto,GenderListDto,Gender>,IGenderService
    {
        public GenderService(IMapper mapper, IValidator<GenderCreateDto> createDtovalidator, IValidator<GenderUpdateDto> updateDtovalidator, IUow uow) : base(mapper, createDtovalidator, updateDtovalidator, uow)  //Service clasına mapper vs gönderiyoruz
        {

        }
    }
}
