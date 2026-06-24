using System.ComponentModel.DataAnnotations;

namespace KingdomCommunityWebline.Models
{
    public class ApprovedMember
    {
        [Required]
        public int ApprovedMemberId { get; set; }

        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; } = string.Empty;

        [Phone]
        public string PhoneNumber { get; set; } = string.Empty;

        public bool IsRegistered { get; set; } = false;
    }
}
