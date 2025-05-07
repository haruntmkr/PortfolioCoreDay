namespace PortfolioCoreDay.Entities
{
    public class Portfolio
    {
        public int PortfolioId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Githuburl { get; set; }
        public string Imageurl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}