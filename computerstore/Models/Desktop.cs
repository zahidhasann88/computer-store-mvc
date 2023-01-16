namespace computerstore.Models
{
    public class Desktop
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        private int _ram;

        public int Ram
        {
            get { return _ram; }
            set { _ram = value; }
        }

        public Desktop(string name, decimal price, int ram)
        {
            Name = name;
            Price = price;
            Ram = ram;
        }
    }
}
