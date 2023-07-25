using System.ComponentModel.DataAnnotations;

namespace Web_Blog.Client.Models
{
    public class BlogPost
    {
        [Key]
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Discription { get; set; }
        public DateTime PublicationDate { get; set; }
    }
}
