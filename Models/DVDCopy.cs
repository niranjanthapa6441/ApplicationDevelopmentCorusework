using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace ApplicationDevelopmentCorusework.Models
{
    public class DVDCopy
    {
        [Key]
        public long CopyNumber { get; set; }
        public long DVDNumber { get; set; }
        public DateTime DatePurchased { get; set; }

        [ForeignKey("DVDNumber")]
        public DVDTitle DVDTitle { get; set; }

    }
}
