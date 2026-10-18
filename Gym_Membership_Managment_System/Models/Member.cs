
namespace Gym_Membership_Managment_System.Models
{
    public class Member
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime JoinDate { get; set; }
        public bool IsActive { get; set; }

    }
}
