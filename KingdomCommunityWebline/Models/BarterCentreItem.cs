using System;
using System.ComponentModel.DataAnnotations;

namespace KingdomCommunityWebline.Models
{
    public class BarterCentreItem
    {
        public int Id { get; set; }

        [Required]
        public string Item { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateAdded { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string RequestorName { get; set; } = string.Empty;

        [Phone]
        public string RequestorPhoneNumber { get; set; } = string.Empty;

        [Required]
        public string RequestorChurch { get; set; } = string.Empty;

        [Required]
        public string RequestorChurchAddress { get; set; } = string.Empty;

        public string? RespondentName {  get; set; }

        [Phone]
        public string? RespondentPhoneNumber { get; set; }

        public string? RespondentChurch { get; set; }

        public string? RespondentChurchAddress { get; set; }

        public string? CounterOffer { get; set; }

        public string? CounterOfferStatus {  get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateDelivered { get; set; }

        public string? DeliveryMethod { get; set; }

        public string? Accepted { get; set; }
        public string Status { get; set; } = "Open";

        public string? Comments { get; set; }
    }
}
