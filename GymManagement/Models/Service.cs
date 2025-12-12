using System.ComponentModel.DataAnnotations;

namespace GymManagement.Models
{
    public class Service
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = null!;  // Fitness, Yoga vs.

        [Required]
        public int DurationMinutes { get; set; }

        [Required]
        [Range(0, 10000)]
        public decimal Price { get; set; }

        public int GymId { get; set; }
        public Gym Gym { get; set; } = null!;
    }
}
