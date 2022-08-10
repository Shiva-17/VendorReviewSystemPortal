using System.ComponentModel.DataAnnotations;

namespace VendorReviewSystemPortal.Models
{
    public class Complaint
    {
        public int ID { get; set; }

        [Required]
        public int VendorUserID { get; set; }

        [Required]
        public string VendorName { get; set; }

        [Required]
        public string VendorLocation { get; set; }

        [Required]
        public int FoodieUserID { get; set; }

        [Required]
        public string FoodieName { get; set; }

        [Required]
        public string RaiseComplaint { get; set; }

    }
}
