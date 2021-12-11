using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace EntityFrameworkDPSLibrary.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductCode",
                table: "Product",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "InvoiceCode",
                table: "Invoice",
                newName: "InvoiceNumber");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MeasureUnit",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BuyerNIP",
                table: "Invoice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Invoice",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModyficationTime",
                table: "Invoice",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SellerNIP",
                table: "Invoice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Buyer",
                columns: table => new
                {
                    NIP = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlatNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyer", x => x.NIP);
                });

            migrationBuilder.CreateTable(
                name: "ProductsOnInvoice",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    QuantityOfProduct = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsOnInvoice", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductsOnInvoice_Invoice_InvoiceCode",
                        column: x => x.InvoiceCode,
                        principalTable: "Invoice",
                        principalColumn: "InvoiceNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsOnInvoice_Product_ProductCode",
                        column: x => x.ProductCode,
                        principalTable: "Product",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seller",
                columns: table => new
                {
                    NIP = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlatNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seller", x => x.NIP);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsOnInvoice_InvoiceCode",
                table: "ProductsOnInvoice",
                column: "InvoiceCode");

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
                name: "ProductsOnInvoice");

            migrationBuilder.DropTable(
                name: "Seller");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "MeasureUnit",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "BuyerNIP",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "ModyficationTime",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "SellerNIP",
                table: "Invoice");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Product",
                newName: "ProductCode");

            migrationBuilder.RenameColumn(
                name: "InvoiceNumber",
                table: "Invoice",
                newName: "InvoiceCode");
        }
    }
}
