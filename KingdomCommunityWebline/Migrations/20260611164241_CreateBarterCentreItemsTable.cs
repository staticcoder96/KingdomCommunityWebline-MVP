using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KingdomCommunityWebline.Migrations
{
    /// <inheritdoc />
    public partial class CreateBarterCentreItemsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BarterCentreItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Item = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestorPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestorChurch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RespondentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RespondentChurch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CounterOffer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CounterOfferStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateDelivered = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeliveryMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Accepted = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarterCentreItems", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BarterCentreItems");
        }
    }
}
