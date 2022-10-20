using System.ComponentModel.DataAnnotations;

namespace JwtBasics.Models
{
    public class Team
    {
        public DateTime? CraatedTime { get; set; }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
    }
}

