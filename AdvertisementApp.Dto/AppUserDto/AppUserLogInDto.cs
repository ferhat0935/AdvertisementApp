using AdvertisementApp.Dto.Interfaces;

namespace AdvertisementApp.Dto
{
    public class AppUserLogInDto:IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
