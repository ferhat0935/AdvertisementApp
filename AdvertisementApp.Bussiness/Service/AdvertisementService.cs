using AdvertisementApp.Bussiness.Interfaces;
using AdvertisementApp.Common;
using AdvertisementApp.DataAccess.UnitOfWork;
using AdvertisementApp.Dto;
using AdvertisementApp.Dto.Interfaces;
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
    public class AdvertisementService : Service<AdvertisementCreateDto, AdvertisementUpdateDto, AdvertisementListDto, Advertisement>, IAdvertisementService
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;
      

        public AdvertisementService(IMapper mapper, IValidator<AdvertisementCreateDto> createDtovalidator, IValidator<AdvertisementUpdateDto> updateDtovalidator, IUow uow) :base(mapper, createDtovalidator, updateDtovalidator, uow)  //Service clasına mapper vs gönderiyoruz
        {
            _uow = uow;
            _mapper=mapper;
        }
        public async Task<IResponse<List<AdvertisementListDto>>> GetActiveAsync()
        {
           var data=await _uow.GetRepository<Advertisement>().GetAllAsync(x => x.Status, x => x.CreatedDate, Common.Enums.OrderByType.DESC);// eklenen iş ilanlarını tarihe göre sırala
            var dto=_mapper.Map<List<AdvertisementListDto>>(data);
            return new Response<List<AdvertisementListDto>>(ResponseType.Success, dto);
        }
    }
}
