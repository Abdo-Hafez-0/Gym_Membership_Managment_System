

namespace Gym_Membership_Managment_System.Models
{
    public class MembershipPlan
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int DurationInMonths { get; set; }
        public string? Description { get; set; }


    }
}
