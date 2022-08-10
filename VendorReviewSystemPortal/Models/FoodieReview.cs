using System.ComponentModel.DataAnnotations;

namespace VendorReviewSystemPortal.Models
{
    public class FoodieReview
    {
        public int Id { get; set; }

        [Required]
        public int FoodieUserID { get; set; }
        [Required]
        public string FoodieName { get; set; }
        [Required]
        public string FoodieMobileNo { get; set; }
        [Required]
        public DateTime FoodieDateofVisit { get; set; }
        [Required]
        public DateTime FoodieDateofReview { get; set; }
        [Required]
        public int VendorUserID { get; set; }
        [Required]
        public string VendorName { get; set; }

        [Required]
        public string VendorLocation { get; set; }
        [Required]
        public string FoodiesReview { get; set; }

        [Required]
        public string FoodieRating { get; set; }
    }
}
