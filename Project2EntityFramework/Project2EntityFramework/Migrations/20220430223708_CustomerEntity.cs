using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2EntityFramework.Migrations
{
    public partial class CustomerEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    cardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cardNumber = table.Column<long>(type: "bigint", nullable: false),
                    cardPurchaseDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cardInitialBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    cardCurrentBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    customerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.cardId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    customerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerPWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerStateAbb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerZip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.customerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Card");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
