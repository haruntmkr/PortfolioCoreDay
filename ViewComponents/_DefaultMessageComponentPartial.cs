using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultMessageComponentPartial : ViewComponent
    {
      
        public IViewComponentResult Invoke()
        {
            return View(new Message());
        }
    }
}
