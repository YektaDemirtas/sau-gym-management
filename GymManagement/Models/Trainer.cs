using System.ComponentModel.DataAnnotations;

namespace GymManagement.Models
{
    public class Trainer
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = null!;

        [StringLength(200)]
        public string? ExpertiseAreas { get; set; } // "Kas geliştirme, kilo verme"

        public int GymId { get; set; }
        public Gym Gym { get; set; } = null!;

        public ICollection<Service>? Services { get; set; }
        public ICollection<TrainerAvailability>? Availabilities { get; set; }
    }
}
