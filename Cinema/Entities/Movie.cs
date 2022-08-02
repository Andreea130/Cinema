using System.ComponentModel.DataAnnotations;

namespace Cinema.Entities
{
    public class Movie
    {
        [Key]

        public Guid ID { get; set; }

        [Required]
        public string Title { get; set; }

        public string Director { get; set; }

        [Required]
        public int Lenght { get; set; }

        public string Genre { get; set; }

        public int Stars { get; set; }

        public int NrRivews { get; set; }
    }
}