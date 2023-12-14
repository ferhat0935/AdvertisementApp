using AdvertisementApp.Dto.Interfaces;

namespace AdvertisementApp.Dto
{
    public class AppUserCreateDto:IDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public int GenderId { get; set; }

       
    }
}
