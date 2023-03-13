using Microsoft.AspNetCore.Mvc;
using RangeValue.Data.Entities;
using RangeValue.Models;
using RangeValue.Services;

namespace RangeValue.Controllers
{
    public class AdminController : Controller
    {
        private readonly IRangeService _rangeService;

        public AdminController(IRangeService rangeService)
        {
            _rangeService = rangeService;
        }

        public IActionResult Index()
        {
            RangeViewModel model = new RangeViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddToList(RangeViewModel model)
        {
            if (model.Errors == null)
            {
                model.Errors = new List<string>();
            }
            else
            {
                // Hata mesajlarını errors listesine ekleyin.
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    model.Errors.Add(error.ErrorMessage);
                }
            }

            if (ModelState.IsValid)
            {
                _rangeService.addTolist(model);

                TempData["SuccessMessage"] = "Ekleme işlemi başarılı oldu.";
            }
          

            return View("Index", model);
        }
    }
}
