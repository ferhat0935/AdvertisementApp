using AdvertisementApp.Dto.Interfaces;

namespace AdvertisementApp.Dto
{
    public class AppRoleListDto:IDto
    {
        public int Id { get; set; }

        public string Definition { get; set; }
    }
}
