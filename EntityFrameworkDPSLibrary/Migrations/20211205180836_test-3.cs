using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkDPSLibrary.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FlatNumber",
                table: "Seller",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ProductCode",
                table: "ProductsOnInvoice",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InvoiceNumber",
                table: "ProductsOnInvoice",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FlatNumber",
                table: "Buyer",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsOnInvoice_InvoiceNumber",
                table: "ProductsOnInvoice",
                column: "InvoiceNumber");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsOnInvoice_ProductCode",
                table: "ProductsOnInvoice",
                column: "ProductCode");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsOnInvoice_Invoice_InvoiceNumber",
                table: "ProductsOnInvoice",
                column: "InvoiceNumber",
                principalTable: "Invoice",
                principalColumn: "InvoiceNumber",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsOnInvoice_Product_ProductCode",
                table: "ProductsOnInvoice",
                column: "ProductCode",
                principalTable: "Product",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsOnInvoice_Invoice_InvoiceNumber",
                table: "ProductsOnInvoice");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsOnInvoice_Product_ProductCode",
                table: "ProductsOnInvoice");

            migrationBuilder.DropIndex(
                name: "IX_ProductsOnInvoice_InvoiceNumber",
                table: "ProductsOnInvoice");

            migrationBuilder.DropIndex(
                name: "IX_ProductsOnInvoice_ProductCode",
                table: "ProductsOnInvoice");

            migrationBuilder.AlterColumn<int>(
                name: "FlatNumber",
                table: "Seller",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductCode",
                table: "ProductsOnInvoice",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InvoiceNumber",
                table: "ProductsOnInvoice",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FlatNumber",
                table: "Buyer",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
