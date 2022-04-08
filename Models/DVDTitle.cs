using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationDevelopmentCorusework.Models
{
    public class DVDTitle
    {
        
        [Key]
        public long DVDNumber { get; set; }
        public long ProducerNumber { get; set; }
        public long CategoryNumber { get; set; }
        public long StudioNumber { get; set; }
        public DateTime DateReleased { get; set; }
        public int StandardCharge { get; set; }
        public int PenaltyCharge { get; set; }

        [ForeignKey("ProducerNumber")]
        public Producer Producer { get; set; }

        [ForeignKey("CategoryNumber")]
        public DVDCategory DVDCategory { get; set; }

        [ForeignKey("StudioNumber")]
        public Studio Studio { get; set; }


    }
}
