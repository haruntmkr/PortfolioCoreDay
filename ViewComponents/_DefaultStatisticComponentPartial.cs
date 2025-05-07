using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultStatisticComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Statistics.ToList();
            Random rnd = new Random();
            int random = rnd.Next(1,30);
            ViewBag.random = random.ToString();
            return View(values);
        }
    }
}
