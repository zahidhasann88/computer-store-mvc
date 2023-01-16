namespace computerstore.Models
{
    public class SiteData
    {
        public decimal tax { get; set; }
        public decimal setup { get; set; }
        public string email { get; set; }

        public SiteData()
        {
            tax = (Decimal)0.07;
            setup = (Decimal)100;
            email = "helpdesk@computerstore.com";
        }
    }
}
