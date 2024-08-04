namespace MyPortolio.DAL.Entities
{
    public class Portfolio
    {
        public int PortfolioId { get; set; }

        public string Title { get; set; }
        public string SubTitle { get; set; }

        public int ImageUrl { get; set; }
        public string Url { get; set; }

        public int Description { get; set; }

    }

}
