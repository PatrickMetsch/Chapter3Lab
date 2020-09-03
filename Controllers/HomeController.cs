using Microsoft.AspNetCore.Mvc;
using PriceQuotation.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PriceQuotation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.DiscountAmount = 0;
            ViewBag.Total = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(PriceQuotationModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.DiscountAmount = model.CalculateDiscount();
                ViewBag.Total = model.CalculateTotal();
            }
            else
            {
                ViewBag.DiscountAmount = 0;
                ViewBag.Total = 0;
            }
            
            return View(model);
        }
    }
}
