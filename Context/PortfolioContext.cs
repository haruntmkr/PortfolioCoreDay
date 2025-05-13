using Microsoft.EntityFrameworkCore;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Context
{
    public class PortfolioContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-24NE71D\\SQLEXPRESS;initial Catalog=PortfolioDayDb;integrated security=true;trust server certificate=true;");
            //integrated security=true bağlantının güvenli olduğunu kadı parola gerekmediğini belirtmiş oluyoruz. 
        }
        public DbSet<Education> Educations
        {
            //Yalın olan ad ,Education, csharp tarafında kullanılacak olan kısım çoğul olan Educations
            //veritabanı tarafında kullanılacak olan olan kısımdır,
            //farklıda isimlendirlir ama kullanımı bu şekilde
            get;
            set;
        }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
        //Ctrl+boşluk karakteri kullanırsan bunları yazarken Messages vs tamamlar. 
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        //Eğer hata verirse CTRL+nokta tıklaanrak yukarıdaki kütüphanelerden biri seçilir
        //using PortfolioCoreDay.Entities;

        public DbSet<Skill> Skills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
    }
}
