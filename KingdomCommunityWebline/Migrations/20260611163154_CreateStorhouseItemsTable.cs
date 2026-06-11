using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KingdomCommunityWebline.Migrations
{
    /// <inheritdoc />
    public partial class CreateStorhouseItemsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StorehouseItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Need = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestorPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestorChurch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestorChurchAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DonorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonorPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonorChurch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonorChurchAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateDelivered = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeliveryMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Accepted = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorehouseItems", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StorehouseItems");
        }
    }
}
