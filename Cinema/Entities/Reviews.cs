using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Entities
{
    public class Reviews
    {
        [Key]

        public Guid ID { get; set; }

        [Required]
        public Guid TitleId { get; set; }


        [ForeignKey("TitleId")]
        public virtual Movie Title { get; set; }

        [Required]
        public string Comment { get; set; }

    }
}
