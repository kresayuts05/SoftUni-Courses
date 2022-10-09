using System.ComponentModel.DataAnnotations;

namespace ForumApp.Data.Entities
{
    public class Post
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(1500)]
        public string Content { get; set; }
    }
}
