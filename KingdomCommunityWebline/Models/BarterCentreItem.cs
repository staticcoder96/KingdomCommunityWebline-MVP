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

        public string RespondentName {  get; set; } = string.Empty;

        public string RespondentChurch { get; set; } = string.Empty;

        public string CounterOffer { get; set; } = string.Empty;

        public string CounterOfferStatus {  get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateDelivered { get; set; }

        public string DeliveryMethod { get; set; } = string.Empty;

        public bool Accepted { get; set; }
        public string Status { get; set; } = string.Empty;

        public string Comments { get; set; } = string.Empty;
    }
}
