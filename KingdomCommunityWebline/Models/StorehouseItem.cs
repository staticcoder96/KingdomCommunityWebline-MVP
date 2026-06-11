using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace KingdomCommunityWebline.Models
{
    public class StorehouseItem
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateAdded { get; set; }

        [Required]
        public string Need { get; set; } = string.Empty;

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

        
        public string DonorName { get; set; } = string.Empty;

        [Phone]
        public string DonorPhoneNumber { get; set; } = string.Empty;

        
        public string DonorChurch { get; set; } = string.Empty;

        
        public string DonorChurchAddress { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateDelivered { get; set; }

        public string DeliveryMethod { get; set; } = string.Empty;

        public bool Accepted { get; set; } 
        public string Status { get; set; } = string.Empty;

        public string Comments { get; set; } = string.Empty;

    }
}
