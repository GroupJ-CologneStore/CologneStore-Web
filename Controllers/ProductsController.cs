using CologneStore.DTO;
using CologneStore.Models;
using CologneStore.Repositories;
using Humanizer.Localisation;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CologneStore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly IHomeRepository _homeRepository;

        public ProductsController(ILogger<ProductsController> logger, IHomeRepository homeRepository)
        {
            _logger = logger;
            _homeRepository = homeRepository;
        }

        public async Task<IActionResult> Products(string sTerm = "", int typeId = 0, int cologneForId = 0)
        {
            IEnumerable<Cologne> colognes = await _homeRepository.GetColognes(sTerm, typeId, cologneForId);
            IEnumerable<CologneType> types = await _homeRepository.Types();
            IEnumerable<CologneFor> colongesFor = await _homeRepository.ColognesFor();
            var cologneModel = new CologneDisplayModel
            {
                Colognes = colognes,
                Types = types,
                ColognesFor = colongesFor
            };
            return View(cologneModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
