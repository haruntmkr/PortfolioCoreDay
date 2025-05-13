using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.Controllers
{
    public class StatisticsController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Skills.Sum(x=>x.SkillValue);
            //yeteneklerim 70 , 90 ,100 değerleri bunları toplayıp viewbage yazacaktır. 
            ViewBag.v3 = context.Skills.Average(x => x.SkillValue);
            //yeteneklerim 70 , 90 ,100 değerleri bunların ortalamasını viewbage yazacaktır. 
            ViewBag.v4 = context.Skills.Where(x => x.SkillValue>80).Count();
            //skillvalueSu 80 den büyük olan kayıtların sayısını getirir
            ViewBag.v4 = context.Skills.Where(x => x.SkillValue > 80).Count();
            //Aktif Servis Sayısı
            ViewBag.v5 = context.Services.Where(x=>x.Status==true).Count();
            //Gelen mesaj sayısı
            ViewBag.v6 = context.Messages.Count();
            //Okunmamış mesaj sayısı
            ViewBag.v7 = context.Messages.Where(c => c.IsRead == false).Count();
            //Okunmuş mesaj sayısı
            ViewBag.v8 = context.Messages.Where(c => c.IsRead == true).Count();
            //Farklı sektör sayısı
            ViewBag.v9 = context.Experiences.Select(x => x.Industry).Distinct().Count();
            //Kaç farklı kategoride hizmet veriliyor
            ViewBag.v10 = context.Categories.Count();

            return View();
        }
    }
}
//Lambda