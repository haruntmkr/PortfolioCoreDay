using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class AboutController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        [HttpGet]
        public IActionResult AboutList()
        {
            var values = context.Abouts.FirstOrDefault();
            return View(values);
        }
        [HttpPost]
        public IActionResult AboutList(About about)
        {
            context.Abouts.Update(about);
            context.SaveChanges();
            TempData["Success"] = "Başarıyla Kaydedildi";
            return View();
        }
        
    }
}
