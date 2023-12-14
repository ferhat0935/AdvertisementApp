﻿using AdvertisementApp.Bussiness.Extentions;
using AdvertisementApp.Bussiness.Interfaces;
using AdvertisementApp.Common;
using AdvertisementApp.DataAccess.UnitOfWork;
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
    public class Service<CreateDto, UpdateDto, ListDto, T> : IService<CreateDto, UpdateDto, ListDto, T>
        where CreateDto : class, IDto, new()
        where UpdateDto : class, IUpdateDto, new()
        where ListDto : class, IDto, new()
        where T : BaseEntity
    {
        private readonly IMapper _mapper;
        private readonly IValidator<CreateDto> _createDtovalidator;
        private readonly IValidator<UpdateDto> _updateDtovalidator;
     
        private readonly IUow _uow;

        public Service(IMapper mapper, IValidator<CreateDto> createDtovalidator, IValidator<UpdateDto> updateDtovalidator, IUow uow)
        {
            _mapper = mapper;
            _createDtovalidator = createDtovalidator;
            _updateDtovalidator = updateDtovalidator;
            _uow = uow;
            
        }

        public async Task<IResponse<CreateDto>> CreateAsync(CreateDto dto)
        {
            var result = _createDtovalidator.Validate(dto);
            if (result.IsValid)
            {
                var createdEntity = _mapper.Map<T>(dto);
                await _uow.GetRepository<T>().CreateAsync(createdEntity);
                await _uow.SaveChangesAsync();
                return new Response<CreateDto>(ResponseType.Success, dto);

            }
            return new Response<CreateDto>(dto, result.ConvertToCustomValidationError());
        }

        public async Task<Response<List<ListDto>>> GetAllAsync()
        {
            var data = await _uow.GetRepository<T>().GetAllAsync();
            var dto = _mapper.Map<List<ListDto>>(data);
            return new Response<List<ListDto>>(ResponseType.Success, dto);
        }

        public async Task<IResponse<IDto>> GetByIdAsync<IDto>(int id)
        {
            var data = await _uow.GetRepository<T>().GetByFilterAsync(x => x.Id == id);
            if (data == null)
            {
                return new Response<IDto>(ResponseType.NotFound, $"{id} ye shaip data bulunamadı");
            }
            var dto = _mapper.Map<IDto>(data);
            return new Response<IDto>(ResponseType.Success, dto);
        }

        public async Task<IResponse> RemoveAsync(int id)
        {
            var data = await _uow.GetRepository<T>().FindAsync(id);
            if (data == null)

              return new Response(ResponseType.NotFound, $"{id} ye ait data bulunamadı");
            _uow.GetRepository<T>().Remove(data);
            await _uow.SaveChangesAsync();
            return new Response(ResponseType.Success);

        }

        public async Task<IResponse<UpdateDto>> UpdateAsync(UpdateDto dto)
        {
           var result= _updateDtovalidator.Validate(dto);
            if(result.IsValid)
            {
                var unchangedData = await _uow.GetRepository<T>().FindAsync(dto.Id);
                if (unchangedData == null)
                    return new Response<UpdateDto>(ResponseType.NotFound, $"{dto.Id} idsine ait data bulunamadı");
                var entity = _mapper.Map<T>(dto);
                _uow.GetRepository<T>().Update(entity, unchangedData);
                await _uow.SaveChangesAsync();
                return new Response<UpdateDto>(ResponseType.Success, dto);
            }
            return new Response<UpdateDto>(dto,result.ConvertToCustomValidationError());
         
        }
    }
}
