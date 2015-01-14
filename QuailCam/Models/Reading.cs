using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuailCam.Models
{
    public class Reading
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UtcTimestamp { get; set; }
        public int RawReading { get; set; }
        public double ConvertedReading { get; set; }
        // TODO: add: enum type { light, humidity, temperature }
        // TODO: add location
    }

}