using Microsoft.EntityFrameworkCore.Migrations;

namespace MPACore.PhoneBook.Migrations
{
    public partial class Update_NewPersonAndNumberEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumber_PhoneNumber_TypeId",
                schema: "PB",
                table: "PhoneNumber");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumber_TypeId",
                schema: "PB",
                table: "PhoneNumber");

            migrationBuilder.DropColumn(
                name: "TypeId",
                schema: "PB",
                table: "PhoneNumber");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                schema: "PB",
                table: "PhoneNumber",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                schema: "PB",
                table: "PhoneNumber");

            migrationBuilder.AddColumn<long>(
                name: "TypeId",
                schema: "PB",
                table: "PhoneNumber",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_TypeId",
                schema: "PB",
                table: "PhoneNumber",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumber_PhoneNumber_TypeId",
                schema: "PB",
                table: "PhoneNumber",
                column: "TypeId",
                principalSchema: "PB",
                principalTable: "PhoneNumber",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
