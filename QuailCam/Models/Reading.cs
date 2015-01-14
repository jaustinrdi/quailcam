using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

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

        public double ConvertedReading { get; set; }

        public void ConvertRawReading()
        {
            switch (Type)
            {
                case ReadingType.Light:
                    this.ConvertedReading = this.RawReading*11;
                    break;
                case ReadingType.Temperature:
                    this.ConvertedReading = this.RawReading * 5;
                    break;
                case ReadingType.Humidity:
                    this.ConvertedReading = this.RawReading * 2;
                    break;
                default:
                    throw new InvalidDataException("Unknown ReadingType");
            }
        }
    }

}