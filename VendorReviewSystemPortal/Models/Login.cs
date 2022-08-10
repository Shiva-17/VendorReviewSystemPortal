using System.ComponentModel.DataAnnotations;

namespace VendorReviewSystemPortal.Models
{
    public class Login
    {
        [Required]
        public int UserID { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
