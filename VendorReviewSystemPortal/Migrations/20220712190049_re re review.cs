using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VendorReviewSystemPortal.Migrations
{
    public partial class rerereview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VendorLocation",
                table: "FoodieReviews",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VendorLocation",
                table: "FoodieReviews");
        }
    }
}
