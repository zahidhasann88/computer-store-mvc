namespace computerstore.Models
{
    public class Laptop : Desktop
    {
        public int Screen { get; set; }
        public int Weight { get; set; }

        public Laptop(string name, decimal price, int ram, int screen, int weight) : base(name, price, ram)
        {
            Screen = screen;
            Weight = weight;
        }
    }
}
