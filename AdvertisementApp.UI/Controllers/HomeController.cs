using AdvertisementApp.Bussiness.Interfaces;
using AdvertisementApp.UI.Extentions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AdvertisementApp.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProvidedServiceService _providedServicService;
        private readonly IAdvertisementService _advertisementService;

        public HomeController(IProvidedServiceService service, IAdvertisementService advertisementService)
        {
            _providedServicService = service;
            _advertisementService = advertisementService;
        }

        public async Task<IActionResult> Index()
        {
          var response=await _providedServicService.GetAllAsync();
            return this.ResponseView(response);
        }
        
        public async Task<IActionResult> HumanResource()
        {
            var response=await _advertisementService.GetActiveAsync();

            return this.ResponseView(response);
        }
    }
}
