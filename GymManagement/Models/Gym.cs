using System.ComponentModel.DataAnnotations;

namespace GymManagement.Models
{
    public class Gym
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = null!;

        [StringLength(200)]
        public string? Address { get; set; }

        [Required]
        public TimeSpan OpenTime { get; set; }   // 08:00
        [Required]
        public TimeSpan CloseTime { get; set; }  // 22:00

        public ICollection<Service>? Services { get; set; }
        public ICollection<Trainer>? Trainers { get; set; }
    }

}
