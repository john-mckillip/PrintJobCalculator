using JobCalculator.Business.Abstractions;
using JobCalculator.Models;
using JobCalculator.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace JobCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly IJobCalculator _JobCalculator;

        public HomeController(
            IJobCalculator jobCalculator)
        {
            _JobCalculator = jobCalculator;
        }

        public IActionResult Index()
        {
            var model = new HomeViewModel();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Calculate(Job mockJob)
        {
            if (!ModelState.IsValid)
            {
                var model = new HomeViewModel
                {
                    MockJob = mockJob
                };

                return View(model);
            }

            var receipt = _JobCalculator.CalculateJobCost(mockJob);

            return View("~/Views/Home/Receipt.cshtml", receipt);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SetProducts(int numberOfProducts)
        {
            if (numberOfProducts == 0)
            {
                ModelState.AddModelError("", "Number of products must be greater than zero!");
            }

            if (!ModelState.IsValid)
            {
                return View("Index", new HomeViewModel());
            }

            var model = new HomeViewModel
            {
                MockJob = new Job(numberOfProducts)
            };

            return View("~/Views/Home/Calculate.cshtml", model);
        }
    }
}
