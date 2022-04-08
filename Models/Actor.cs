
using System.ComponentModel.DataAnnotations;


namespace ApplicationDevelopmentCorusework.Models
{
    public class Actor
    {
        [Key]
        public long ActorNumber { get; set; }
        public string ActorFirstName { get; set; }
        public string ActorLastName { get; set; }
    }
}
