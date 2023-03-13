using Microsoft.AspNetCore.Mvc;
using RangeValue.Services;

namespace RangeValue.Controllers
{
    public class UserController : Controller
    {
        private readonly IRangeService _rangeControlService;

        public UserController(IRangeService rangeControlService)
        {
            _rangeControlService = rangeControlService;
        }

        // GET: /User/Index
        public IActionResult Index()
        {
            return View();
        }

        // POST: /User/CalculateScore
        [HttpPost]
        public IActionResult CalculateScore(double number)
        {
            var score = _rangeControlService.GetScore(number);
            ViewBag.Score = score;
            return View();
        }
    }
}
