using System.ComponentModel.DataAnnotations;

namespace GymManagement.Models
{
    public class MemberProfile
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = null!; // ApplicationUser FK
        public ApplicationUser User { get; set; } = null!;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
