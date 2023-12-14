using AdvertisementApp.Common;
using AdvertisementApp.Dto;
using AdvertisementApp.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvertisementApp.Bussiness.Interfaces
{
    public interface IAppUserService:IService<AppUserCreateDto,AppUserUpdateDto,AppUserListDto,AppUser>
    {
        Task<IResponse<AppUserCreateDto>> CreateWithRoleAsync(AppUserCreateDto dto, int roleId);
        Task<IResponse<AppUserListDto>> CheckUserAsync(AppUserLogInDto dto);
        Task<IResponse<List<AppRoleListDto>>> GetRolesByUserIdAsync(int userId);
    }
}
