using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megazine.Models.Journal
{
    public class Journal
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Author { get; set; }
        [NotMapped]
        public IFormFile? JournalImageFile { get; set; }
        public string JournalImage { get; set; }
        public DateTime CreatedDate { get; set;}
    }
}
