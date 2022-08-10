using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VendorReviewSystemPortal.Migrations
{
    public partial class review : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodieReviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodieUserID = table.Column<int>(type: "int", nullable: false),
                    FoodieName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodieMobileNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodieDateofVisit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FoodieDateofReview = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VendorUserID = table.Column<int>(type: "int", nullable: false),
                    VendorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodiesReview = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodieReviews", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodieReviews");
        }
    }
}
