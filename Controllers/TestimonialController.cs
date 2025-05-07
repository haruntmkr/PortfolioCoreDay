using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class TestimonialController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult TestimonialList()
        {
            //Testimonialsa ait tüm değerleri getireceğiz. 
            var values = context.Testimonials.ToList();
            //Values ide iletince sayfayla beraber verileride ileteceğiz. 
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateTestimonial() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial testimonial)
        {
            context.Testimonials.Add(testimonial);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        public IActionResult DeleteTestimonial(int id) 
        {
            //Silme işlmei için form vs gerekmediğinden
            //burası için view oluşturulmuyor sadece link
            //verilecek oradanda id linkle birlikte çekilecektir.
            //Go To View dediğinde aşağıdaki TestimonialList in viewine gitmez
            //çünkü bura için özel bir view oluşturmadık
            //ama yukarıdaki ve aşağıdaki metotlarda create ve update lerde view'e gidiyor. 
            var value =context.Testimonials.Find(id);
            context.Testimonials.Remove(value);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            context.Testimonials.Update(testimonial);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
            //cshtml dosyalarının üzerindeyken ctrl+shift+w ile projeyi çalıştır
            //diğer türlü açmayabiliyor.
        }

    }
}
