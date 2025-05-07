using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreDay.Controllers
{
    public class ExperienceController : Controller
    {
        public IActionResult ExperienceList()
        {//ExperienceList() olarak Index() adını değiştirdik
            return View();
        }
    }
}
