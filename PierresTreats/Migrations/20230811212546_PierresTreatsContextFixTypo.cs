using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PierresTreats.Migrations
{
    public partial class PierresTreatsContextFixTypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlavorsTreats_Flavors_FlavorId",
                table: "FlavorsTreats");

            migrationBuilder.DropForeignKey(
                name: "FK_FlavorsTreats_Treats_TreatId",
                table: "FlavorsTreats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlavorsTreats",
                table: "FlavorsTreats");

            migrationBuilder.RenameTable(
                name: "FlavorsTreats",
                newName: "FlavorTreats");

            migrationBuilder.RenameIndex(
                name: "IX_FlavorsTreats_TreatId",
                table: "FlavorTreats",
                newName: "IX_FlavorTreats_TreatId");

            migrationBuilder.RenameIndex(
                name: "IX_FlavorsTreats_FlavorId",
                table: "FlavorTreats",
                newName: "IX_FlavorTreats_FlavorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlavorTreats",
                table: "FlavorTreats",
                column: "FlavorTreatId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorTreats_Flavors_FlavorId",
                table: "FlavorTreats",
                column: "FlavorId",
                principalTable: "Flavors",
                principalColumn: "FlavorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorTreats_Treats_TreatId",
                table: "FlavorTreats",
                column: "TreatId",
                principalTable: "Treats",
                principalColumn: "TreatId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlavorTreats_Flavors_FlavorId",
                table: "FlavorTreats");

            migrationBuilder.DropForeignKey(
                name: "FK_FlavorTreats_Treats_TreatId",
                table: "FlavorTreats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlavorTreats",
                table: "FlavorTreats");

            migrationBuilder.RenameTable(
                name: "FlavorTreats",
                newName: "FlavorsTreats");

            migrationBuilder.RenameIndex(
                name: "IX_FlavorTreats_TreatId",
                table: "FlavorsTreats",
                newName: "IX_FlavorsTreats_TreatId");

            migrationBuilder.RenameIndex(
                name: "IX_FlavorTreats_FlavorId",
                table: "FlavorsTreats",
                newName: "IX_FlavorsTreats_FlavorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlavorsTreats",
                table: "FlavorsTreats",
                column: "FlavorTreatId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorsTreats_Flavors_FlavorId",
                table: "FlavorsTreats",
                column: "FlavorId",
                principalTable: "Flavors",
                principalColumn: "FlavorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorsTreats_Treats_TreatId",
                table: "FlavorsTreats",
                column: "TreatId",
                principalTable: "Treats",
                principalColumn: "TreatId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
