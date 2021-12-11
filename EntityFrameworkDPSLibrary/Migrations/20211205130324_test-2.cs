using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkDPSLibrary.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsOnInvoice_Invoice_InvoiceCode",
                table: "ProductsOnInvoice");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsOnInvoice_Product_ProductCode",
                table: "ProductsOnInvoice");

            migrationBuilder.DropIndex(
                name: "IX_ProductsOnInvoice_InvoiceCode",
                table: "ProductsOnInvoice");

            migrationBuilder.DropIndex(
                name: "IX_ProductsOnInvoice_ProductCode",
                table: "ProductsOnInvoice");

            migrationBuilder.DropColumn(
                name: "InvoiceCode",
                table: "ProductsOnInvoice");

            migrationBuilder.AlterColumn<string>(
                name: "ProductCode",
                table: "ProductsOnInvoice",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductCode",
                table: "ProductsOnInvoice",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvoiceCode",
                table: "ProductsOnInvoice",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsOnInvoice_InvoiceCode",
                table: "ProductsOnInvoice",
                column: "InvoiceCode");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsOnInvoice_ProductCode",
                table: "ProductsOnInvoice",
                column: "ProductCode");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsOnInvoice_Invoice_InvoiceCode",
                table: "ProductsOnInvoice",
                column: "InvoiceCode",
                principalTable: "Invoice",
                principalColumn: "InvoiceNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsOnInvoice_Product_ProductCode",
                table: "ProductsOnInvoice",
                column: "ProductCode",
                principalTable: "Product",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
