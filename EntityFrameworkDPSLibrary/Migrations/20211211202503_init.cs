using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkDPSLibrary.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buyer",
                columns: table => new
                {
                    NIP = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlatNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyer", x => x.NIP);
                });

            migrationBuilder.CreateTable(
                name: "DailyInvoiceCounter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyInvoiceCounter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    InvoiceNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModyficationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BuyerNIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SellerNIP = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.InvoiceNumber);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    MeasureUnit = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Seller",
                columns: table => new
                {
                    NIP = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlatNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seller", x => x.NIP);
                });

            migrationBuilder.CreateTable(
                name: "ProductsOnInvoice",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    ProductCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    QuantityOfProduct = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsOnInvoice", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductsOnInvoice_Invoice_InvoiceNumber",
                        column: x => x.InvoiceNumber,
                        principalTable: "Invoice",
                        principalColumn: "InvoiceNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductsOnInvoice_Product_ProductCode",
                        column: x => x.ProductCode,
                        principalTable: "Product",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsOnInvoice_InvoiceNumber",
                table: "ProductsOnInvoice",
                column: "InvoiceNumber");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsOnInvoice_ProductCode",
                table: "ProductsOnInvoice",
                column: "ProductCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buyer");

            migrationBuilder.DropTable(
                name: "DailyInvoiceCounter");

            migrationBuilder.DropTable(
                name: "ProductsOnInvoice");

            migrationBuilder.DropTable(
                name: "Seller");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
