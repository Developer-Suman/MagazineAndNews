using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Megazine.Models.News
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        
        [NotMapped]
        public IFormFile? ImageUrl { get; set; }
        public string ImageName { get; set; }
    }
}
