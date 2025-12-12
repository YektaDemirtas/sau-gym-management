using System.ComponentModel.DataAnnotations;

namespace GymManagement.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required]
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; } = null!;

        [Required]
        public int ServiceId { get; set; }
        public Service Service { get; set; } = null!;

        [Required]
        public int MemberProfileId { get; set; }
        public MemberProfile MemberProfile { get; set; } = null!;

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        public bool IsApproved { get; set; } = false;
    }

}
