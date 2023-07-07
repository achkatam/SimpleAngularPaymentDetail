using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentDetail.Data.Migrations
{
    public partial class SecCodeChangedToCvv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SecurityCode",
                table: "PaymentDetails",
                newName: "CVV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CVV",
                table: "PaymentDetails",
                newName: "SecurityCode");
        }
    }
}
