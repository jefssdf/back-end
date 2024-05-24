using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class entitiesAdjustments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_LegalEntities_Id",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_ServiceCategories_Id",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Services");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Services",
                newName: "LegalEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Services_Id",
                table: "Services",
                newName: "IX_Services_LegalEntityId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Services",
                type: "decimal(20,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceCategoryId",
                table: "Services",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_ServiceCategoryId",
                table: "Services",
                column: "ServiceCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_LegalEntities_LegalEntityId",
                table: "Services",
                column: "LegalEntityId",
                principalTable: "LegalEntities",
                principalColumn: "LegalEntityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_ServiceCategories_ServiceCategoryId",
                table: "Services",
                column: "ServiceCategoryId",
                principalTable: "ServiceCategories",
                principalColumn: "ServiceCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_LegalEntities_LegalEntityId",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_ServiceCategories_ServiceCategoryId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_ServiceCategoryId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ServiceCategoryId",
                table: "Services");

            migrationBuilder.RenameColumn(
                name: "LegalEntityId",
                table: "Services",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Services_LegalEntityId",
                table: "Services",
                newName: "IX_Services_Id");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Services",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,2)");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Duration",
                table: "Services",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddForeignKey(
                name: "FK_Services_LegalEntities_Id",
                table: "Services",
                column: "Id",
                principalTable: "LegalEntities",
                principalColumn: "LegalEntityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_ServiceCategories_Id",
                table: "Services",
                column: "Id",
                principalTable: "ServiceCategories",
                principalColumn: "ServiceCategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
