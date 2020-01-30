using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MockupForBusiness.Models;

namespace MockupForBusiness.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOfficeService _officeService;
        private readonly IWorkerService _workerService;
        private readonly IHobbyService _hobbyService;

        public HomeController(ILogger<HomeController> logger, IOfficeService officeService, IWorkerService workerService, IHobbyService hobbyService)
        {
            _logger = logger;
            _officeService = officeService;
            _workerService = workerService;
            _hobbyService = hobbyService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _officeService.GetOfficesListDtoAsync();
            return View(model);
        }

        [HttpGet("{city}", Name = "City")]
        public IActionResult OfficeWithWorkers(string city)
        {
            var model = _officeService.GetOfficesOfficeVms().FirstOrDefault(x => x.OfficeCity.Equals(city));

            var officeWithWorkers = _officeService.GetOfficeWithWorkersVm(model.OfficeId);
            return View(officeWithWorkers);
        }

        [HttpGet("json/{city}", Name = "JsonCity")]
        public IActionResult JsonOfficeWithWorkers(string city)
        {
            var model = _officeService.GetOfficesOfficeVms().FirstOrDefault(x => x.OfficeCity.Equals(city));

            var officeWithWorkers = _officeService.GetOfficeWithWorkersVm(model.OfficeId);
            return Json(officeWithWorkers);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}