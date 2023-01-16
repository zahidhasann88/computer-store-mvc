using System.ComponentModel.DataAnnotations;

namespace computerstore.Models
{
    public class OrderItem
    {
        [Required(ErrorMessage = "Please pick a processor")]
        public string Processor { get; set; }
        [Required(ErrorMessage = "Please specify RAM")]
        [Range(1, 4, ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public int? RAM { get; set; }
        [Required(ErrorMessage = "Please specify CPU speed")]
        public double? Speed { get; set; }
        [Required(ErrorMessage = "Please specify HD Size")]
        public double? HDSize { get; set; }
        [Required(ErrorMessage = "Please enter your email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public OrderItem(string processor, int rAM, double speed, double hDSize, string email)
        {
            Processor = processor;
            RAM = rAM;
            Speed = speed;
            HDSize = hDSize;
            Email = email;
        }

        public OrderItem()
        {

        }
    }
}
