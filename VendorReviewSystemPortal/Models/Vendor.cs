using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendorReviewSystemPortal.Models
{
    public class Vendor
    {
        [Key, Column(Order = 3001)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        public int RoleID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [RegularExpression("^[A-z]{1}[a-z]{4}[@#$%^&*]{1}[0-9]{3}")]
        public string Password { get; set; }

        [Required]
        [RegularExpression("^[A-z]{1}[a-z]{4}[@#$%^&*]{1}[0-9]{3}")]
        public string ConfirmPassword {get;set;}

        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string EmailID { get; set; }

        [Required]
        public string WebsiteID { get; set; }

        [Required]
        public string Location { get; set; }
    }
}
