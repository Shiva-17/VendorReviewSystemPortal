using Microsoft.EntityFrameworkCore;

namespace VendorReviewSystemPortal.Models
{
    public class UserContext:DbContext
    {
        public UserContext()
        {

        }
        public UserContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Foodie> Foodies { get; set; }
        public DbSet<FoodieReview> FoodieReviews { get; set; }

        public DbSet<Complaint> Complaints { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=SHIVA-17\SQLEXPRESS;database=DBVRSS;Integrated Security=true");
        }

    }
}
