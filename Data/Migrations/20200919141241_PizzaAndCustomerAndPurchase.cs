using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GourmetPizzaPrac3.Data.Migrations
{
    public partial class PizzaAndCustomerAndPurchase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    FamilyName = table.Column<string>(maxLength: 20, nullable: false),
                    GivenName = table.Column<string>(maxLength: 20, nullable: false),
                    DateOfBirth = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Email);
                });


            migrationBuilder.CreateTable(
                name: "Purchase",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    pizzaID = table.Column<int>(nullable: false),
                    CustomerEmail = table.Column<string>(nullable: false),
                    PizzaCount = table.Column<int>(nullable: false),
                    TotalCost = table.Column<decimal>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase", x => x.CustomerEmail);
                    table.ForeignKey(
                        name: "FK_Purchase_Customer_CustomerEmail",
                        column: x => x.CustomerEmail,
                        principalTable: "Customer",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Purchase_Pizza_pizzaID",
                        column: x => x.pizzaID,
                        principalTable: "Pizza",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Purchase");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Pizza");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");
        }
    }
}
