using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioContext context = new PortfolioContext();
       
        public IActionResult ProjectList()
        {

            var values = context.Portfolios.Include(x => x.Category).ToList();
            context.SaveChanges();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreatePortfolio() 
        {
            var values = new SelectList(context.Categories.ToList(), "CategoryId","CategoryName");
            ViewBag.v = values;
            return View();  
        
        }

        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio portfolio)
        {
            context.Portfolios.Add(portfolio);
            context.SaveChanges();
            return RedirectToAction("ProjectList");
        }


    }
}
