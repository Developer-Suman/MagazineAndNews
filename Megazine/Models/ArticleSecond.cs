using System.ComponentModel.DataAnnotations;

namespace Megazine.Models
{
    public class ArticleSecond
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Author { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
