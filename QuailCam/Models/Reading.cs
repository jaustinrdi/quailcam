using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuailCam.Models
{
    public enum ReadingType
    {
        Light, Humidity, Temperature
    }

    public class Reading
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UtcTimestamp { get; set; }

        [Required]
        public ReadingType Type { get; set; }
        [Required]
        public int RawReading { get; set; }
        // TODO: add location (x,y,z) coords

        // TODO: convert this value from the raw reading
        public double ConvertedReading { get; set; }
    }

}