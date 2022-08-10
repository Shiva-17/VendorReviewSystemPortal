using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VendorReviewSystemPortal.Migrations
{
    public partial class com : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Complaints",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorUserID = table.Column<int>(type: "int", nullable: false),
                    VendorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodieUserID = table.Column<int>(type: "int", nullable: false),
                    FoodieName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RaiseComplaint = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaints", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Complaints");
        }
    }
}
