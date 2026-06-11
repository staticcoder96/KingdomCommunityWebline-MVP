using System.ComponentModel.DataAnnotations;

namespace KingdomCommunityWebline.Models
{
    public class ApprovedMember
    {
        [Required]
        public int ApprovedMemberId { get; set; }

        [Required]
        public string FirstName { get; set; } 

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        public bool IsRegistered { get; set; } = false;
    }
}
