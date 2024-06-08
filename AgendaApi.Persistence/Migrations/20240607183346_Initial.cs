using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LegalEntities",
                columns: table => new
                {
                    LegalEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegalEntities", x => x.LegalEntityId);
                });

            migrationBuilder.CreateTable(
                name: "NaturalPersons",
                columns: table => new
                {
                    NaturalPersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NaturalPersons", x => x.NaturalPersonId);
                });

            migrationBuilder.CreateTable(
                name: "SchedulingStatus",
                columns: table => new
                {
                    SchedulingStatusId = table.Column<int>(type: "int", nullable: false),
                    StatusName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchedulingStatus", x => x.SchedulingStatusId);
                });

            migrationBuilder.CreateTable(
                name: "SuperAdmins",
                columns: table => new
                {
                    SuperAdminId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperAdmins", x => x.SuperAdminId);
                });

            migrationBuilder.CreateTable(
                name: "WeekDays",
                columns: table => new
                {
                    WeekDayId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeekDays", x => x.WeekDayId);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time(0)", precision: 0, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    LegalEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_Services_LegalEntities_LegalEntityId",
                        column: x => x.LegalEntityId,
                        principalTable: "LegalEntities",
                        principalColumn: "LegalEntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Timetables",
                columns: table => new
                {
                    TimetableId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartTime = table.Column<TimeOnly>(type: "time(0)", precision: 0, nullable: false),
                    EndTime = table.Column<TimeOnly>(type: "time(0)", precision: 0, nullable: false),
                    LegalEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WeekDayId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timetables", x => x.TimetableId);
                    table.ForeignKey(
                        name: "FK_Timetables_LegalEntities_LegalEntityId",
                        column: x => x.LegalEntityId,
                        principalTable: "LegalEntities",
                        principalColumn: "LegalEntityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Timetables_WeekDays_WeekDayId",
                        column: x => x.WeekDayId,
                        principalTable: "WeekDays",
                        principalColumn: "WeekDayId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schedulings",
                columns: table => new
                {
                    SchedulingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SolicitationDate = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: false),
                    ConfirmationDate = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: false),
                    SchedulingDate = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: false),
                    SchedulingStatusId = table.Column<int>(type: "int", nullable: false),
                    NaturalPersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LegalEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimetableId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedulings", x => x.SchedulingId);
                    table.ForeignKey(
                        name: "FK_Schedulings_LegalEntities_LegalEntityId",
                        column: x => x.LegalEntityId,
                        principalTable: "LegalEntities",
                        principalColumn: "LegalEntityId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Schedulings_NaturalPersons_NaturalPersonId",
                        column: x => x.NaturalPersonId,
                        principalTable: "NaturalPersons",
                        principalColumn: "NaturalPersonId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Schedulings_SchedulingStatus_SchedulingStatusId",
                        column: x => x.SchedulingStatusId,
                        principalTable: "SchedulingStatus",
                        principalColumn: "SchedulingStatusId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Schedulings_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Schedulings_Timetables_TimetableId",
                        column: x => x.TimetableId,
                        principalTable: "Timetables",
                        principalColumn: "TimetableId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Cancellations",
                columns: table => new
                {
                    CancellationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CancellationTime = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: false),
                    Owner = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SchedulingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cancellations", x => x.CancellationId);
                    table.ForeignKey(
                        name: "FK_Cancellations_Schedulings_SchedulingId",
                        column: x => x.SchedulingId,
                        principalTable: "Schedulings",
                        principalColumn: "SchedulingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cancellations_SchedulingId",
                table: "Cancellations",
                column: "SchedulingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Schedulings_LegalEntityId",
                table: "Schedulings",
                column: "LegalEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedulings_NaturalPersonId",
                table: "Schedulings",
                column: "NaturalPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedulings_SchedulingStatusId",
                table: "Schedulings",
                column: "SchedulingStatusId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Schedulings_ServiceId",
                table: "Schedulings",
                column: "ServiceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Schedulings_TimetableId",
                table: "Schedulings",
                column: "TimetableId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_LegalEntityId",
                table: "Services",
                column: "LegalEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Timetables_LegalEntityId",
                table: "Timetables",
                column: "LegalEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Timetables_WeekDayId",
                table: "Timetables",
                column: "WeekDayId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cancellations");

            migrationBuilder.DropTable(
                name: "SuperAdmins");

            migrationBuilder.DropTable(
                name: "Schedulings");

            migrationBuilder.DropTable(
                name: "NaturalPersons");

            migrationBuilder.DropTable(
                name: "SchedulingStatus");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Timetables");

            migrationBuilder.DropTable(
                name: "LegalEntities");

            migrationBuilder.DropTable(
                name: "WeekDays");
        }
    }
}
