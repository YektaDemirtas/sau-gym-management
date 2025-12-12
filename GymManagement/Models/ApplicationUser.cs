using Microsoft.AspNetCore.Identity;


namespace GymManagement.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Ek alanlar:
        public string? FullName { get; set; }

        // Boy kilo gibi alanlar AI için işimize yarar:
        public double? HeightCm { get; set; }
        public double? WeightKg { get; set; }

        // Üye mi, antrenör mü gibi bir flag de koyabiliriz
        public bool IsTrainer { get; set; }
    }
}
