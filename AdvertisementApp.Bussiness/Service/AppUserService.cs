using AdvertisementApp.Bussiness.Extentions;
using AdvertisementApp.Bussiness.Interfaces;
using AdvertisementApp.Common;
using AdvertisementApp.DataAccess.UnitOfWork;
using AdvertisementApp.Dto;
using AdvertisementApp.Entities;
using AutoMapper;
using FluentValidation;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertisementApp.Bussiness.Service
{
    public class AppUserService : Service<AppUserCreateDto, AppUserUpdateDto, AppUserListDto, AppUser>, IAppUserService
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;
        private readonly IValidator<AppUserCreateDto> _createDtoValidator;
        private readonly IValidator<AppUserLogInDto> _loginDtoValidator;
        public AppUserService(IMapper mapper, IValidator<AppUserCreateDto> createDtovalidator, IValidator<AppUserUpdateDto> updateDtovalidator, IUow uow, IValidator<AppUserCreateDto> createDtoValidator, IValidator<AppUserLogInDto> loginDtoValidator) : base(mapper, createDtovalidator, updateDtovalidator, uow)  //Service clasına mapper vs gönderiyoruz
        {
            _mapper = mapper;
            _uow = uow;
            _createDtoValidator = createDtoValidator;
            _loginDtoValidator = loginDtoValidator;
        }

        public async Task<IResponse<AppUserCreateDto>> CreateWithRoleAsync(AppUserCreateDto dto, int roleId)
        {
            var validationresult = _createDtoValidator.Validate(dto);
            if (validationresult.IsValid)
            {
                var user = _mapper.Map<AppUser>(dto);
                user.AppUserRoles = new List<AppUserRole>();
                user.AppUserRoles.Add(new AppUserRole
                {
                    AppUser = user,
                    AppRoleId = roleId
                });
                await _uow.GetRepository<AppUser>().CreateAsync(user);
                await _uow.SaveChangesAsync();
                return new Response<AppUserCreateDto>(ResponseType.Success, dto);
                //await _uow.GetRepository<AppUserRole>().CreateAsync(new AppUserRole
                //{
                //    AppRoleId=roleId,
                //    AppUserId
                //})
            }
            return new Response<AppUserCreateDto>(dto, validationresult.ConvertToCustomValidationError());
        }

        //signIn
        public async Task<IResponse<AppUserListDto>> CheckUserAsync(AppUserLogInDto dto)
        {
            var validatinResult = _loginDtoValidator.Validate(dto);
            if (validatinResult.IsValid)
            {
                var user = await _uow.GetRepository<AppUser>().GetByFilterAsync(x => x.UserName == dto.UserName && x.Password == dto.Password);
                if (user != null)
                {
                    var appUserDto = _mapper.Map<AppUserListDto>(user);
                    return new Response<AppUserListDto>(ResponseType.Success, appUserDto);
                }
                return new Response<AppUserListDto>(ResponseType.NotFound, "Kullanıcı adı veya şifre hatalı");
            }
            return new Response<AppUserListDto>(ResponseType.ValidationError, "Kullanıcı adı veya şifre boş olamaz!");
        }
        //bir kullanıcının birden fazla rolü olabilceği için list döndü
        public async Task<IResponse<List<AppRoleListDto>>> GetRolesByUserIdAsync(int userId)
        {
          var roles=await _uow.GetRepository<AppRole>().GetAllAsync(x=>x.AppUserRoles.Any(x=>x.AppUserId==userId));
            if (roles==null)
            {
                return new Response<List<AppRoleListDto>>(ResponseType.NotFound, "İlgili rol bulunamadı");
            }
            var dto=_mapper.Map<List<AppRoleListDto>>(roles);
            return new Response<List<AppRoleListDto>>(ResponseType.Success, dto);
        }


    }
}
