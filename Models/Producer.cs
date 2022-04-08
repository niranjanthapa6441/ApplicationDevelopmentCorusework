
using System.ComponentModel.DataAnnotations;


namespace ApplicationDevelopmentCorusework.Models
{
    public class Producer
    {
        [Key]
        public long ProducerNumber { get; set; }
        public string ProducerName { get; set; }
    }
}
